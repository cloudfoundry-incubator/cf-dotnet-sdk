using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CloudFoundry.CloudController.V2;
using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using System.Threading;
using CloudFoundry.UAA;

namespace CloudFoundry.CloudController.Test.Integration
{
    [TestClass]
    public class PushTest
    {
        [TestMethod]
        public void PushJobTest()
        {
            string appPath = @"C:\temp\WebApplication1";

            var client = TestUtil.GetClient();
            CloudCredentials credentials = new CloudCredentials();
            credentials.User = TestUtil.User;
            credentials.Password = TestUtil.Password;
            try
            {
                client.Login(credentials).Wait();
            }
            catch (Exception ex)
            {
                Assert.Fail("Error while loging in" + ex.ToString());
            }

            PushJob job = new PushJob(client);

            PagedResponseCollection<ListAllSpacesResponse> spaces = client.Spaces.ListAllSpaces().Result;

            var spaceGuid = string.Empty;

            foreach(ListAllSpacesResponse space in spaces){
                spaceGuid = space.EntityMetadata.Guid;
                break;
            }

            if (spaceGuid == string.Empty)
            {
                throw new Exception("No spaces found");
            }

            PagedResponseCollection<ListAllStacksResponse> stacks = client.Stacks.ListAllStacks().Result;

            var winStack = string.Empty;

            foreach (ListAllStacksResponse stack in stacks)
            {
                if (stack.Name == "win2012")
                {
                    winStack = stack.EntityMetadata.Guid;
                    break;
                }
            }

            if (winStack == string.Empty)
            {
                throw new Exception("Could not test on a deployment without a windows 2012 stack");
            }

            PagedResponseCollection<ListAllAppsResponse> apps = client.Apps.ListAllApps().Result;

            foreach (ListAllAppsResponse app in apps)
            {
                if (app.Name == "simplePushTest")
                {
                    client.Apps.DeleteApp(new Guid(app.EntityMetadata.Guid)).Wait();
                    break;
                }
            }

            CreateAppRequest apprequest = new CreateAppRequest();
            apprequest.Name = "simplePushTest";
            apprequest.Memory = 512;
            apprequest.Instances = 1;
            apprequest.SpaceGuid = new Guid(spaceGuid);
            apprequest.StackGuid = new Guid(winStack);

            CancellationTokenSource cts = new CancellationTokenSource();

            Progress<ProgressInfo> prog = new Progress<ProgressInfo>(new Action<ProgressInfo>((ProgressInfo a) => { System.Diagnostics.Debug.Print(a.Message + " " + a.Percent); }));

            job.Push(apprequest, appPath,@"C:\tmp2\", prog, cts).Wait();

            Assert.IsTrue(true);
        }
    }
}
