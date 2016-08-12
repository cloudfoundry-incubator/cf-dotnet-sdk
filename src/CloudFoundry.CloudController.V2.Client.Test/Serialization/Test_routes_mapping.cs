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
    public class RoutesMappingTest
    {

        [TestMethod]
        public void TestMappingAppAndRouteRequest()
        {
            string json = @"{
  ""app_guid"": ""0226530e-e999-4682-a869-b4b2a1ccdd8a"",
  ""route_guid"": ""0226530e-e999-4682-a869-b4b2a1ccdd8a"",
  ""app_port"": 8888
}";

            MappingAppAndRouteRequest request = new MappingAppAndRouteRequest();

            request.AppGuid = new Guid("0226530e-e999-4682-a869-b4b2a1ccdd8a");
            request.RouteGuid = new Guid("0226530e-e999-4682-a869-b4b2a1ccdd8a");
            request.AppPort = 8888;
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
        [TestMethod]
        public void TestUpdateRouteMappingRequest()
        {
            string json = @"{
  ""app_port"": 8889
}";

            UpdateRouteMappingRequest request = new UpdateRouteMappingRequest();

            request.AppPort = 8889;
            string result = JsonConvert.SerializeObject(request, Formatting.None);
            Assert.AreEqual(TestUtil.ToUnformatedJsonString(json), result);
        }
    }
}