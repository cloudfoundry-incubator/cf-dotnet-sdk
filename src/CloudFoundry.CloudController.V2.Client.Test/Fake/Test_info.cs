//------------------------------------------------------------------------------
// <auto-generated>
  //     This code was generated by a tool.
  //
  //     Changes to this file may cause incorrect behavior and will be lost if
  //     the code is regenerated.
  // </auto-generated>
//------------------------------------------------------------------------------

//
// This source code was auto-generated by cf-sdk-builder
//

using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom.Compiler;
using System.Net;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client.Test.Fake
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class InfoEndpoint
{
        [TestMethod]
        public void GetInfoTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""name"": ""vcap"",
  ""build"": ""2222"",
  ""support"": ""http://support.cloudfoundry.com"",
  ""version"": 2,
  ""description"": ""Cloud Foundry sponsored by Pivotal"",
  ""authorization_endpoint"": ""http://localhost:8080/uaa"",
  ""token_endpoint"": ""http://localhost:8080/uaa"",
  ""min_cli_version"": null,
  ""min_recommended_cli_version"": null,
  ""api_version"": ""2.53.0"",
  ""app_ssh_endpoint"": ""ssh.system.domain.example.com:2222"",
  ""app_ssh_host_key_fingerprint"": ""47:0d:d1:c8:c3:3d:0a:36:d1:49:2f:f2:90:27:31:d0"",
  ""app_ssh_oauth_client"": null,
  ""routing_endpoint"": ""http://localhost:3000"",
  ""logging_endpoint"": ""ws://loggregator.vcap.me:80""
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Info.GetInfo().Result;


                Assert.AreEqual("vcap", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("2222", TestUtil.ToTestableString(obj.Build), true);
                Assert.AreEqual("http://support.cloudfoundry.com", TestUtil.ToTestableString(obj.Support), true);
                Assert.AreEqual("2", TestUtil.ToTestableString(obj.Version), true);
                Assert.AreEqual("Cloud Foundry sponsored by Pivotal", TestUtil.ToTestableString(obj.Description), true);
                Assert.AreEqual("http://localhost:8080/uaa", TestUtil.ToTestableString(obj.AuthorizationEndpoint), true);
                Assert.AreEqual("http://localhost:8080/uaa", TestUtil.ToTestableString(obj.TokenEndpoint), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.MinCliVersion), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.MinRecommendedCliVersion), true);
                Assert.AreEqual("2.53.0", TestUtil.ToTestableString(obj.ApiVersion), true);
                Assert.AreEqual("ssh.system.domain.example.com:2222", TestUtil.ToTestableString(obj.AppSshEndpoint), true);
                Assert.AreEqual("47:0d:d1:c8:c3:3d:0a:36:d1:49:2f:f2:90:27:31:d0", TestUtil.ToTestableString(obj.AppSshHostKeyFingerprint), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.AppSshOauthClient), true);
                Assert.AreEqual("http://localhost:3000", TestUtil.ToTestableString(obj.RoutingEndpoint), true);
                Assert.AreEqual("ws://loggregator.vcap.me:80", TestUtil.ToTestableString(obj.LoggingEndpoint), true);

            }
        }

    }
}