namespace CloudFoundry.CloudController.V2.Client
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using CloudFoundry.CloudController.Common.Http;
    using CloudFoundry.CloudController.V2.Client.ClientExtensions;
    using CloudFoundry.CloudController.V2.Client.Data;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using PCLCrypto;
    using PCLStorage;

    public partial class AppsEndpoint
    {
        private const int StepCount = 5;

        private List<string> fileList;

        public event EventHandler<ProgressEventArgs> Progress;
        
        /// <summary>
        /// Pushed the application to the cloud
        /// </summary>
        /// <param name="app">Basic information needed to create an app</param>
        /// <param name="appPath">Path of origin from which the application will be deployed</param>
        /// <param name="tempPath">Temporary path used for application processing before upload</param>
        /// <param name="cancellationSource">Cancellation token source</param>
        public async Task<Guid?> Push(CreateAppRequest app, string appPath, string tempPath, CancellationTokenSource cancellationSource)
        {
            int usedSteps = 1;
            this.Progress(this, new ProgressEventArgs() { Message = string.Format(CultureInfo.InvariantCulture, "Creating application {0}", app.Name), Percent = usedSteps / StepCount * 100 });
            
            this.fileList = new List<string>();

            CreateAppResponse createResult = await CreateApp(app);

            if (cancellationSource.IsCancellationRequested)
            {
                this.Progress(this, new ProgressEventArgs() { Message = string.Format(CultureInfo.InvariantCulture, "Cancelled pushing application {0}", app.Name), Percent = usedSteps / StepCount * 100 });
                return null;
            }

            usedSteps += 1;
            string tempDir = PortablePath.Combine(tempPath, "cloudfoundry\\" + Guid.NewGuid().ToString("N"));
            IFolder temp = await FileSystem.Current.LocalStorage.CreateFolderAsync(tempDir, CreationCollisionOption.ReplaceExisting);
            string uploadFile = PortablePath.Combine(temp.Path, app.Name + ".zip");

            if (FileSystem.Current.LocalStorage.CheckExistsAsync(uploadFile).Result == ExistenceCheckResult.FileExists)
            {
                IFile file = await FileSystem.Current.LocalStorage.GetFileAsync(uploadFile);
                await file.DeleteAsync();
            }

            string explodeDir = PortablePath.Combine(tempDir, string.Format("cf_{0}_files", app.Name));
            if (FileSystem.Current.LocalStorage.CheckExistsAsync(explodeDir).Result == ExistenceCheckResult.FolderExists)
            {
                IFolder explodeOld = await FileSystem.Current.LocalStorage.GetFolderAsync(explodeDir);
                await explodeOld.DeleteAsync();
            }

            IFolder explode = await FileSystem.Current.LocalStorage.CreateFolderAsync(explodeDir, CreationCollisionOption.ReplaceExisting);

            await this.CopyFilesToExplodeDirectory(appPath, explodeDir);

            List<Dictionary<string, object>> fingerprints = await this.GetAppFingerprints(appPath);

            Dictionary<string, object> uploadRequest = new Dictionary<string, object>();
            uploadRequest.Add("resources", fingerprints);
            uploadRequest.Add("application", uploadFile);

            this.Progress(this, new ProgressEventArgs() { Message = "Comparing application fingerprints", Percent = usedSteps / StepCount * 100 });
            
            string resourceManifest = await this.GetRawResources(fingerprints);

            List<Dictionary<string, object>> cloudFigerprints = new List<Dictionary<string, object>>();

            if (JsonConvert.SerializeObject(fingerprints) != resourceManifest)
            {
                JArray filesNedded = (JArray)JsonConvert.DeserializeObject(resourceManifest);

                cloudFigerprints = await PreparePayloadDirectory(explodeDir, fingerprints, filesNedded);

                // If no resource needs to be sent, add an empty file to ensure we have
                // a multi-part request that is expected by nginx fronting the CC.
                if (this.GetAllFiles(explodeDir).Result.Count == 0)
                {
                    IFile emptyFile = await FileSystem.Current.LocalStorage.CreateFileAsync(PortablePath.Combine(explodeDir, ".__empty__"), CreationCollisionOption.ReplaceExisting);
                    await emptyFile.WriteAllTextAsync(Guid.NewGuid().ToString("N"));
                }
            }

            usedSteps += 1;
            if (cancellationSource.IsCancellationRequested)
            {
                this.Progress(this, new ProgressEventArgs() { Message = string.Format(CultureInfo.InvariantCulture, "Cancelled pushing application {0}", app.Name), Percent = usedSteps / StepCount * 100 });
                return null;
            }

            this.Progress(this, new ProgressEventArgs() { Message = "Creating zip package", Percent = usedSteps / StepCount * 100 });
            
            await ZipUtil.ZipFolder(explodeDir, uploadFile);
            if (cancellationSource.IsCancellationRequested)
            {
                this.Progress(this, new ProgressEventArgs() { Message = string.Format(CultureInfo.InvariantCulture, "Cancelled pushing application {0}", app.Name), Percent = usedSteps / StepCount * 100 });
                return null;
            }

            usedSteps += 1;

            this.Progress(this, new ProgressEventArgs() { Message = "Uploading zip package", Percent = usedSteps / StepCount * 100 });
            
            string route = string.Format(CultureInfo.InvariantCulture, "/v2/apps/{0}/bits", createResult.EntityMetadata.Guid);
            string endpoint = string.Format(CultureInfo.InvariantCulture, "{0}{1}", this.Client.CloudTarget.AbsoluteUri.ToString().TrimEnd('/'), route);

            IHttpResponseAbstraction uploadResult;
            if (cloudFigerprints.Count == 0)
            {
                string serializedFingerprints = JsonConvert.SerializeObject(fingerprints);
                uploadResult = await this.UploadZip(new Uri(endpoint), uploadFile, serializedFingerprints);
            }
            else
            {
                string serializedFingerprints = JsonConvert.SerializeObject(cloudFigerprints);
                uploadResult = await this.UploadZip(new Uri(endpoint), uploadFile, serializedFingerprints);
            }

            usedSteps += 1;
            this.Progress(this, new ProgressEventArgs() { Message = string.Format(CultureInfo.InvariantCulture, "Application {0} pushed successfully with result {1}", app.Name, uploadResult.ReadContentAsStringAsync()), Percent = usedSteps / StepCount * 100 });
            
            return new Guid(createResult.EntityMetadata.Guid);
        }

        private static string CalculateSha1Hash(byte[] input)
        {
            var hasher = WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha1);
            byte[] hash = hasher.HashData(input);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }

        private static async Task<List<Dictionary<string, object>>> PreparePayloadDirectory(string explodeDir, List<Dictionary<string, object>> fingerprints, JArray filesNedded)
        {
            List<Dictionary<string, object>> cloudFigerprints = new List<Dictionary<string, object>>();

            foreach (var fingerPrint in fingerprints)
            {
                bool found = false;
                foreach (var fileInfo in filesNedded)
                {
                    if (fileInfo["sha1"].ToString() == fingerPrint["sha1"].ToString())
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    cloudFigerprints.Add(fingerPrint);
                    string filePath = PortablePath.Combine(explodeDir, fingerPrint["fn"].ToString());
                    if (FileSystem.Current.LocalStorage.CheckExistsAsync(filePath).Result == ExistenceCheckResult.FileExists)
                    {
                        IFile fileOld = await FileSystem.Current.LocalStorage.GetFileAsync(filePath);
                        await fileOld.DeleteAsync();
                    }
                }
            }

            return cloudFigerprints;
        }

        private async Task<List<Dictionary<string, object>>> GetAppFingerprints(string appPath)
        {
            List<Dictionary<string, object>> fingerprints = new List<Dictionary<string, object>>();
            string[] resource_files = (await this.GetAllFiles(appPath)).ToArray();

            foreach (string filename in resource_files)
            {
                IFile file = await FileSystem.Current.RoamingStorage.GetFileAsync(filename);
                string sha1 = string.Empty;

                byte[] content = await Utilities.ReadFile(file);
                sha1 = CalculateSha1Hash(content);

                fingerprints.Add(new Dictionary<string, object>()
                {
                    { "size", content.Length },
                    { "sha1", sha1 },
                    { "fn", file.Name }
                });
            }

            return fingerprints;
        }

        private async Task<IHttpResponseAbstraction> UploadZip(Uri uploadUri, string file, string resources)
        {
            string boundary = DateTime.Now.Ticks.ToString("x");

            HttpAbstractionClientFactory fact = new HttpAbstractionClientFactory();

            using (var httpClient = fact.Create())
            {
                httpClient.Headers.Add("Authorization", string.Format("bearer {0}", this.Client.AuthorizationToken));

                httpClient.Uri = uploadUri;
                httpClient.Headers.Add("Accept", "*/*; q=0.5, application/xml");
                httpClient.Headers.Add("Accept-Encoding", "gzip, deflate");
                httpClient.Method = HttpMethod.Post;

                IFile fileInfo = await FileSystem.Current.LocalStorage.GetFileAsync(file);

                List<HttpMultipartFormDataAbstraction> mpd = new List<HttpMultipartFormDataAbstraction>();

                using (Stream fileStream = await fileInfo.OpenAsync(FileAccess.Read))
                {
                    mpd.Add(new HttpMultipartFormDataAbstraction("application", Path.GetFileName(file), "application/zip", fileStream));

                    using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(resources)))
                    {
                        ms.Position = 0;
                        mpd.Add(new HttpMultipartFormDataAbstraction("resources", string.Empty, string.Empty, ms));
                        IHttpResponseAbstraction response = await httpClient.SendAsync(mpd);
                        return response;
                    }
                }
            }
        }

        private async Task CopyFilesToExplodeDirectory(string appPath, string explodeDir)
        {
            var folderExists = await FileSystem.Current.LocalStorage.CheckExistsAsync(explodeDir); 
            if (folderExists != ExistenceCheckResult.FolderExists)
            {
                await FileSystem.Current.LocalStorage.CreateFolderAsync(explodeDir, CreationCollisionOption.ReplaceExisting);
            }

            IFolder appFolder = await PCLStorage.FileSystem.Current.GetFolderFromPathAsync(appPath);

            if (appFolder == null)
            {
                return;
            }

            IList<IFile> files = await appFolder.GetFilesAsync();

            foreach (IFile file in files)
            {
                byte[] content = await Utilities.ReadFile(file);
                await Utilities.WriteFile(content, PortablePath.Combine(explodeDir, file.Name));
            }

            IList<IFolder> subFolders = await appFolder.GetFoldersAsync();

            foreach (IFolder folder in subFolders)
            {
                await this.CopyFilesToExplodeDirectory(folder.Path, Path.Combine(explodeDir, folder.Name));
            }
        }

        private async Task<List<string>> GetAllFiles(string appPath)
        {
            IFolder appFolder = await PCLStorage.FileSystem.Current.GetFolderFromPathAsync(appPath);

            IList<IFile> files = await appFolder.GetFilesAsync();

            foreach (IFile file in files)
            {
                this.fileList.Add(file.Path);
            }

            IList<IFolder> subFolders = await appFolder.GetFoldersAsync();

            foreach (IFolder folder in subFolders)
            {
                await this.GetAllFiles(folder.Path);
            }

            return this.fileList;
        }

        private async Task<string> GetRawResources(ICollection<Dictionary<string, object>> fingerprints)
        {
            List<ListAllMatchingResourcesRequest> matchRequest = new List<ListAllMatchingResourcesRequest>();

            foreach (var fingerprint in fingerprints)
            {
                ListAllMatchingResourcesRequest match = new ListAllMatchingResourcesRequest()
                {
                    Sha1 = (string)fingerprint["sha1"],
                    Size = Convert.ToInt32(fingerprint["size"])
                };
                matchRequest.Add(match);
            }

            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            List<Dictionary<string, object>> matchingResult = new List<Dictionary<string, object>>();

            ListAllMatchingResourcesResponse[] response = await this.Client.ResourceMatch.ListAllMatchingResources(matchRequest.ToArray());

            foreach (ListAllMatchingResourcesResponse resource in response)
            {
                string sha1 = resource.Sha1;
                double? size = resource.Size;
                string fn = (string)fingerprints.First(f => f["sha1"].ToString() == sha1)["fn"];

                matchingResult.Add(new Dictionary<string, object>()
                  {
                    { "sha1", sha1 },
                    { "fn", fn },
                    { "size", size }
                  });
            }

            foreach (var fingerprint in fingerprints)
            {
                var match = matchingResult.Where(o => o["sha1"].ToString() == fingerprint["sha1"].ToString()).FirstOrDefault();
                if (match == null)
                {
                    result.Add(fingerprint);
                }
            }

            if (result.Count == 0)
            {
                return JsonConvert.SerializeObject(fingerprints);
            }

            return JsonConvert.SerializeObject(result);
        }
    }
}
