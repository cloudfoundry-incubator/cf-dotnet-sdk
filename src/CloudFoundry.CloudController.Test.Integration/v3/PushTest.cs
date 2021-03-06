﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CCV3 = CloudFoundry.CloudController.V3.Client;
using CloudFoundry.CloudController.V2;
using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using System.Threading;
using CloudFoundry.UAA;
using System.Configuration;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.Test.Integration.V3
{
    [TestClass]
    [DeploymentItem("Assets")]
    public class PushTest
    {
        private static string appPath = TestUtil.NodeTestApp;
        private static CCV3.CloudFoundryClient v3client;
        private static CloudFoundryClient client;
        private static CCV3.Data.CreateAppRequest apprequest;

        [TestInitialize]
        public void TestInit()
        {
            client = TestUtil.GetClient();
            v3client = TestUtil.GetV3Client();
            CloudCredentials credentials = new CloudCredentials();
            credentials.User = TestUtil.User;
            credentials.Password = TestUtil.Password;
            try
            {
                client.Login(credentials).Wait();
            }
            catch (Exception ex)
            {
                Assert.Fail("Error while logging in" + ex.ToString());
            }

            try
            {
                v3client.Login(credentials).Wait();
            }
            catch (Exception ex)
            {
                Assert.Fail("Error while logging in" + ex.ToString());
            }

            PagedResponseCollection<ListAllSpacesResponse> spaces = client.Spaces.ListAllSpaces().Result;

            Guid spaceGuid = Guid.Empty;

            foreach (ListAllSpacesResponse space in spaces)
            {
                spaceGuid = space.EntityMetadata.Guid;
                break;
            }

            if (spaceGuid == Guid.Empty)
            {
                throw new Exception("No spaces found");
            }

            CCV3.PagedResponseCollection<CCV3.Data.ListAllAppsResponse> apps = v3client.AppsExperimental.ListAllApps().Result;

            foreach (CCV3.Data.ListAllAppsResponse app in apps)
            {
                if (app.Name.StartsWith("simplePushTest"))
                {
                    v3client.AppsExperimental.DeleteApp(app.Guid).Wait();
                    break;
                }
            }

            apprequest = new CCV3.Data.CreateAppRequest();
            Dictionary<string, object> s = new Dictionary<string, object>();
            s["guid"] = spaceGuid;
            apprequest.Relationships = new Dictionary<string, dynamic>();
            apprequest.Relationships["space"] = s;
            client.Apps.PushProgress += Apps_PushProgress;
        }

        static void Apps_PushProgress(object sender, PushProgressEventArgs e)
        {
            Console.WriteLine(e.Message + " " + e.Percent);
        }

        [TestMethod, Ignore]
        [TestCategory("v3")]
        public void PushJobTest()
        {
            apprequest.Name = "simplePushTest" + Guid.NewGuid().ToString("N");

            CCV3.Data.CreateAppResponse app = v3client.AppsExperimental.CreateApp(apprequest).Result;

            Guid appGuid = new Guid(app.Guid.ToString());

            try
            {
                v3client.AppsExperimental.Push(appGuid, TestUtil.NodeTestApp, "cflinuxfs2", null, true, 512, 4096).Wait();
            }
            finally
            {
                v3client.AppsExperimental.DeleteApp(appGuid).Wait();
            }
        }
    }
}