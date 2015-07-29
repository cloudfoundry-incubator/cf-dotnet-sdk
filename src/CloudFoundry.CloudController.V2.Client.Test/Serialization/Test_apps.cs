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

using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.CloudController.V2.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Test.Serialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class AppsTest
    {

        [TestMethod]
        public void TestCopyAppBitsForAppRequest()
        {
            string json = @"{""source_app_guid"":""99c7edab-ef91-4966-9970-fd4f9fbf1646""}";

            CopyAppBitsForAppRequest request = new CopyAppBitsForAppRequest();

            request.SourceAppGuid = new Guid("99c7edab-ef91-4966-9970-fd4f9fbf1646");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateAppRequest()
        {
            string json = @"{
  ""name"": ""my_super_app"",
  ""space_guid"": ""5331b875-20e0-4df1-a413-8e149f8249e2""
}";

            CreateAppRequest request = new CreateAppRequest();

            request.Name = "my_super_app";
            request.SpaceGuid = new Guid("5331b875-20e0-4df1-a413-8e149f8249e2");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestUpdateAppRequest()
        {
            string json = @"{
  ""name"": ""new_name""
}";

            UpdateAppRequest request = new UpdateAppRequest();

            request.Name = "new_name";
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateDockerAppExperimentalRequest()
        {
            string json = @"{
  ""name"": ""docker_app"",
  ""space_guid"": ""9931c683-03e1-40d4-80a7-36ac84e255b9"",
  ""docker_image"": ""cloudfoundry/hello"",
  ""diego"": true
}";

            CreateDockerAppExperimentalRequest request = new CreateDockerAppExperimentalRequest();

            request.Name = "docker_app";
            request.SpaceGuid = new Guid("9931c683-03e1-40d4-80a7-36ac84e255b9");
            request.DockerImage = "cloudfoundry/hello";
            request.Diego = true;
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
