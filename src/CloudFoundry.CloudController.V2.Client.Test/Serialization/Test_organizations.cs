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
    public class OrganizationsTest
    {

        [TestMethod]
        public void TestUpdateOrganizationRequest()
        {
            string json = @"{
  ""name"": ""New Organization Name"",
  ""quota_definition_guid"": ""61b501c7-0b25-45f3-9f5d-cd723f3fde94""
}";

            UpdateOrganizationRequest request = new UpdateOrganizationRequest();

            request.Name = "New Organization Name";
            request.QuotaDefinitionGuid = new Guid("61b501c7-0b25-45f3-9f5d-cd723f3fde94");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestCreateOrganizationRequest()
        {
            string json = @"{
  ""name"": ""my-org-name"",
  ""quota_definition_guid"": ""8eb423aa-1e8e-45e6-94ab-c195d489b9d0""
}";

            CreateOrganizationRequest request = new CreateOrganizationRequest();

            request.Name = "my-org-name";
            request.QuotaDefinitionGuid = new Guid("8eb423aa-1e8e-45e6-94ab-c195d489b9d0");
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}
