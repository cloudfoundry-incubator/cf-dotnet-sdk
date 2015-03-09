namespace CloudFoundry.CloudController.V2.Client
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using CloudFoundry.CloudController.Common.Http;
    using CloudFoundry.CloudController.V2.Client.Data;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using PCLCrypto;
    using PCLStorage;

    public class PushJob
    {
        private CloudFoundryClient client;
        private List<string> fileList;

        public PushJob(CloudFoundryClient clientInfo)
        {
            this.client = clientInfo;
        }

        public async Task Push(CreateAppRequest app, string appPath, string tempPath, IProgress<ProgressInfo> progress, CancellationTokenSource cancellationSource)
        {
            ProgressInfo progressDetails = new ProgressInfo();

            progressDetails.Percent = 10;
            progressDetails.Message = string.Format("Creating application {0}", app.Name);
            progress.Report(progressDetails);

            this.fileList = new List<string>();

            CreateAppResponse createResult = await this.client.Apps.CreateApp(app);

            if (cancellationSource.IsCancellationRequested)
            {
                progressDetails.Message = "Task cancelled";
                progress.Report(progressDetails);
            }

            string tempDir = PortablePath.Combine(tempPath, "hpcf\\" + Guid.NewGuid().ToString("N"));
            IFolder temp = await FileSystem.Current.LocalStorage.CreateFolderAsync(tempDir, CreationCollisionOption.ReplaceExisting);
            string uploadFile = PortablePath.Combine(temp.Path, app.Name + ".zip");

            if (FileSystem.Current.LocalStorage.CheckExistsAsync(uploadFile).Result == ExistenceCheckResult.FileExists)
            {
                IFile file = await FileSystem.Current.LocalStorage.GetFileAsync(uploadFile);
                await file.DeleteAsync();
            }

            string explodeDir = PortablePath.Combine(tempDir, string.Format("vmc_{0}_files", app.Name));
            if (FileSystem.Current.LocalStorage.CheckExistsAsync(explodeDir).Result == ExistenceCheckResult.FolderExists)
            {
                IFolder explodeOld = await FileSystem.Current.LocalStorage.GetFolderAsync(explodeDir);
                await explodeOld.DeleteAsync();
            }

            IFolder explode = await FileSystem.Current.LocalStorage.CreateFolderAsync(explodeDir, CreationCollisionOption.ReplaceExisting);

            await this.CopyFilesToExplodeDirectory(appPath, explodeDir);

            List<Dictionary<string, object>> fingerprints = new List<Dictionary<string, object>>();

            string[] resource_files = (await this.GetAllFiles(appPath)).ToArray();

            foreach (string filename in resource_files)
            {
                IFile file = await FileSystem.Current.RoamingStorage.GetFileAsync(filename);
                string sha1 = string.Empty;

                string content = await file.ReadAllTextAsync();
                sha1 = this.CalculateSha1Hash(content);

                fingerprints.Add(new Dictionary<string, object>()
                {
                    { "size", content.Length },
                    { "sha1", sha1 },
                    { "fn", file.Name }
                });
            }

            Dictionary<string, object> uploadRequest = new Dictionary<string, object>();
            uploadRequest.Add("resources", fingerprints);
            uploadRequest.Add("application", uploadFile);

            progressDetails.Message = "Comparing application fingerprints";
            progressDetails.Percent = 30;
            progress.Report(progressDetails);

            string resourceManifest = await this.GetRawResources(fingerprints);

            List<Dictionary<string, object>> cloudFigerprints = new List<Dictionary<string, object>>();

            if (JsonConvert.SerializeObject(fingerprints) != resourceManifest)
            {
                JArray filesNedded = (JArray)JsonConvert.DeserializeObject(resourceManifest);

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

                // If no resource needs to be sent, add an empty file to ensure we have
                // a multi-part request that is expected by nginx fronting the CC.
                if (this.GetAllFiles(explodeDir).Result.Count == 0)
                {
                    IFile emptyFile = await FileSystem.Current.LocalStorage.CreateFileAsync(PortablePath.Combine(explodeDir, ".__empty__"), CreationCollisionOption.ReplaceExisting);
                    await emptyFile.WriteAllTextAsync(Guid.NewGuid().ToString("N"));
                }
            }

            progressDetails.Message = "Creating zip package";
            progressDetails.Percent = 50;

            progress.Report(progressDetails);

            await ZipUtil.ZipFolder(explodeDir, uploadFile);

            progressDetails.Message = "Uploading zip package";
            progressDetails.Percent = 80;

            progress.Report(progressDetails);

            string route = string.Format("/v2/apps/{0}/bits", createResult.EntityMetadata.Guid);
            string endpoint = string.Format("{0}{1}", this.client.CloudTarget.AbsoluteUri.ToString().TrimEnd('/'), route);

            if (cloudFigerprints.Count == 0)
            {
                string result = this.UploadZip(new Uri(endpoint), uploadFile, JsonConvert.SerializeObject(fingerprints)).Result.ReadContentAsStringAsync().Result;
            }
            else
            {
                string result = this.UploadZip(new Uri(endpoint), uploadFile, JsonConvert.SerializeObject(cloudFigerprints)).Result.ReadContentAsStringAsync().Result;
            }

            progressDetails.Message = string.Format("{0} pushed successfully", app.Name);
            progressDetails.Percent = 100;

            progress.Report(progressDetails);
        }

        private async Task<IHttpResponseAbstraction> UploadZip(Uri uploadUri, string file, string resources)
        {
            string boundary = DateTime.Now.Ticks.ToString("x");

            HttpAbstractionClientFactory fact = new HttpAbstractionClientFactory();

            var httpClient = fact.Create();

            httpClient.Headers.Add("Authorization", string.Format("bearer {0}", this.client.AuthorizationToken));

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

        private async Task CopyFilesToExplodeDirectory(string appPath, string explodeDir)
        {
            if (FileSystem.Current.LocalStorage.CheckExistsAsync(explodeDir).Result != ExistenceCheckResult.FolderExists)
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
                string content = await file.ReadAllTextAsync();
                IFile destination = await FileSystem.Current.LocalStorage.CreateFileAsync(Path.Combine(explodeDir, file.Name), CreationCollisionOption.ReplaceExisting);
                await destination.WriteAllTextAsync(content);
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Justification = "Keep it working"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.Byte.ToString(System.String)", Justification = "Keep it working")]
        private string CalculateSha1Hash(string input)
        {
            var hasher = WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha1);
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hash = hasher.HashData(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
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

            ListAllMatchingResourcesResponse[] response = await this.client.ResourceMatch.ListAllMatchingResources(matchRequest.ToArray());

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
