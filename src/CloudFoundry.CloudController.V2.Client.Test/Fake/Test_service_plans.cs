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
    public class ServicePlansEndpoint
{
        [TestMethod]
        public void DeleteServicePlansTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServicePlans.DeleteServicePlans(guid).Wait();

            }
        }

        [TestMethod]
        public void RetrieveServicePlanTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""295cc5a6-4d9b-4886-9141-06946079f437"",
    ""url"": ""/v2/service_plans/7cdfb900-4f34-4fce-9512-3b4208a9d244"",
    ""created_at"": ""2016-02-11T13:20:44Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1709"",
    ""free"": false,
    ""description"": ""desc-126"",
    ""service_guid"": ""295cc5a6-4d9b-4886-9141-06946079f437"",
    ""extra"": null,
    ""unique_id"": ""de871c2b-d863-4a8f-8a5f-5485bdc9613f"",
    ""public"": true,
    ""active"": true,
    ""service_url"": ""/v2/services/75d2a352-2139-4319-9c02-857145fd81e1"",
    ""service_instances_url"": ""/v2/service_plans/7cdfb900-4f34-4fce-9512-3b4208a9d244/service_instances""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServicePlans.RetrieveServicePlan(guid).Result;


                Assert.AreEqual("295cc5a6-4d9b-4886-9141-06946079f437", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plans/7cdfb900-4f34-4fce-9512-3b4208a9d244", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-11T13:20:44Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1709", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.Free), true);
                Assert.AreEqual("desc-126", TestUtil.ToTestableString(obj.Description), true);
                Assert.AreEqual("295cc5a6-4d9b-4886-9141-06946079f437", TestUtil.ToTestableString(obj.ServiceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
                Assert.AreEqual("de871c2b-d863-4a8f-8a5f-5485bdc9613f", TestUtil.ToTestableString(obj.UniqueId), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Public), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
                Assert.AreEqual("/v2/services/75d2a352-2139-4319-9c02-857145fd81e1", TestUtil.ToTestableString(obj.ServiceUrl), true);
                Assert.AreEqual("/v2/service_plans/7cdfb900-4f34-4fce-9512-3b4208a9d244/service_instances", TestUtil.ToTestableString(obj.ServiceInstancesUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServicePlansTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""97932ff8-cf8e-4726-bd10-d9c5e2559d4e"",
        ""url"": ""/v2/service_plans/1d6c576a-9e1e-45a4-8243-d98a39502387"",
        ""created_at"": ""2016-02-11T13:20:44Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1701"",
        ""free"": false,
        ""description"": ""desc-118"",
        ""service_guid"": ""97932ff8-cf8e-4726-bd10-d9c5e2559d4e"",
        ""extra"": null,
        ""unique_id"": ""5a0ce98d-a280-4161-ab9d-dd713a63e3b3"",
        ""public"": true,
        ""active"": true,
        ""service_url"": ""/v2/services/4494729c-a799-49da-af70-1306a5d3c4bf"",
        ""service_instances_url"": ""/v2/service_plans/1d6c576a-9e1e-45a4-8243-d98a39502387/service_instances""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServicePlans.ListAllServicePlans().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("97932ff8-cf8e-4726-bd10-d9c5e2559d4e", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plans/1d6c576a-9e1e-45a4-8243-d98a39502387", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-11T13:20:44Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1701", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Free), true);
                Assert.AreEqual("desc-118", TestUtil.ToTestableString(obj[0].Description), true);
                Assert.AreEqual("97932ff8-cf8e-4726-bd10-d9c5e2559d4e", TestUtil.ToTestableString(obj[0].ServiceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Extra), true);
                Assert.AreEqual("5a0ce98d-a280-4161-ab9d-dd713a63e3b3", TestUtil.ToTestableString(obj[0].UniqueId), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Public), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].Active), true);
                Assert.AreEqual("/v2/services/4494729c-a799-49da-af70-1306a5d3c4bf", TestUtil.ToTestableString(obj[0].ServiceUrl), true);
                Assert.AreEqual("/v2/service_plans/1d6c576a-9e1e-45a4-8243-d98a39502387/service_instances", TestUtil.ToTestableString(obj[0].ServiceInstancesUrl), true);

            }
        }

        [TestMethod]
        public void UpdateServicePlanDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""6dac9917-a39e-47d9-b03e-e66234e86d24"",
    ""url"": ""/v2/service_plans/126010c4-c5ec-431b-a7ce-1ad98c3c47fb"",
    ""created_at"": ""2016-02-11T13:20:44Z"",
    ""updated_at"": ""2016-02-11T13:20:44Z""
  },
  ""entity"": {
    ""name"": ""100mb"",
    ""free"": true,
    ""description"": ""Let's you put data in your database!"",
    ""service_guid"": ""6dac9917-a39e-47d9-b03e-e66234e86d24"",
    ""extra"": null,
    ""unique_id"": ""cfc0cec5-ac7d-41a8-b88a-3a44490c7bb0"",
    ""public"": true,
    ""active"": true,
    ""service_url"": ""/v2/services/69876f5a-112d-46ca-ae0d-e2c37aed2516"",
    ""service_instances_url"": ""/v2/service_plans/126010c4-c5ec-431b-a7ce-1ad98c3c47fb/service_instances""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                UpdateServicePlanDeprecatedRequest value = new UpdateServicePlanDeprecatedRequest();


                var obj = cfClient.ServicePlans.UpdateServicePlanDeprecated(value).Result;


                Assert.AreEqual("6dac9917-a39e-47d9-b03e-e66234e86d24", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plans/126010c4-c5ec-431b-a7ce-1ad98c3c47fb", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-11T13:20:44Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-02-11T13:20:44Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("100mb", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Free), true);
                Assert.AreEqual("Let's you put data in your database!", TestUtil.ToTestableString(obj.Description), true);
                Assert.AreEqual("6dac9917-a39e-47d9-b03e-e66234e86d24", TestUtil.ToTestableString(obj.ServiceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
                Assert.AreEqual("cfc0cec5-ac7d-41a8-b88a-3a44490c7bb0", TestUtil.ToTestableString(obj.UniqueId), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Public), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
                Assert.AreEqual("/v2/services/69876f5a-112d-46ca-ae0d-e2c37aed2516", TestUtil.ToTestableString(obj.ServiceUrl), true);
                Assert.AreEqual("/v2/service_plans/126010c4-c5ec-431b-a7ce-1ad98c3c47fb/service_instances", TestUtil.ToTestableString(obj.ServiceInstancesUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServiceInstancesForServicePlanTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""fccaab6e-ff05-4837-b9da-8b706f26e217"",
        ""url"": ""/v2/service_instances/aaaa354f-f56f-4990-92a7-1e2187c0d098"",
        ""created_at"": ""2016-02-11T13:20:45Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1712"",
        ""credentials"": {
          ""creds-key-481"": ""creds-val-481""
        },
        ""service_plan_guid"": ""fccaab6e-ff05-4837-b9da-8b706f26e217"",
        ""space_guid"": ""fccaab6e-ff05-4837-b9da-8b706f26e217"",
        ""gateway_data"": null,
        ""dashboard_url"": null,
        ""type"": ""managed_service_instance"",
        ""last_operation"": null,
        ""tags"": [

        ],
        ""space_url"": ""/v2/spaces/3e4640e1-3093-427c-b630-8ed96a8c6f22"",
        ""service_plan_url"": ""/v2/service_plans/059ba995-5586-412a-ac53-9903e96cb3ed"",
        ""service_bindings_url"": ""/v2/service_instances/aaaa354f-f56f-4990-92a7-1e2187c0d098/service_bindings"",
        ""service_keys_url"": ""/v2/service_instances/aaaa354f-f56f-4990-92a7-1e2187c0d098/service_keys"",
        ""routes_url"": ""/v2/service_instances/aaaa354f-f56f-4990-92a7-1e2187c0d098/routes""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServicePlans.ListAllServiceInstancesForServicePlan(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("fccaab6e-ff05-4837-b9da-8b706f26e217", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_instances/aaaa354f-f56f-4990-92a7-1e2187c0d098", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-11T13:20:45Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1712", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("fccaab6e-ff05-4837-b9da-8b706f26e217", TestUtil.ToTestableString(obj[0].ServicePlanGuid), true);
                Assert.AreEqual("fccaab6e-ff05-4837-b9da-8b706f26e217", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].GatewayData), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DashboardUrl), true);
                Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj[0].Type), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].LastOperation), true);
                Assert.AreEqual("/v2/spaces/3e4640e1-3093-427c-b630-8ed96a8c6f22", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/service_plans/059ba995-5586-412a-ac53-9903e96cb3ed", TestUtil.ToTestableString(obj[0].ServicePlanUrl), true);
                Assert.AreEqual("/v2/service_instances/aaaa354f-f56f-4990-92a7-1e2187c0d098/service_bindings", TestUtil.ToTestableString(obj[0].ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/service_instances/aaaa354f-f56f-4990-92a7-1e2187c0d098/service_keys", TestUtil.ToTestableString(obj[0].ServiceKeysUrl), true);
                Assert.AreEqual("/v2/service_instances/aaaa354f-f56f-4990-92a7-1e2187c0d098/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);

            }
        }

        [TestMethod]
        public void CreateServicePlanDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""4b378d7d-8323-4dd1-8b9f-7bb27c82d78e"",
    ""url"": ""/v2/service_plans/eba0b51b-a720-47d6-92c2-d3e69c046a56"",
    ""created_at"": ""2016-02-11T13:20:44Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""100mb"",
    ""free"": true,
    ""description"": ""Let's you put data in your database!"",
    ""service_guid"": ""4b378d7d-8323-4dd1-8b9f-7bb27c82d78e"",
    ""extra"": null,
    ""unique_id"": ""3f4b53ab-851a-48de-bf4b-3673931800e2"",
    ""public"": true,
    ""active"": true,
    ""service_url"": ""/v2/services/c64d9933-a1c8-4207-a103-350180f61baa"",
    ""service_instances_url"": ""/v2/service_plans/eba0b51b-a720-47d6-92c2-d3e69c046a56/service_instances""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServicePlanDeprecatedRequest value = new CreateServicePlanDeprecatedRequest();


                var obj = cfClient.ServicePlans.CreateServicePlanDeprecated(value).Result;


                Assert.AreEqual("4b378d7d-8323-4dd1-8b9f-7bb27c82d78e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_plans/eba0b51b-a720-47d6-92c2-d3e69c046a56", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-11T13:20:44Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("100mb", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Free), true);
                Assert.AreEqual("Let's you put data in your database!", TestUtil.ToTestableString(obj.Description), true);
                Assert.AreEqual("4b378d7d-8323-4dd1-8b9f-7bb27c82d78e", TestUtil.ToTestableString(obj.ServiceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
                Assert.AreEqual("3f4b53ab-851a-48de-bf4b-3673931800e2", TestUtil.ToTestableString(obj.UniqueId), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Public), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
                Assert.AreEqual("/v2/services/c64d9933-a1c8-4207-a103-350180f61baa", TestUtil.ToTestableString(obj.ServiceUrl), true);
                Assert.AreEqual("/v2/service_plans/eba0b51b-a720-47d6-92c2-d3e69c046a56/service_instances", TestUtil.ToTestableString(obj.ServiceInstancesUrl), true);

            }
        }

    }
}