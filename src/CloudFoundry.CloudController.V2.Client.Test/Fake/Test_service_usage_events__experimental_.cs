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
    public class ServiceUsageEventsExperimentalEndpoint
{
        [TestMethod]
        public void ListServiceUsageEventsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 2,
  ""total_pages"": 2,
  ""prev_url"": null,
  ""next_url"": ""/v2/service_usage_events?after_guid=eb6eaea4-2433-4b8c-8941-bb6145c8b27c=asc=2=1"",
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""f1a74e4e-73bb-449c-ad72-3d9f67c8cb98"",
        ""url"": ""/v2/service_usage_events/f1a74e4e-73bb-449c-ad72-3d9f67c8cb98"",
        ""created_at"": ""2015-05-19T15:27:04+00:00""
      },
      ""entity"": {
        ""state"": ""CREATED"",
        ""org_guid"": ""guid-b2c60234-499c-4e50-9e6d-62f232aff97d"",
        ""space_guid"": ""guid-53f7fdb0-d7ea-4994-9c1a-75af3d56db34"",
        ""space_name"": ""name-122"",
        ""service_instance_guid"": ""guid-2c708c4b-6ac1-4304-aeb5-0590c839d0bb"",
        ""service_instance_name"": ""name-123"",
        ""service_instance_type"": ""type-2"",
        ""service_plan_guid"": ""guid-23db0555-ee8c-4d04-bd57-c6b9577516c7"",
        ""service_plan_name"": ""name-124"",
        ""service_guid"": ""guid-f7eaaa0e-889f-400f-a0c5-93d04f4e2075"",
        ""service_label"": ""label-25""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceUsageEventsExperimental.ListServiceUsageEvents().Result;

                Assert.AreEqual("2", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("2", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("/v2/service_usage_events?after_guid=eb6eaea4-2433-4b8c-8941-bb6145c8b27c=asc=2=1", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("f1a74e4e-73bb-449c-ad72-3d9f67c8cb98", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_usage_events/f1a74e4e-73bb-449c-ad72-3d9f67c8cb98", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("CREATED", TestUtil.ToTestableString(obj[0].State), true);
                Assert.AreEqual("guid-b2c60234-499c-4e50-9e6d-62f232aff97d", TestUtil.ToTestableString(obj[0].OrgGuid), true);
                Assert.AreEqual("guid-53f7fdb0-d7ea-4994-9c1a-75af3d56db34", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("name-122", TestUtil.ToTestableString(obj[0].SpaceName), true);
                Assert.AreEqual("guid-2c708c4b-6ac1-4304-aeb5-0590c839d0bb", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("name-123", TestUtil.ToTestableString(obj[0].ServiceInstanceName), true);
                Assert.AreEqual("type-2", TestUtil.ToTestableString(obj[0].ServiceInstanceType), true);
                Assert.AreEqual("guid-23db0555-ee8c-4d04-bd57-c6b9577516c7", TestUtil.ToTestableString(obj[0].ServicePlanGuid), true);
                Assert.AreEqual("name-124", TestUtil.ToTestableString(obj[0].ServicePlanName), true);
                Assert.AreEqual("guid-f7eaaa0e-889f-400f-a0c5-93d04f4e2075", TestUtil.ToTestableString(obj[0].ServiceGuid), true);
                Assert.AreEqual("label-25", TestUtil.ToTestableString(obj[0].ServiceLabel), true);

            }
        }

        [TestMethod]
        public void PurgeAndReseedServiceUsageEventsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();


                cfClient.ServiceUsageEventsExperimental.PurgeAndReseedServiceUsageEvents().Wait();

            }
        }

        [TestMethod]
        public void RetrieveServiceUsageEventTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""d40976e7-42cb-4f9d-8fd0-8165599a747d"",
    ""url"": ""/v2/service_usage_events/d40976e7-42cb-4f9d-8fd0-8165599a747d"",
    ""created_at"": ""2015-05-19T15:27:04+00:00""
  },
  ""entity"": {
    ""state"": ""CREATED"",
    ""org_guid"": ""guid-eafe847e-6984-4b51-b649-bff4c6e0b457"",
    ""space_guid"": ""guid-abec0981-f80a-44a2-9f0e-ce632541f5d5"",
    ""space_name"": ""name-137"",
    ""service_instance_guid"": ""guid-b9c01469-41f7-4647-bc0e-ccb3d7bb92ee"",
    ""service_instance_name"": ""name-138"",
    ""service_instance_type"": ""type-7"",
    ""service_plan_guid"": ""guid-2aa5c800-d8b8-4460-aaf5-712b35f0ace3"",
    ""service_plan_name"": ""name-139"",
    ""service_guid"": ""guid-d3998069-c067-47e2-b2c2-31a31537192f"",
    ""service_label"": ""label-30""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceUsageEventsExperimental.RetrieveServiceUsageEvent(guid).Result;


                Assert.AreEqual("d40976e7-42cb-4f9d-8fd0-8165599a747d", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_usage_events/d40976e7-42cb-4f9d-8fd0-8165599a747d", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("CREATED", TestUtil.ToTestableString(obj.State), true);
                Assert.AreEqual("guid-eafe847e-6984-4b51-b649-bff4c6e0b457", TestUtil.ToTestableString(obj.OrgGuid), true);
                Assert.AreEqual("guid-abec0981-f80a-44a2-9f0e-ce632541f5d5", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("name-137", TestUtil.ToTestableString(obj.SpaceName), true);
                Assert.AreEqual("guid-b9c01469-41f7-4647-bc0e-ccb3d7bb92ee", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("name-138", TestUtil.ToTestableString(obj.ServiceInstanceName), true);
                Assert.AreEqual("type-7", TestUtil.ToTestableString(obj.ServiceInstanceType), true);
                Assert.AreEqual("guid-2aa5c800-d8b8-4460-aaf5-712b35f0ace3", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
                Assert.AreEqual("name-139", TestUtil.ToTestableString(obj.ServicePlanName), true);
                Assert.AreEqual("guid-d3998069-c067-47e2-b2c2-31a31537192f", TestUtil.ToTestableString(obj.ServiceGuid), true);
                Assert.AreEqual("label-30", TestUtil.ToTestableString(obj.ServiceLabel), true);

            }
        }

    }
}