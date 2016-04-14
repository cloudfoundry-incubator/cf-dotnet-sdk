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
    public class UserProvidedServiceInstancesTest
    {


        [TestMethod]
        public void TestRetrieveUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""64e70c1a-8bf6-4985-9225-9589dc743416"",
    ""url"": ""/v2/user_provided_service_instances/425fc5ac-4818-4bc3-85fd-5442a7a63636"",
    ""created_at"": ""2016-04-11T13:32:36Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-201"",
    ""credentials"": {
      ""creds-key-19"": ""creds-val-19""
    },
    ""space_guid"": ""64e70c1a-8bf6-4985-9225-9589dc743416"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-28"",
    ""route_service_url"": null,
    ""space_url"": ""/v2/spaces/b18506e5-fe93-4305-ae68-596ea8098cf2"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/425fc5ac-4818-4bc3-85fd-5442a7a63636/service_bindings"",
    ""routes_url"": ""/v2/user_provided_service_instances/425fc5ac-4818-4bc3-85fd-5442a7a63636/routes""
  }
}";

            RetrieveUserProvidedServiceInstanceResponse obj = Utilities.DeserializeJson<RetrieveUserProvidedServiceInstanceResponse>(json);

            Assert.AreEqual("64e70c1a-8bf6-4985-9225-9589dc743416", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/425fc5ac-4818-4bc3-85fd-5442a7a63636", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-04-11T13:32:36Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-201", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("64e70c1a-8bf6-4985-9225-9589dc743416", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("https://foo.com/url-28", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.RouteServiceUrl), true);
            Assert.AreEqual("/v2/spaces/b18506e5-fe93-4305-ae68-596ea8098cf2", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/425fc5ac-4818-4bc3-85fd-5442a7a63636/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/425fc5ac-4818-4bc3-85fd-5442a7a63636/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }

        [TestMethod]
        public void TestListAllRoutesForUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""b5ed7406-5a97-426f-b5f3-19ef61cce84b"",
        ""url"": ""/v2/routes/a71e61b5-7d7b-4f7a-a550-ef25f67461b0"",
        ""created_at"": ""2016-04-11T13:32:35Z"",
        ""updated_at"": ""2016-04-11T13:32:35Z""
      },
      ""entity"": {
        ""host"": ""host-8"",
        ""path"": """",
        ""domain_guid"": ""b5ed7406-5a97-426f-b5f3-19ef61cce84b"",
        ""space_guid"": ""b5ed7406-5a97-426f-b5f3-19ef61cce84b"",
        ""service_instance_guid"": ""b5ed7406-5a97-426f-b5f3-19ef61cce84b"",
        ""port"": 0,
        ""domain_url"": ""/v2/domains/dad13069-79d8-4060-ad8f-8f1dd6723eac"",
        ""space_url"": ""/v2/spaces/dc050eb6-54cd-453b-b86b-4d118180a063"",
        ""service_instance_url"": ""/v2/user_provided_service_instances/b0559bfb-92d9-474c-bac3-45331acbd657"",
        ""apps_url"": ""/v2/routes/a71e61b5-7d7b-4f7a-a550-ef25f67461b0/apps"",
        ""route_mappings_url"": ""/v2/routes/a71e61b5-7d7b-4f7a-a550-ef25f67461b0/route_mappings""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllRoutesForUserProvidedServiceInstanceResponse> page = Utilities.DeserializePage<ListAllRoutesForUserProvidedServiceInstanceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("b5ed7406-5a97-426f-b5f3-19ef61cce84b", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/a71e61b5-7d7b-4f7a-a550-ef25f67461b0", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-04-11T13:32:35Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-04-11T13:32:35Z", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-8", TestUtil.ToTestableString(page[0].Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Path), true);
            Assert.AreEqual("b5ed7406-5a97-426f-b5f3-19ef61cce84b", TestUtil.ToTestableString(page[0].DomainGuid), true);
            Assert.AreEqual("b5ed7406-5a97-426f-b5f3-19ef61cce84b", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("b5ed7406-5a97-426f-b5f3-19ef61cce84b", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("0", TestUtil.ToTestableString(page[0].Port), true);
            Assert.AreEqual("/v2/domains/dad13069-79d8-4060-ad8f-8f1dd6723eac", TestUtil.ToTestableString(page[0].DomainUrl), true);
            Assert.AreEqual("/v2/spaces/dc050eb6-54cd-453b-b86b-4d118180a063", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/b0559bfb-92d9-474c-bac3-45331acbd657", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
            Assert.AreEqual("/v2/routes/a71e61b5-7d7b-4f7a-a550-ef25f67461b0/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
            Assert.AreEqual("/v2/routes/a71e61b5-7d7b-4f7a-a550-ef25f67461b0/route_mappings", TestUtil.ToTestableString(page[0].RouteMappingsUrl), true);
        }

        [TestMethod]
        public void TestUpdateUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""83b2fdfd-5657-4338-802a-8bf86b7a1f57"",
    ""url"": ""/v2/user_provided_service_instances/3b3fa01d-d411-4702-a9aa-2a175cc78629"",
    ""created_at"": ""2016-04-11T13:32:36Z"",
    ""updated_at"": ""2016-04-11T13:32:36Z""
  },
  ""entity"": {
    ""name"": ""name-216"",
    ""credentials"": {
      ""somekey"": ""somenewvalue""
    },
    ""space_guid"": ""83b2fdfd-5657-4338-802a-8bf86b7a1f57"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-31"",
    ""route_service_url"": null,
    ""space_url"": ""/v2/spaces/ddc79d18-b47a-4c8c-ad64-6702c090c596"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/3b3fa01d-d411-4702-a9aa-2a175cc78629/service_bindings"",
    ""routes_url"": ""/v2/user_provided_service_instances/3b3fa01d-d411-4702-a9aa-2a175cc78629/routes""
  }
}";

            UpdateUserProvidedServiceInstanceResponse obj = Utilities.DeserializeJson<UpdateUserProvidedServiceInstanceResponse>(json);

            Assert.AreEqual("83b2fdfd-5657-4338-802a-8bf86b7a1f57", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/3b3fa01d-d411-4702-a9aa-2a175cc78629", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-04-11T13:32:36Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-04-11T13:32:36Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-216", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("83b2fdfd-5657-4338-802a-8bf86b7a1f57", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("https://foo.com/url-31", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.RouteServiceUrl), true);
            Assert.AreEqual("/v2/spaces/ddc79d18-b47a-4c8c-ad64-6702c090c596", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/3b3fa01d-d411-4702-a9aa-2a175cc78629/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/3b3fa01d-d411-4702-a9aa-2a175cc78629/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }

        [TestMethod]
        public void TestListAllUserProvidedServiceInstancesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""4f37769b-2f8b-4707-a22e-7c38dd3e1bbe"",
        ""url"": ""/v2/user_provided_service_instances/e5b3cb6b-fda6-49d8-b693-b97a52ab0811"",
        ""created_at"": ""2016-04-11T13:32:36Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-212"",
        ""credentials"": {
          ""creds-key-21"": ""creds-val-21""
        },
        ""space_guid"": ""4f37769b-2f8b-4707-a22e-7c38dd3e1bbe"",
        ""type"": ""user_provided_service_instance"",
        ""syslog_drain_url"": ""https://foo.com/url-30"",
        ""route_service_url"": null,
        ""space_url"": ""/v2/spaces/806ea909-791e-4abf-82e9-e53f4ab520b3"",
        ""service_bindings_url"": ""/v2/user_provided_service_instances/e5b3cb6b-fda6-49d8-b693-b97a52ab0811/service_bindings"",
        ""routes_url"": ""/v2/user_provided_service_instances/e5b3cb6b-fda6-49d8-b693-b97a52ab0811/routes""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllUserProvidedServiceInstancesResponse> page = Utilities.DeserializePage<ListAllUserProvidedServiceInstancesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("4f37769b-2f8b-4707-a22e-7c38dd3e1bbe", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/e5b3cb6b-fda6-49d8-b693-b97a52ab0811", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-04-11T13:32:36Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-212", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("4f37769b-2f8b-4707-a22e-7c38dd3e1bbe", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(page[0].Type), true);
            Assert.AreEqual("https://foo.com/url-30", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].RouteServiceUrl), true);
            Assert.AreEqual("/v2/spaces/806ea909-791e-4abf-82e9-e53f4ab520b3", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/e5b3cb6b-fda6-49d8-b693-b97a52ab0811/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/e5b3cb6b-fda6-49d8-b693-b97a52ab0811/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
        }

        [TestMethod]
        public void TestAssociateRouteWithUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""0bd95563-97c1-4388-8b3e-28951114aff7"",
    ""url"": ""/v2/user_provided_service_instances/109aa824-660f-4b5d-819d-0cd973626810"",
    ""created_at"": ""2016-04-11T13:32:35Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-187"",
    ""credentials"": {
      ""creds-key-15"": ""creds-val-15""
    },
    ""space_guid"": ""0bd95563-97c1-4388-8b3e-28951114aff7"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""https://foo.com/url-24"",
    ""route_service_url"": ""https://foo.com/url-23"",
    ""space_url"": ""/v2/spaces/9a237695-4c22-43fc-91ef-ab6b7b2c9f90"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/109aa824-660f-4b5d-819d-0cd973626810/service_bindings"",
    ""routes_url"": ""/v2/user_provided_service_instances/109aa824-660f-4b5d-819d-0cd973626810/routes""
  }
}";

            AssociateRouteWithUserProvidedServiceInstanceResponse obj = Utilities.DeserializeJson<AssociateRouteWithUserProvidedServiceInstanceResponse>(json);

            Assert.AreEqual("0bd95563-97c1-4388-8b3e-28951114aff7", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/109aa824-660f-4b5d-819d-0cd973626810", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-04-11T13:32:35Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-187", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("0bd95563-97c1-4388-8b3e-28951114aff7", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("https://foo.com/url-24", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("https://foo.com/url-23", TestUtil.ToTestableString(obj.RouteServiceUrl), true);
            Assert.AreEqual("/v2/spaces/9a237695-4c22-43fc-91ef-ab6b7b2c9f90", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/109aa824-660f-4b5d-819d-0cd973626810/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/109aa824-660f-4b5d-819d-0cd973626810/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }

        [TestMethod]
        public void TestListAllServiceBindingsForUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""bd91342b-07d0-4420-be2c-9783a0e7b7b7"",
        ""url"": ""/v2/service_bindings/f0aba59d-fd6f-47f3-9189-9431bea98400"",
        ""created_at"": ""2016-04-11T13:32:35Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_guid"": ""bd91342b-07d0-4420-be2c-9783a0e7b7b7"",
        ""service_instance_guid"": ""bd91342b-07d0-4420-be2c-9783a0e7b7b7"",
        ""credentials"": {
          ""creds-key-17"": ""creds-val-17""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""app_url"": ""/v2/apps/dadd6fd8-b2d3-42c6-a115-7ae6f1345528"",
        ""service_instance_url"": ""/v2/user_provided_service_instances/c83faf79-0d77-48a6-82e0-e53899225b7d""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBindingsForUserProvidedServiceInstanceResponse> page = Utilities.DeserializePage<ListAllServiceBindingsForUserProvidedServiceInstanceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("bd91342b-07d0-4420-be2c-9783a0e7b7b7", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/f0aba59d-fd6f-47f3-9189-9431bea98400", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-04-11T13:32:35Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("bd91342b-07d0-4420-be2c-9783a0e7b7b7", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("bd91342b-07d0-4420-be2c-9783a0e7b7b7", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/dadd6fd8-b2d3-42c6-a115-7ae6f1345528", TestUtil.ToTestableString(page[0].AppUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/c83faf79-0d77-48a6-82e0-e53899225b7d", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestCreateUserProvidedServiceInstanceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""7c6aec61-8d7b-421f-b2f9-69637baf29f8"",
    ""url"": ""/v2/user_provided_service_instances/0c4bed02-1d9d-4ffd-80d0-68356a40fdf0"",
    ""created_at"": ""2016-04-11T13:32:36Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my-user-provided-instance"",
    ""credentials"": {
      ""somekey"": ""somevalue""
    },
    ""space_guid"": ""7c6aec61-8d7b-421f-b2f9-69637baf29f8"",
    ""type"": ""user_provided_service_instance"",
    ""syslog_drain_url"": ""syslog://example.com"",
    ""route_service_url"": ""https://logger.example.com"",
    ""space_url"": ""/v2/spaces/bb638fde-3530-499d-ae52-a09dd3b628a7"",
    ""service_bindings_url"": ""/v2/user_provided_service_instances/0c4bed02-1d9d-4ffd-80d0-68356a40fdf0/service_bindings"",
    ""routes_url"": ""/v2/user_provided_service_instances/0c4bed02-1d9d-4ffd-80d0-68356a40fdf0/routes""
  }
}";

            CreateUserProvidedServiceInstanceResponse obj = Utilities.DeserializeJson<CreateUserProvidedServiceInstanceResponse>(json);

            Assert.AreEqual("7c6aec61-8d7b-421f-b2f9-69637baf29f8", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/user_provided_service_instances/0c4bed02-1d9d-4ffd-80d0-68356a40fdf0", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-04-11T13:32:36Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my-user-provided-instance", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("7c6aec61-8d7b-421f-b2f9-69637baf29f8", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("user_provided_service_instance", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("syslog://example.com", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("https://logger.example.com", TestUtil.ToTestableString(obj.RouteServiceUrl), true);
            Assert.AreEqual("/v2/spaces/bb638fde-3530-499d-ae52-a09dd3b628a7", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/0c4bed02-1d9d-4ffd-80d0-68356a40fdf0/service_bindings", TestUtil.ToTestableString(obj.ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/0c4bed02-1d9d-4ffd-80d0-68356a40fdf0/routes", TestUtil.ToTestableString(obj.RoutesUrl), true);
        }
    }
}
