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
    public class SpaceQuotaDefinitionsTest
    {


        [TestMethod]
        public void TestCreateSpaceQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""28ea78e6-ce1e-4cf6-9f2d-8c540e552ea5"",
    ""url"": ""/v2/space_quota_definitions/9467648d-aee9-41e0-abff-6489a4aca69f"",
    ""created_at"": ""2016-05-05T14:14:59Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""gold_quota"",
    ""organization_guid"": ""28ea78e6-ce1e-4cf6-9f2d-8c540e552ea5"",
    ""non_basic_services_allowed"": true,
    ""total_services"": -1,
    ""total_routes"": 10,
    ""memory_limit"": 5120,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": 5,
    ""total_service_keys"": -1,
    ""total_reserved_route_ports"": 5,
    ""organization_url"": ""/v2/organizations/fc6439aa-9a45-413f-9e91-230a21f816d9"",
    ""spaces_url"": ""/v2/space_quota_definitions/9467648d-aee9-41e0-abff-6489a4aca69f/spaces""
  }
}";

            CreateSpaceQuotaDefinitionResponse obj = Utilities.DeserializeJson<CreateSpaceQuotaDefinitionResponse>(json);

            Assert.AreEqual("28ea78e6-ce1e-4cf6-9f2d-8c540e552ea5", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/space_quota_definitions/9467648d-aee9-41e0-abff-6489a4aca69f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:14:59Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("gold_quota", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("28ea78e6-ce1e-4cf6-9f2d-8c540e552ea5", TestUtil.ToTestableString(obj.OrganizationGuid), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("10", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("5120", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
            Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalServiceKeys), true);
            Assert.AreEqual("5", TestUtil.ToTestableString(obj.TotalReservedRoutePorts), true);
            Assert.AreEqual("/v2/organizations/fc6439aa-9a45-413f-9e91-230a21f816d9", TestUtil.ToTestableString(obj.OrganizationUrl), true);
            Assert.AreEqual("/v2/space_quota_definitions/9467648d-aee9-41e0-abff-6489a4aca69f/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestListAllSpacesForSpaceQuotaDefinitionResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""fb66689e-bc89-4953-9e3a-8f088fb5db3f"",
        ""url"": ""/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2"",
        ""created_at"": ""2016-05-05T14:14:59Z"",
        ""updated_at"": ""2016-05-05T14:14:59Z""
      },
      ""entity"": {
        ""name"": ""name-1386"",
        ""organization_guid"": ""fb66689e-bc89-4953-9e3a-8f088fb5db3f"",
        ""space_quota_definition_guid"": ""fb66689e-bc89-4953-9e3a-8f088fb5db3f"",
        ""allow_ssh"": true,
        ""organization_url"": ""/v2/organizations/5c969734-e420-413e-ba12-d642300f1638"",
        ""space_quota_definition_url"": ""/v2/space_quota_definitions/f6cda900-3b53-4703-b0e8-b7a500a441b0"",
        ""developers_url"": ""/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/developers"",
        ""managers_url"": ""/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/managers"",
        ""auditors_url"": ""/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/auditors"",
        ""apps_url"": ""/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/apps"",
        ""routes_url"": ""/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/routes"",
        ""domains_url"": ""/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/domains"",
        ""service_instances_url"": ""/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/service_instances"",
        ""app_events_url"": ""/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/app_events"",
        ""events_url"": ""/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/events"",
        ""security_groups_url"": ""/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/security_groups""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSpacesForSpaceQuotaDefinitionResponse> page = Utilities.DeserializePage<ListAllSpacesForSpaceQuotaDefinitionResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("fb66689e-bc89-4953-9e3a-8f088fb5db3f", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:14:59Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-05-05T14:14:59Z", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1386", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("fb66689e-bc89-4953-9e3a-8f088fb5db3f", TestUtil.ToTestableString(page[0].OrganizationGuid), true);
            Assert.AreEqual("fb66689e-bc89-4953-9e3a-8f088fb5db3f", TestUtil.ToTestableString(page[0].SpaceQuotaDefinitionGuid), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].AllowSsh), true);
            Assert.AreEqual("/v2/organizations/5c969734-e420-413e-ba12-d642300f1638", TestUtil.ToTestableString(page[0].OrganizationUrl), true);
            Assert.AreEqual("/v2/space_quota_definitions/f6cda900-3b53-4703-b0e8-b7a500a441b0", TestUtil.ToTestableString(page[0].SpaceQuotaDefinitionUrl), true);
            Assert.AreEqual("/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/developers", TestUtil.ToTestableString(page[0].DevelopersUrl), true);
            Assert.AreEqual("/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/managers", TestUtil.ToTestableString(page[0].ManagersUrl), true);
            Assert.AreEqual("/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/auditors", TestUtil.ToTestableString(page[0].AuditorsUrl), true);
            Assert.AreEqual("/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
            Assert.AreEqual("/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
            Assert.AreEqual("/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/domains", TestUtil.ToTestableString(page[0].DomainsUrl), true);
            Assert.AreEqual("/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
            Assert.AreEqual("/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/app_events", TestUtil.ToTestableString(page[0].AppEventsUrl), true);
            Assert.AreEqual("/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/events", TestUtil.ToTestableString(page[0].EventsUrl), true);
            Assert.AreEqual("/v2/spaces/bb4e9dc7-87bd-49c1-aa42-d4c837b3d6c2/security_groups", TestUtil.ToTestableString(page[0].SecurityGroupsUrl), true);
        }

        [TestMethod]
        public void TestRetrieveSpaceQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""cab4a453-bcfa-4bcb-9a56-630ada2e2f46"",
    ""url"": ""/v2/space_quota_definitions/fcf8706d-070e-48e7-ba09-0c4181f9e106"",
    ""created_at"": ""2016-05-05T14:14:59Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1393"",
    ""organization_guid"": ""cab4a453-bcfa-4bcb-9a56-630ada2e2f46"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": 5,
    ""total_service_keys"": 600,
    ""total_reserved_route_ports"": -1,
    ""organization_url"": ""/v2/organizations/41db7b6d-8eb2-410b-b8e9-5135398d11eb"",
    ""spaces_url"": ""/v2/space_quota_definitions/fcf8706d-070e-48e7-ba09-0c4181f9e106/spaces""
  }
}";

            RetrieveSpaceQuotaDefinitionResponse obj = Utilities.DeserializeJson<RetrieveSpaceQuotaDefinitionResponse>(json);

            Assert.AreEqual("cab4a453-bcfa-4bcb-9a56-630ada2e2f46", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/space_quota_definitions/fcf8706d-070e-48e7-ba09-0c4181f9e106", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:14:59Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1393", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("cab4a453-bcfa-4bcb-9a56-630ada2e2f46", TestUtil.ToTestableString(obj.OrganizationGuid), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
            Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
            Assert.AreEqual("600", TestUtil.ToTestableString(obj.TotalServiceKeys), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalReservedRoutePorts), true);
            Assert.AreEqual("/v2/organizations/41db7b6d-8eb2-410b-b8e9-5135398d11eb", TestUtil.ToTestableString(obj.OrganizationUrl), true);
            Assert.AreEqual("/v2/space_quota_definitions/fcf8706d-070e-48e7-ba09-0c4181f9e106/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestUpdateSpaceQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""33273f64-35a3-4877-9f8d-940b57e08e09"",
    ""url"": ""/v2/space_quota_definitions/0a09443c-1440-4456-9f70-8a1f977e1d85"",
    ""created_at"": ""2016-05-05T14:14:59Z"",
    ""updated_at"": ""2016-05-05T14:14:59Z""
  },
  ""entity"": {
    ""name"": ""new_name"",
    ""organization_guid"": ""33273f64-35a3-4877-9f8d-940b57e08e09"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": 5,
    ""total_service_keys"": 600,
    ""total_reserved_route_ports"": -1,
    ""organization_url"": ""/v2/organizations/4e3be798-414e-4727-bc85-32b91de8e859"",
    ""spaces_url"": ""/v2/space_quota_definitions/0a09443c-1440-4456-9f70-8a1f977e1d85/spaces""
  }
}";

            UpdateSpaceQuotaDefinitionResponse obj = Utilities.DeserializeJson<UpdateSpaceQuotaDefinitionResponse>(json);

            Assert.AreEqual("33273f64-35a3-4877-9f8d-940b57e08e09", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/space_quota_definitions/0a09443c-1440-4456-9f70-8a1f977e1d85", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:14:59Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-05-05T14:14:59Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("new_name", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("33273f64-35a3-4877-9f8d-940b57e08e09", TestUtil.ToTestableString(obj.OrganizationGuid), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
            Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
            Assert.AreEqual("600", TestUtil.ToTestableString(obj.TotalServiceKeys), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalReservedRoutePorts), true);
            Assert.AreEqual("/v2/organizations/4e3be798-414e-4727-bc85-32b91de8e859", TestUtil.ToTestableString(obj.OrganizationUrl), true);
            Assert.AreEqual("/v2/space_quota_definitions/0a09443c-1440-4456-9f70-8a1f977e1d85/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }

        [TestMethod]
        public void TestListAllSpaceQuotaDefinitionsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""6e31f1d8-d1d7-44b2-892d-09eeb992a5db"",
        ""url"": ""/v2/space_quota_definitions/d4e61921-f7ef-4474-8ab1-16ec76087e75"",
        ""created_at"": ""2016-05-05T14:15:00Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1396"",
        ""organization_guid"": ""6e31f1d8-d1d7-44b2-892d-09eeb992a5db"",
        ""non_basic_services_allowed"": true,
        ""total_services"": 60,
        ""total_routes"": 1000,
        ""memory_limit"": 20480,
        ""instance_memory_limit"": -1,
        ""app_instance_limit"": -1,
        ""app_task_limit"": 5,
        ""total_service_keys"": 600,
        ""total_reserved_route_ports"": -1,
        ""organization_url"": ""/v2/organizations/1a626eef-97c8-46fd-824d-43319788ad5b"",
        ""spaces_url"": ""/v2/space_quota_definitions/d4e61921-f7ef-4474-8ab1-16ec76087e75/spaces""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSpaceQuotaDefinitionsResponse> page = Utilities.DeserializePage<ListAllSpaceQuotaDefinitionsResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("6e31f1d8-d1d7-44b2-892d-09eeb992a5db", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/space_quota_definitions/d4e61921-f7ef-4474-8ab1-16ec76087e75", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:15:00Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1396", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("6e31f1d8-d1d7-44b2-892d-09eeb992a5db", TestUtil.ToTestableString(page[0].OrganizationGuid), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].NonBasicServicesAllowed), true);
            Assert.AreEqual("60", TestUtil.ToTestableString(page[0].TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(page[0].TotalRoutes), true);
            Assert.AreEqual("20480", TestUtil.ToTestableString(page[0].MemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].InstanceMemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].AppInstanceLimit), true);
            Assert.AreEqual("5", TestUtil.ToTestableString(page[0].AppTaskLimit), true);
            Assert.AreEqual("600", TestUtil.ToTestableString(page[0].TotalServiceKeys), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(page[0].TotalReservedRoutePorts), true);
            Assert.AreEqual("/v2/organizations/1a626eef-97c8-46fd-824d-43319788ad5b", TestUtil.ToTestableString(page[0].OrganizationUrl), true);
            Assert.AreEqual("/v2/space_quota_definitions/d4e61921-f7ef-4474-8ab1-16ec76087e75/spaces", TestUtil.ToTestableString(page[0].SpacesUrl), true);
        }

        [TestMethod]
        public void TestAssociateSpaceWithSpaceQuotaDefinitionResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""a3703042-a0ce-4b6a-a1e2-7821261d395f"",
    ""url"": ""/v2/space_quota_definitions/55bba6a4-ce0d-4a49-a684-e7df8da95813"",
    ""created_at"": ""2016-05-05T14:14:59Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1388"",
    ""organization_guid"": ""a3703042-a0ce-4b6a-a1e2-7821261d395f"",
    ""non_basic_services_allowed"": true,
    ""total_services"": 60,
    ""total_routes"": 1000,
    ""memory_limit"": 20480,
    ""instance_memory_limit"": -1,
    ""app_instance_limit"": -1,
    ""app_task_limit"": 5,
    ""total_service_keys"": 600,
    ""total_reserved_route_ports"": -1,
    ""organization_url"": ""/v2/organizations/e0b3b472-7f4b-4cc4-ba38-3dee1c665e25"",
    ""spaces_url"": ""/v2/space_quota_definitions/55bba6a4-ce0d-4a49-a684-e7df8da95813/spaces""
  }
}";

            AssociateSpaceWithSpaceQuotaDefinitionResponse obj = Utilities.DeserializeJson<AssociateSpaceWithSpaceQuotaDefinitionResponse>(json);

            Assert.AreEqual("a3703042-a0ce-4b6a-a1e2-7821261d395f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/space_quota_definitions/55bba6a4-ce0d-4a49-a684-e7df8da95813", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-05-05T14:14:59Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1388", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("a3703042-a0ce-4b6a-a1e2-7821261d395f", TestUtil.ToTestableString(obj.OrganizationGuid), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.NonBasicServicesAllowed), true);
            Assert.AreEqual("60", TestUtil.ToTestableString(obj.TotalServices), true);
            Assert.AreEqual("1000", TestUtil.ToTestableString(obj.TotalRoutes), true);
            Assert.AreEqual("20480", TestUtil.ToTestableString(obj.MemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.InstanceMemoryLimit), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.AppInstanceLimit), true);
            Assert.AreEqual("5", TestUtil.ToTestableString(obj.AppTaskLimit), true);
            Assert.AreEqual("600", TestUtil.ToTestableString(obj.TotalServiceKeys), true);
            Assert.AreEqual("-1", TestUtil.ToTestableString(obj.TotalReservedRoutePorts), true);
            Assert.AreEqual("/v2/organizations/e0b3b472-7f4b-4cc4-ba38-3dee1c665e25", TestUtil.ToTestableString(obj.OrganizationUrl), true);
            Assert.AreEqual("/v2/space_quota_definitions/55bba6a4-ce0d-4a49-a684-e7df8da95813/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);
        }
    }
}
