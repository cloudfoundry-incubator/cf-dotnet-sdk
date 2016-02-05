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
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V2.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ServiceInstancesTest
    {


        [TestMethod]
        public void TestListAllServiceBindingsForServiceInstanceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""cbdadad6-133d-4d55-9023-39f6a34c1e1f"",
        ""url"": ""/v2/service_bindings/cbdadad6-133d-4d55-9023-39f6a34c1e1f"",
        ""created_at"": ""2016-02-05T12:14:46Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""b4666f0b-4248-4be3-b438-e9fb26fa03bb"",
        ""service_instance_guid"": ""ee487e07-f414-4790-ba8d-a1c55f147e1e"",
        ""credentials"": {
          ""creds-key-380"": ""creds-val-380""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/b4666f0b-4248-4be3-b438-e9fb26fa03bb"",
        ""service_instance_url"": ""/v2/service_instances/ee487e07-f414-4790-ba8d-a1c55f147e1e""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBindingsForServiceInstanceResponse> page = Utilities.DeserializePage<ListAllServiceBindingsForServiceInstanceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("cbdadad6-133d-4d55-9023-39f6a34c1e1f", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/cbdadad6-133d-4d55-9023-39f6a34c1e1f", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:46Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("b4666f0b-4248-4be3-b438-e9fb26fa03bb", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("ee487e07-f414-4790-ba8d-a1c55f147e1e", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/b4666f0b-4248-4be3-b438-e9fb26fa03bb", TestUtil.ToTestableString(page[0].AppUrl), true);
            Assert.AreEqual("/v2/service_instances/ee487e07-f414-4790-ba8d-a1c55f147e1e", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestMigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalResponse()
        {
            string json = @"{""changed_count"":1}";

            MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalResponse obj = Utilities.DeserializeJson<MigrateServiceInstancesFromOneServicePlanToAnotherServicePlanExperimentalResponse>(json);

            Assert.AreEqual("1", TestUtil.ToTestableString(obj.ChangedCount), true);
        }

        [TestMethod]
        public void TestRetrievingPermissionsOnServiceInstanceResponse()
        {
            string json = @"{""manage"":true}";

            RetrievingPermissionsOnServiceInstanceResponse obj = Utilities.DeserializeJson<RetrievingPermissionsOnServiceInstanceResponse>(json);

            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Manage), true);
        }

        [TestMethod]
        public void TestUpdateServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""08b91800-1d4e-4bc8-8183-ace0c718cab0"",
    ""url"": ""/v2/service_instances/08b91800-1d4e-4bc8-8183-ace0c718cab0"",
    ""created_at"": ""2016-02-05T12:14:46Z"",
    ""updated_at"": ""2016-02-05T12:14:46Z""
  },
  ""entity"": {
    ""name"": ""name-1588"",
    ""credentials"": {
      ""creds-key-376"": ""creds-val-376""
    },
    ""service_plan_guid"": ""d5dbb4d9-645c-4e4f-abb3-c8b90cc5e303"",
    ""space_guid"": ""563a4704-e871-49b4-a03b-c8f8b86b05a4"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""update"",
      ""state"": ""in progress"",
      ""description"": """",
      ""updated_at"": ""2016-02-05T12:14:46Z"",
      ""created_at"": ""2016-02-05T12:14:46Z""
    },
    ""space_url"": ""/v2/spaces/563a4704-e871-49b4-a03b-c8f8b86b05a4"",
    ""service_plan_url"": ""/v2/service_plans/d5dbb4d9-645c-4e4f-abb3-c8b90cc5e303"",
    ""service_bindings_url"": ""/v2/service_instances/08b91800-1d4e-4bc8-8183-ace0c718cab0/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/08b91800-1d4e-4bc8-8183-ace0c718cab0/service_keys""
  }
}";

            UpdateServiceInstanceResponse obj = Utilities.DeserializeJson<UpdateServiceInstanceResponse>(json);

            Assert.AreEqual("08b91800-1d4e-4bc8-8183-ace0c718cab0", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/08b91800-1d4e-4bc8-8183-ace0c718cab0", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:46Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-05T12:14:46Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1588", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("d5dbb4d9-645c-4e4f-abb3-c8b90cc5e303", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("563a4704-e871-49b4-a03b-c8f8b86b05a4", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/563a4704-e871-49b4-a03b-c8f8b86b05a4", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/d5dbb4d9-645c-4e4f-abb3-c8b90cc5e303", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/08b91800-1d4e-4bc8-8183-ace0c718cab0/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/08b91800-1d4e-4bc8-8183-ace0c718cab0/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceInstancesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""07a56b94-6dbf-4495-82d1-4b5fa99c897d"",
        ""url"": ""/v2/service_instances/07a56b94-6dbf-4495-82d1-4b5fa99c897d"",
        ""created_at"": ""2016-02-05T12:14:46Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1576"",
        ""credentials"": {
          ""creds-key-370"": ""creds-val-370""
        },
        ""service_plan_guid"": ""c8c8dc88-c795-4aa9-be68-a4dec8677c72"",
        ""space_guid"": ""b75b1f01-1c65-4051-9aa3-2e3267017a0b"",
        ""gateway_data"": null,
        ""dashboard_url"": null,
        ""type"": ""managed_service_instance"",
        ""last_operation"": {
          ""type"": ""create"",
          ""state"": ""succeeded"",
          ""description"": ""service broker-provided description"",
          ""updated_at"": ""2016-02-05T12:14:46Z"",
          ""created_at"": ""2016-02-05T12:14:46Z""
        },
        ""space_url"": ""/v2/spaces/b75b1f01-1c65-4051-9aa3-2e3267017a0b"",
        ""service_plan_url"": ""/v2/service_plans/c8c8dc88-c795-4aa9-be68-a4dec8677c72"",
        ""service_bindings_url"": ""/v2/service_instances/07a56b94-6dbf-4495-82d1-4b5fa99c897d/service_bindings"",
        ""service_keys_url"": ""/v2/service_instances/07a56b94-6dbf-4495-82d1-4b5fa99c897d/service_keys""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceInstancesResponse> page = Utilities.DeserializePage<ListAllServiceInstancesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("07a56b94-6dbf-4495-82d1-4b5fa99c897d", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/07a56b94-6dbf-4495-82d1-4b5fa99c897d", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:46Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1576", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("c8c8dc88-c795-4aa9-be68-a4dec8677c72", TestUtil.ToTestableString(page[0].ServicePlanGuid), true);
            Assert.AreEqual("b75b1f01-1c65-4051-9aa3-2e3267017a0b", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(page[0].Type), true);
            Assert.AreEqual("/v2/spaces/b75b1f01-1c65-4051-9aa3-2e3267017a0b", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/c8c8dc88-c795-4aa9-be68-a4dec8677c72", TestUtil.ToTestableString(page[0].ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/07a56b94-6dbf-4495-82d1-4b5fa99c897d/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/07a56b94-6dbf-4495-82d1-4b5fa99c897d/service_keys", TestUtil.ToTestableString(page[0].ServiceKeysUrl), true);
        }

        [TestMethod]
        public void TestDeleteServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""64732520-958b-4032-8200-d835c1345d0f"",
    ""url"": ""/v2/service_instances/64732520-958b-4032-8200-d835c1345d0f"",
    ""created_at"": ""2016-02-05T12:14:46Z"",
    ""updated_at"": ""2016-02-05T12:14:46Z""
  },
  ""entity"": {
    ""name"": ""name-1561"",
    ""credentials"": {
      ""creds-key-364"": ""creds-val-364""
    },
    ""service_plan_guid"": ""0be7344e-a4c6-49d3-bc16-d9e656a6e507"",
    ""space_guid"": ""5aadfb3f-5e9c-41de-9f8f-28d5e4194902"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""delete"",
      ""state"": ""in progress"",
      ""description"": """",
      ""updated_at"": ""2016-02-05T12:14:46Z"",
      ""created_at"": ""2016-02-05T12:14:46Z""
    },
    ""space_url"": ""/v2/spaces/5aadfb3f-5e9c-41de-9f8f-28d5e4194902"",
    ""service_plan_url"": ""/v2/service_plans/0be7344e-a4c6-49d3-bc16-d9e656a6e507"",
    ""service_bindings_url"": ""/v2/service_instances/64732520-958b-4032-8200-d835c1345d0f/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/64732520-958b-4032-8200-d835c1345d0f/service_keys""
  }
}";

            DeleteServiceInstanceResponse obj = Utilities.DeserializeJson<DeleteServiceInstanceResponse>(json);

            Assert.AreEqual("64732520-958b-4032-8200-d835c1345d0f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/64732520-958b-4032-8200-d835c1345d0f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:46Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-05T12:14:46Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1561", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("0be7344e-a4c6-49d3-bc16-d9e656a6e507", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("5aadfb3f-5e9c-41de-9f8f-28d5e4194902", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/5aadfb3f-5e9c-41de-9f8f-28d5e4194902", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/0be7344e-a4c6-49d3-bc16-d9e656a6e507", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/64732520-958b-4032-8200-d835c1345d0f/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/64732520-958b-4032-8200-d835c1345d0f/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
        }

        [TestMethod]
        public void TestRetrieveServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""fde21b5e-c276-41ea-84e6-c3e0d067a296"",
    ""url"": ""/v2/service_instances/fde21b5e-c276-41ea-84e6-c3e0d067a296"",
    ""created_at"": ""2016-02-05T12:14:46Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1582"",
    ""credentials"": {
      ""creds-key-373"": ""creds-val-373""
    },
    ""service_plan_guid"": ""2f9b61be-c21d-4521-a8fc-03dd4cfebb34"",
    ""space_guid"": ""31ed535d-d37b-4e93-9bf3-3ae7bf3ac1c9"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""create"",
      ""state"": ""succeeded"",
      ""description"": ""service broker-provided description"",
      ""updated_at"": ""2016-02-05T12:14:46Z"",
      ""created_at"": ""2016-02-05T12:14:46Z""
    },
    ""space_url"": ""/v2/spaces/31ed535d-d37b-4e93-9bf3-3ae7bf3ac1c9"",
    ""service_plan_url"": ""/v2/service_plans/2f9b61be-c21d-4521-a8fc-03dd4cfebb34"",
    ""service_bindings_url"": ""/v2/service_instances/fde21b5e-c276-41ea-84e6-c3e0d067a296/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/fde21b5e-c276-41ea-84e6-c3e0d067a296/service_keys""
  }
}";

            RetrieveServiceInstanceResponse obj = Utilities.DeserializeJson<RetrieveServiceInstanceResponse>(json);

            Assert.AreEqual("fde21b5e-c276-41ea-84e6-c3e0d067a296", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/fde21b5e-c276-41ea-84e6-c3e0d067a296", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:46Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1582", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("2f9b61be-c21d-4521-a8fc-03dd4cfebb34", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("31ed535d-d37b-4e93-9bf3-3ae7bf3ac1c9", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/31ed535d-d37b-4e93-9bf3-3ae7bf3ac1c9", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/2f9b61be-c21d-4521-a8fc-03dd4cfebb34", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/fde21b5e-c276-41ea-84e6-c3e0d067a296/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/fde21b5e-c276-41ea-84e6-c3e0d067a296/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
        }

        [TestMethod]
        public void TestCreateServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""f2af514c-1205-4e47-86df-cf18971104f4"",
    ""url"": ""/v2/service_instances/f2af514c-1205-4e47-86df-cf18971104f4"",
    ""created_at"": ""2016-02-05T12:14:46Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-service-instance"",
    ""credentials"": {

    },
    ""service_plan_guid"": ""deb2208f-8f94-41c3-9da9-7849646975cd"",
    ""space_guid"": ""49081462-b259-464c-9a45-561addb5f71c"",
    ""gateway_data"": null,
    ""dashboard_url"": null,
    ""type"": ""managed_service_instance"",
    ""last_operation"": {
      ""type"": ""create"",
      ""state"": ""in progress"",
      ""description"": """",
      ""updated_at"": ""2016-02-05T12:14:46Z"",
      ""created_at"": ""2016-02-05T12:14:46Z""
    },
    ""space_url"": ""/v2/spaces/49081462-b259-464c-9a45-561addb5f71c"",
    ""service_plan_url"": ""/v2/service_plans/deb2208f-8f94-41c3-9da9-7849646975cd"",
    ""service_bindings_url"": ""/v2/service_instances/f2af514c-1205-4e47-86df-cf18971104f4/service_bindings"",
    ""service_keys_url"": ""/v2/service_instances/f2af514c-1205-4e47-86df-cf18971104f4/service_keys""
  }
}";

            CreateServiceInstanceResponse obj = Utilities.DeserializeJson<CreateServiceInstanceResponse>(json);

            Assert.AreEqual("f2af514c-1205-4e47-86df-cf18971104f4", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_instances/f2af514c-1205-4e47-86df-cf18971104f4", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:46Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my-service-instance", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("deb2208f-8f94-41c3-9da9-7849646975cd", TestUtil.ToTestableString(obj.ServicePlanGuid), true);
            Assert.AreEqual("49081462-b259-464c-9a45-561addb5f71c", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DashboardUrl), true);
            Assert.AreEqual("managed_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("/v2/spaces/49081462-b259-464c-9a45-561addb5f71c", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_plans/deb2208f-8f94-41c3-9da9-7849646975cd", TestUtil.ToTestableString(obj.ServicePlanUrl), true);
            Assert.AreEqual("/v2/service_instances/f2af514c-1205-4e47-86df-cf18971104f4/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/service_instances/f2af514c-1205-4e47-86df-cf18971104f4/service_keys", TestUtil.ToTestableString(obj.ServiceKeysUrl), true);
        }
    }
}
