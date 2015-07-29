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
    public class RoutesTest
    {


        [TestMethod]
        public void TestCreateRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""3baae875-79ad-4169-9970-c2f291c1e3d3"",
    ""url"": ""/v2/routes/3baae875-79ad-4169-9970-c2f291c1e3d3"",
    ""created_at"": ""2015-07-29T12:47:30Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": """",
    ""domain_guid"": ""d24761f9-a1fb-4c50-bfdd-c7539c47eb9e"",
    ""space_guid"": ""a66ade20-28b8-4cc0-90a5-40451e0f71b8"",
    ""path"": ""/apps/v1/path"",
    ""domain_url"": ""/v2/domains/d24761f9-a1fb-4c50-bfdd-c7539c47eb9e"",
    ""space_url"": ""/v2/spaces/a66ade20-28b8-4cc0-90a5-40451e0f71b8"",
    ""apps_url"": ""/v2/routes/3baae875-79ad-4169-9970-c2f291c1e3d3/apps""
  }
}";

            CreateRouteResponse obj = Utilities.DeserializeJson<CreateRouteResponse>(json);

            Assert.AreEqual("3baae875-79ad-4169-9970-c2f291c1e3d3", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/3baae875-79ad-4169-9970-c2f291c1e3d3", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:30Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("d24761f9-a1fb-4c50-bfdd-c7539c47eb9e", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("a66ade20-28b8-4cc0-90a5-40451e0f71b8", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("/apps/v1/path", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("/v2/domains/d24761f9-a1fb-4c50-bfdd-c7539c47eb9e", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/a66ade20-28b8-4cc0-90a5-40451e0f71b8", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/3baae875-79ad-4169-9970-c2f291c1e3d3/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
        }

        [TestMethod]
        public void TestListAllRoutesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""d83fd8e2-1f1f-42b3-b057-1b53bf19d561"",
        ""url"": ""/v2/routes/d83fd8e2-1f1f-42b3-b057-1b53bf19d561"",
        ""created_at"": ""2015-07-29T12:47:30Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""host"": ""host-21"",
        ""domain_guid"": ""a32f0ad9-c6fe-4556-b817-cad6e83ec9bf"",
        ""space_guid"": ""0b21a82d-41a1-4e31-a126-62f4b661f631"",
        ""path"": """",
        ""domain_url"": ""/v2/domains/a32f0ad9-c6fe-4556-b817-cad6e83ec9bf"",
        ""space_url"": ""/v2/spaces/0b21a82d-41a1-4e31-a126-62f4b661f631"",
        ""apps_url"": ""/v2/routes/d83fd8e2-1f1f-42b3-b057-1b53bf19d561/apps""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllRoutesResponse> page = Utilities.DeserializePage<ListAllRoutesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("d83fd8e2-1f1f-42b3-b057-1b53bf19d561", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/d83fd8e2-1f1f-42b3-b057-1b53bf19d561", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:30Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-21", TestUtil.ToTestableString(page[0].Host), true);
            Assert.AreEqual("a32f0ad9-c6fe-4556-b817-cad6e83ec9bf", TestUtil.ToTestableString(page[0].DomainGuid), true);
            Assert.AreEqual("0b21a82d-41a1-4e31-a126-62f4b661f631", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Path), true);
            Assert.AreEqual("/v2/domains/a32f0ad9-c6fe-4556-b817-cad6e83ec9bf", TestUtil.ToTestableString(page[0].DomainUrl), true);
            Assert.AreEqual("/v2/spaces/0b21a82d-41a1-4e31-a126-62f4b661f631", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/routes/d83fd8e2-1f1f-42b3-b057-1b53bf19d561/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
        }

        [TestMethod]
        public void TestAssociateAppWithRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""e3df1b0a-804e-4474-ace7-45dcfbe1a4da"",
    ""url"": ""/v2/routes/e3df1b0a-804e-4474-ace7-45dcfbe1a4da"",
    ""created_at"": ""2015-07-29T12:47:29Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-19"",
    ""domain_guid"": ""98054ce1-46ac-45eb-9da2-927aa5f1d1e6"",
    ""space_guid"": ""fb7b0547-1af8-4679-8442-9f121120b2ab"",
    ""path"": """",
    ""domain_url"": ""/v2/domains/98054ce1-46ac-45eb-9da2-927aa5f1d1e6"",
    ""space_url"": ""/v2/spaces/fb7b0547-1af8-4679-8442-9f121120b2ab"",
    ""apps_url"": ""/v2/routes/e3df1b0a-804e-4474-ace7-45dcfbe1a4da/apps""
  }
}";

            AssociateAppWithRouteResponse obj = Utilities.DeserializeJson<AssociateAppWithRouteResponse>(json);

            Assert.AreEqual("e3df1b0a-804e-4474-ace7-45dcfbe1a4da", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/e3df1b0a-804e-4474-ace7-45dcfbe1a4da", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:29Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-19", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("98054ce1-46ac-45eb-9da2-927aa5f1d1e6", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("fb7b0547-1af8-4679-8442-9f121120b2ab", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("/v2/domains/98054ce1-46ac-45eb-9da2-927aa5f1d1e6", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/fb7b0547-1af8-4679-8442-9f121120b2ab", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/e3df1b0a-804e-4474-ace7-45dcfbe1a4da/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
        }

        [TestMethod]
        public void TestListAllAppsForRouteResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""ddefad7e-a968-4843-8092-0486daa771dc"",
        ""url"": ""/v2/apps/ddefad7e-a968-4843-8092-0486daa771dc"",
        ""created_at"": ""2015-07-29T12:47:30Z"",
        ""updated_at"": ""2015-07-29T12:47:30Z""
      },
      ""entity"": {
        ""name"": ""name-2165"",
        ""production"": false,
        ""space_guid"": ""950f38f5-afe3-4e52-8c8c-c1c7a128a76e"",
        ""stack_guid"": ""0c4fb9a7-75a8-4141-8330-e43fe46208a9"",
        ""buildpack"": null,
        ""detected_buildpack"": null,
        ""environment_json"": null,
        ""memory"": 1024,
        ""instances"": 1,
        ""disk_quota"": 1024,
        ""state"": ""STOPPED"",
        ""version"": ""b3b06835-e2c4-419b-b899-3e14c0198186"",
        ""command"": null,
        ""console"": false,
        ""debug"": null,
        ""staging_task_id"": null,
        ""package_state"": ""PENDING"",
        ""health_check_type"": ""port"",
        ""health_check_timeout"": null,
        ""staging_failed_reason"": null,
        ""diego"": false,
        ""docker_image"": null,
        ""package_updated_at"": ""2015-07-29T12:47:30Z"",
        ""detected_start_command"": """",
        ""enable_ssh"": true,
        ""space_url"": ""/v2/spaces/950f38f5-afe3-4e52-8c8c-c1c7a128a76e"",
        ""stack_url"": ""/v2/stacks/0c4fb9a7-75a8-4141-8330-e43fe46208a9"",
        ""events_url"": ""/v2/apps/ddefad7e-a968-4843-8092-0486daa771dc/events"",
        ""service_bindings_url"": ""/v2/apps/ddefad7e-a968-4843-8092-0486daa771dc/service_bindings"",
        ""routes_url"": ""/v2/apps/ddefad7e-a968-4843-8092-0486daa771dc/routes""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllAppsForRouteResponse> page = Utilities.DeserializePage<ListAllAppsForRouteResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("ddefad7e-a968-4843-8092-0486daa771dc", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/apps/ddefad7e-a968-4843-8092-0486daa771dc", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:30Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-07-29T12:47:30Z", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2165", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Production), true);
            Assert.AreEqual("950f38f5-afe3-4e52-8c8c-c1c7a128a76e", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("0c4fb9a7-75a8-4141-8330-e43fe46208a9", TestUtil.ToTestableString(page[0].StackGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Buildpack), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DetectedBuildpack), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EnvironmentJson), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(page[0].Memory), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page[0].Instances), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(page[0].DiskQuota), true);
            Assert.AreEqual("STOPPED", TestUtil.ToTestableString(page[0].State), true);
            Assert.AreEqual("b3b06835-e2c4-419b-b899-3e14c0198186", TestUtil.ToTestableString(page[0].Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Command), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Console), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Debug), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].StagingTaskId), true);
            Assert.AreEqual("PENDING", TestUtil.ToTestableString(page[0].PackageState), true);
            Assert.AreEqual("port", TestUtil.ToTestableString(page[0].HealthCheckType), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].HealthCheckTimeout), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].StagingFailedReason), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Diego), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DockerImage), true);
            Assert.AreEqual("2015-07-29T12:47:30Z", TestUtil.ToTestableString(page[0].PackageUpdatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DetectedStartCommand), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].EnableSsh), true);
            Assert.AreEqual("/v2/spaces/950f38f5-afe3-4e52-8c8c-c1c7a128a76e", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/stacks/0c4fb9a7-75a8-4141-8330-e43fe46208a9", TestUtil.ToTestableString(page[0].StackUrl), true);
            Assert.AreEqual("/v2/apps/ddefad7e-a968-4843-8092-0486daa771dc/events", TestUtil.ToTestableString(page[0].EventsUrl), true);
            Assert.AreEqual("/v2/apps/ddefad7e-a968-4843-8092-0486daa771dc/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/apps/ddefad7e-a968-4843-8092-0486daa771dc/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
        }

        [TestMethod]
        public void TestRemoveAppFromRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""d231e310-0d60-48ed-8b1c-7c00890760db"",
    ""url"": ""/v2/routes/d231e310-0d60-48ed-8b1c-7c00890760db"",
    ""created_at"": ""2015-07-29T12:47:29Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-18"",
    ""domain_guid"": ""bb7c42c1-f69f-4db6-8966-ef63e8d901b7"",
    ""space_guid"": ""80895e03-451d-46ee-9c18-de4e223889a2"",
    ""path"": """",
    ""domain_url"": ""/v2/domains/bb7c42c1-f69f-4db6-8966-ef63e8d901b7"",
    ""space_url"": ""/v2/spaces/80895e03-451d-46ee-9c18-de4e223889a2"",
    ""apps_url"": ""/v2/routes/d231e310-0d60-48ed-8b1c-7c00890760db/apps""
  }
}";

            RemoveAppFromRouteResponse obj = Utilities.DeserializeJson<RemoveAppFromRouteResponse>(json);

            Assert.AreEqual("d231e310-0d60-48ed-8b1c-7c00890760db", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/d231e310-0d60-48ed-8b1c-7c00890760db", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:29Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-18", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("bb7c42c1-f69f-4db6-8966-ef63e8d901b7", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("80895e03-451d-46ee-9c18-de4e223889a2", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("/v2/domains/bb7c42c1-f69f-4db6-8966-ef63e8d901b7", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/80895e03-451d-46ee-9c18-de4e223889a2", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/d231e310-0d60-48ed-8b1c-7c00890760db/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
        }

        [TestMethod]
        public void TestRetrieveRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""66f735d3-32e1-407f-af2f-6cd53790d5df"",
    ""url"": ""/v2/routes/66f735d3-32e1-407f-af2f-6cd53790d5df"",
    ""created_at"": ""2015-07-29T12:47:30Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-24"",
    ""domain_guid"": ""21626f44-98f6-44e5-82f1-8894233a91a3"",
    ""space_guid"": ""7ee4fcf7-9971-469e-98c8-0e718d54e8f7"",
    ""path"": """",
    ""domain_url"": ""/v2/domains/21626f44-98f6-44e5-82f1-8894233a91a3"",
    ""space_url"": ""/v2/spaces/7ee4fcf7-9971-469e-98c8-0e718d54e8f7"",
    ""apps_url"": ""/v2/routes/66f735d3-32e1-407f-af2f-6cd53790d5df/apps""
  }
}";

            RetrieveRouteResponse obj = Utilities.DeserializeJson<RetrieveRouteResponse>(json);

            Assert.AreEqual("66f735d3-32e1-407f-af2f-6cd53790d5df", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/66f735d3-32e1-407f-af2f-6cd53790d5df", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:30Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-24", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("21626f44-98f6-44e5-82f1-8894233a91a3", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("7ee4fcf7-9971-469e-98c8-0e718d54e8f7", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("/v2/domains/21626f44-98f6-44e5-82f1-8894233a91a3", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/7ee4fcf7-9971-469e-98c8-0e718d54e8f7", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/66f735d3-32e1-407f-af2f-6cd53790d5df/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
        }

        [TestMethod]
        public void TestUpdateRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""86e666c2-b84a-4e51-8440-e0ca6eb6d07d"",
    ""url"": ""/v2/routes/86e666c2-b84a-4e51-8440-e0ca6eb6d07d"",
    ""created_at"": ""2015-07-29T12:47:30Z"",
    ""updated_at"": ""2015-07-29T12:47:30Z""
  },
  ""entity"": {
    ""host"": ""new_host"",
    ""domain_guid"": ""ce4398f1-ed4e-4ab8-a80c-8c7b5af4f68d"",
    ""space_guid"": ""819c6ca0-c706-49b2-a2df-edac66ae2f95"",
    ""path"": ""/apps/v1/path"",
    ""domain_url"": ""/v2/domains/ce4398f1-ed4e-4ab8-a80c-8c7b5af4f68d"",
    ""space_url"": ""/v2/spaces/819c6ca0-c706-49b2-a2df-edac66ae2f95"",
    ""apps_url"": ""/v2/routes/86e666c2-b84a-4e51-8440-e0ca6eb6d07d/apps""
  }
}";

            UpdateRouteResponse obj = Utilities.DeserializeJson<UpdateRouteResponse>(json);

            Assert.AreEqual("86e666c2-b84a-4e51-8440-e0ca6eb6d07d", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/86e666c2-b84a-4e51-8440-e0ca6eb6d07d", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:30Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-07-29T12:47:30Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("new_host", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("ce4398f1-ed4e-4ab8-a80c-8c7b5af4f68d", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("819c6ca0-c706-49b2-a2df-edac66ae2f95", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("/apps/v1/path", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("/v2/domains/ce4398f1-ed4e-4ab8-a80c-8c7b5af4f68d", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/819c6ca0-c706-49b2-a2df-edac66ae2f95", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/86e666c2-b84a-4e51-8440-e0ca6eb6d07d/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
        }
    }
}
