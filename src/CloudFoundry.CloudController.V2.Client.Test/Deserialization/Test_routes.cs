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
        ""guid"": ""95487913-95f1-424d-be7b-c567ed874799"",
        ""url"": ""/v2/routes/fd275eb9-3271-4704-b01f-8a6be934c8d5"",
        ""created_at"": ""2016-02-11T13:20:36Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""host"": ""host-14"",
        ""path"": """",
        ""domain_guid"": ""95487913-95f1-424d-be7b-c567ed874799"",
        ""space_guid"": ""95487913-95f1-424d-be7b-c567ed874799"",
        ""service_instance_guid"": ""95487913-95f1-424d-be7b-c567ed874799"",
        ""port"": 0,
        ""domain_url"": ""/v2/domains/a6806e8a-66ed-4f88-b478-3242615a0d4f"",
        ""space_url"": ""/v2/spaces/af8c89ec-36df-4a5d-8f48-1184c6f2d1df"",
        ""service_instance_url"": ""/v2/service_instances/7df4a7aa-a31a-4138-825d-812970bf9ca8"",
        ""apps_url"": ""/v2/routes/fd275eb9-3271-4704-b01f-8a6be934c8d5/apps""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllRoutesResponse> page = Utilities.DeserializePage<ListAllRoutesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("95487913-95f1-424d-be7b-c567ed874799", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/fd275eb9-3271-4704-b01f-8a6be934c8d5", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:36Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-14", TestUtil.ToTestableString(page[0].Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Path), true);
            Assert.AreEqual("95487913-95f1-424d-be7b-c567ed874799", TestUtil.ToTestableString(page[0].DomainGuid), true);
            Assert.AreEqual("95487913-95f1-424d-be7b-c567ed874799", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("95487913-95f1-424d-be7b-c567ed874799", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("0", TestUtil.ToTestableString(page[0].Port), true);
            Assert.AreEqual("/v2/domains/a6806e8a-66ed-4f88-b478-3242615a0d4f", TestUtil.ToTestableString(page[0].DomainUrl), true);
            Assert.AreEqual("/v2/spaces/af8c89ec-36df-4a5d-8f48-1184c6f2d1df", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/service_instances/7df4a7aa-a31a-4138-825d-812970bf9ca8", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
            Assert.AreEqual("/v2/routes/fd275eb9-3271-4704-b01f-8a6be934c8d5/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
        }

        [TestMethod]
        public void TestAssociateAppWithRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""2f9fb0cc-b3aa-4cc5-a724-46951ab08895"",
    ""url"": ""/v2/routes/e928ed93-deef-45f0-92b3-5f5505e4ffa3"",
    ""created_at"": ""2016-02-11T13:20:36Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-12"",
    ""path"": """",
    ""domain_guid"": ""2f9fb0cc-b3aa-4cc5-a724-46951ab08895"",
    ""space_guid"": ""2f9fb0cc-b3aa-4cc5-a724-46951ab08895"",
    ""service_instance_guid"": null,
    ""port"": 0,
    ""domain_url"": ""/v2/domains/2779499b-a2ed-4737-a104-5cc2b638e2cf"",
    ""space_url"": ""/v2/spaces/9baed246-5f2f-4c9e-9061-053c76a5b8cd"",
    ""apps_url"": ""/v2/routes/e928ed93-deef-45f0-92b3-5f5505e4ffa3/apps""
  }
}";

            AssociateAppWithRouteResponse obj = Utilities.DeserializeJson<AssociateAppWithRouteResponse>(json);

            Assert.AreEqual("2f9fb0cc-b3aa-4cc5-a724-46951ab08895", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/e928ed93-deef-45f0-92b3-5f5505e4ffa3", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:36Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-12", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("2f9fb0cc-b3aa-4cc5-a724-46951ab08895", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("2f9fb0cc-b3aa-4cc5-a724-46951ab08895", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
            Assert.AreEqual("0", TestUtil.ToTestableString(obj.Port), true);
            Assert.AreEqual("/v2/domains/2779499b-a2ed-4737-a104-5cc2b638e2cf", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/9baed246-5f2f-4c9e-9061-053c76a5b8cd", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/e928ed93-deef-45f0-92b3-5f5505e4ffa3/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
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
        ""guid"": ""90723e8b-cbf3-40be-bb12-891f7e0b873c"",
        ""url"": ""/v2/apps/d81c43bb-cb26-4d6f-873d-bdd07272ea7e"",
        ""created_at"": ""2016-02-11T13:20:36Z"",
        ""updated_at"": ""2016-02-11T13:20:36Z""
      },
      ""entity"": {
        ""name"": ""name-1275"",
        ""production"": false,
        ""space_guid"": ""90723e8b-cbf3-40be-bb12-891f7e0b873c"",
        ""stack_guid"": ""90723e8b-cbf3-40be-bb12-891f7e0b873c"",
        ""buildpack"": null,
        ""detected_buildpack"": null,
        ""environment_json"": null,
        ""memory"": 1024,
        ""instances"": 1,
        ""disk_quota"": 1024,
        ""state"": ""STOPPED"",
        ""version"": ""ff8c3a1e-d960-4f00-a03f-ae39848274bd"",
        ""command"": null,
        ""console"": false,
        ""debug"": null,
        ""staging_task_id"": null,
        ""package_state"": ""PENDING"",
        ""health_check_type"": ""port"",
        ""health_check_timeout"": null,
        ""staging_failed_reason"": null,
        ""staging_failed_description"": null,
        ""diego"": false,
        ""docker_image"": null,
        ""package_updated_at"": ""2016-02-11T13:20:36Z"",
        ""detected_start_command"": """",
        ""enable_ssh"": true,
        ""docker_credentials_json"": {
          ""redacted_message"": ""[PRIVATE DATA HIDDEN]""
        },
        ""ports"": null,
        ""space_url"": ""/v2/spaces/a8f669d2-c2d0-43ee-8b5c-31785dd2ad58"",
        ""stack_url"": ""/v2/stacks/de32fb19-d186-48dd-97f2-827161aee7f8"",
        ""events_url"": ""/v2/apps/d81c43bb-cb26-4d6f-873d-bdd07272ea7e/events"",
        ""service_bindings_url"": ""/v2/apps/d81c43bb-cb26-4d6f-873d-bdd07272ea7e/service_bindings"",
        ""routes_url"": ""/v2/apps/d81c43bb-cb26-4d6f-873d-bdd07272ea7e/routes""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllAppsForRouteResponse> page = Utilities.DeserializePage<ListAllAppsForRouteResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("90723e8b-cbf3-40be-bb12-891f7e0b873c", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/apps/d81c43bb-cb26-4d6f-873d-bdd07272ea7e", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:36Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-11T13:20:36Z", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1275", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Production), true);
            Assert.AreEqual("90723e8b-cbf3-40be-bb12-891f7e0b873c", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("90723e8b-cbf3-40be-bb12-891f7e0b873c", TestUtil.ToTestableString(page[0].StackGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Buildpack), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DetectedBuildpack), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EnvironmentJson), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(page[0].Memory), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page[0].Instances), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(page[0].DiskQuota), true);
            Assert.AreEqual("STOPPED", TestUtil.ToTestableString(page[0].State), true);
            Assert.AreEqual("ff8c3a1e-d960-4f00-a03f-ae39848274bd", TestUtil.ToTestableString(page[0].Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Command), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Console), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Debug), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].StagingTaskId), true);
            Assert.AreEqual("PENDING", TestUtil.ToTestableString(page[0].PackageState), true);
            Assert.AreEqual("port", TestUtil.ToTestableString(page[0].HealthCheckType), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].HealthCheckTimeout), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].StagingFailedReason), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].StagingFailedDescription), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Diego), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DockerImage), true);
            Assert.AreEqual("2016-02-11T13:20:36Z", TestUtil.ToTestableString(page[0].PackageUpdatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DetectedStartCommand), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].EnableSsh), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Ports), true);
            Assert.AreEqual("/v2/spaces/a8f669d2-c2d0-43ee-8b5c-31785dd2ad58", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/stacks/de32fb19-d186-48dd-97f2-827161aee7f8", TestUtil.ToTestableString(page[0].StackUrl), true);
            Assert.AreEqual("/v2/apps/d81c43bb-cb26-4d6f-873d-bdd07272ea7e/events", TestUtil.ToTestableString(page[0].EventsUrl), true);
            Assert.AreEqual("/v2/apps/d81c43bb-cb26-4d6f-873d-bdd07272ea7e/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/apps/d81c43bb-cb26-4d6f-873d-bdd07272ea7e/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
        }

        [TestMethod]
        public void TestCreateRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""0d6c5a4b-7187-4c59-8cd5-55fe38e0a8c0"",
    ""url"": ""/v2/routes/b02fae36-467b-47ab-a4fb-f113ac8f5843"",
    ""created_at"": ""2016-02-11T13:20:36Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": """",
    ""path"": """",
    ""domain_guid"": ""0d6c5a4b-7187-4c59-8cd5-55fe38e0a8c0"",
    ""space_guid"": ""0d6c5a4b-7187-4c59-8cd5-55fe38e0a8c0"",
    ""service_instance_guid"": null,
    ""port"": 10000,
    ""domain_url"": ""/v2/domains/07dde1f5-2caf-4634-8526-5e069c2759f1"",
    ""space_url"": ""/v2/spaces/71da47fe-6f24-44af-8aed-89bab4e4db29"",
    ""apps_url"": ""/v2/routes/b02fae36-467b-47ab-a4fb-f113ac8f5843/apps""
  }
}";

            CreateRouteResponse obj = Utilities.DeserializeJson<CreateRouteResponse>(json);

            Assert.AreEqual("0d6c5a4b-7187-4c59-8cd5-55fe38e0a8c0", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/b02fae36-467b-47ab-a4fb-f113ac8f5843", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:36Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("0d6c5a4b-7187-4c59-8cd5-55fe38e0a8c0", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("0d6c5a4b-7187-4c59-8cd5-55fe38e0a8c0", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
            Assert.AreEqual("10000", TestUtil.ToTestableString(obj.Port), true);
            Assert.AreEqual("/v2/domains/07dde1f5-2caf-4634-8526-5e069c2759f1", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/71da47fe-6f24-44af-8aed-89bab4e4db29", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/b02fae36-467b-47ab-a4fb-f113ac8f5843/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
        }

        [TestMethod]
        public void TestRetrieveRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""ecd88918-430a-4bc1-8a89-ed8fbef9b75c"",
    ""url"": ""/v2/routes/25c7e34e-188b-42ee-91da-e1ecb098251c"",
    ""created_at"": ""2016-02-11T13:20:36Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-15"",
    ""path"": """",
    ""domain_guid"": ""ecd88918-430a-4bc1-8a89-ed8fbef9b75c"",
    ""space_guid"": ""ecd88918-430a-4bc1-8a89-ed8fbef9b75c"",
    ""service_instance_guid"": ""ecd88918-430a-4bc1-8a89-ed8fbef9b75c"",
    ""port"": 0,
    ""domain_url"": ""/v2/domains/8918683d-3030-4cc3-9d05-00fd401bbf91"",
    ""space_url"": ""/v2/spaces/770fe253-e9e2-4602-9ab7-863e42623e42"",
    ""service_instance_url"": ""/v2/service_instances/6b15e38c-66f8-4b49-90ef-a6096bb335a4"",
    ""apps_url"": ""/v2/routes/25c7e34e-188b-42ee-91da-e1ecb098251c/apps""
  }
}";

            RetrieveRouteResponse obj = Utilities.DeserializeJson<RetrieveRouteResponse>(json);

            Assert.AreEqual("ecd88918-430a-4bc1-8a89-ed8fbef9b75c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/25c7e34e-188b-42ee-91da-e1ecb098251c", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:36Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-15", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("ecd88918-430a-4bc1-8a89-ed8fbef9b75c", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("ecd88918-430a-4bc1-8a89-ed8fbef9b75c", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("ecd88918-430a-4bc1-8a89-ed8fbef9b75c", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
            Assert.AreEqual("0", TestUtil.ToTestableString(obj.Port), true);
            Assert.AreEqual("/v2/domains/8918683d-3030-4cc3-9d05-00fd401bbf91", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/770fe253-e9e2-4602-9ab7-863e42623e42", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/service_instances/6b15e38c-66f8-4b49-90ef-a6096bb335a4", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);
            Assert.AreEqual("/v2/routes/25c7e34e-188b-42ee-91da-e1ecb098251c/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
        }

        [TestMethod]
        public void TestUpdateRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""c8aa231f-1f31-4d29-ac9c-6d6661c9e230"",
    ""url"": ""/v2/routes/c754ee42-0dec-481f-8b81-09a7ff108035"",
    ""created_at"": ""2016-02-11T13:20:37Z"",
    ""updated_at"": ""2016-02-11T13:20:37Z""
  },
  ""entity"": {
    ""host"": ""host-17"",
    ""path"": """",
    ""domain_guid"": ""c8aa231f-1f31-4d29-ac9c-6d6661c9e230"",
    ""space_guid"": ""c8aa231f-1f31-4d29-ac9c-6d6661c9e230"",
    ""service_instance_guid"": null,
    ""port"": 12000,
    ""domain_url"": ""/v2/domains/e5efdcc2-217f-4b09-b32e-3e78273a568e"",
    ""space_url"": ""/v2/spaces/86bce651-a4fd-4978-b090-ef71a26f06be"",
    ""apps_url"": ""/v2/routes/c754ee42-0dec-481f-8b81-09a7ff108035/apps""
  }
}";

            UpdateRouteResponse obj = Utilities.DeserializeJson<UpdateRouteResponse>(json);

            Assert.AreEqual("c8aa231f-1f31-4d29-ac9c-6d6661c9e230", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/c754ee42-0dec-481f-8b81-09a7ff108035", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:37Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-11T13:20:37Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-17", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("c8aa231f-1f31-4d29-ac9c-6d6661c9e230", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("c8aa231f-1f31-4d29-ac9c-6d6661c9e230", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
            Assert.AreEqual("12000", TestUtil.ToTestableString(obj.Port), true);
            Assert.AreEqual("/v2/domains/e5efdcc2-217f-4b09-b32e-3e78273a568e", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/86bce651-a4fd-4978-b090-ef71a26f06be", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/c754ee42-0dec-481f-8b81-09a7ff108035/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
        }
    }
}
