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
        public void TestRetrieveRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""0f782d0b-4906-4c18-9208-1f6476612d64"",
    ""url"": ""/v2/routes/0f782d0b-4906-4c18-9208-1f6476612d64"",
    ""created_at"": ""2016-02-05T12:14:38Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-5"",
    ""path"": """",
    ""domain_guid"": ""b584556d-a932-4095-a35f-f62e5ee3e2f4"",
    ""space_guid"": ""9dfea921-9b13-4be2-bbca-46b306b82119"",
    ""domain_url"": ""/v2/domains/b584556d-a932-4095-a35f-f62e5ee3e2f4"",
    ""space_url"": ""/v2/spaces/9dfea921-9b13-4be2-bbca-46b306b82119"",
    ""apps_url"": ""/v2/routes/0f782d0b-4906-4c18-9208-1f6476612d64/apps""
  }
}";

            RetrieveRouteResponse obj = Utilities.DeserializeJson<RetrieveRouteResponse>(json);

            Assert.AreEqual("0f782d0b-4906-4c18-9208-1f6476612d64", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/0f782d0b-4906-4c18-9208-1f6476612d64", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:38Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-5", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("b584556d-a932-4095-a35f-f62e5ee3e2f4", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("9dfea921-9b13-4be2-bbca-46b306b82119", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("/v2/domains/b584556d-a932-4095-a35f-f62e5ee3e2f4", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/9dfea921-9b13-4be2-bbca-46b306b82119", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/0f782d0b-4906-4c18-9208-1f6476612d64/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
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
        ""guid"": ""0b9fd36c-0340-4032-95fe-4a15b5638a10"",
        ""url"": ""/v2/apps/0b9fd36c-0340-4032-95fe-4a15b5638a10"",
        ""created_at"": ""2016-02-05T12:14:38Z"",
        ""updated_at"": ""2016-02-05T12:14:38Z""
      },
      ""entity"": {
        ""name"": ""name-197"",
        ""production"": false,
        ""space_guid"": ""8613a224-a7a5-4151-9dc4-12d093c852ed"",
        ""stack_guid"": ""bbc9a1d5-4404-45ee-a5d9-d1142fa4076d"",
        ""buildpack"": null,
        ""detected_buildpack"": null,
        ""environment_json"": null,
        ""memory"": 1024,
        ""instances"": 1,
        ""disk_quota"": 1024,
        ""state"": ""STOPPED"",
        ""version"": ""e044b1af-aa46-44d0-b291-4d372cf5e1b0"",
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
        ""package_updated_at"": ""2016-02-05T12:14:38Z"",
        ""detected_start_command"": """",
        ""enable_ssh"": true,
        ""space_url"": ""/v2/spaces/8613a224-a7a5-4151-9dc4-12d093c852ed"",
        ""stack_url"": ""/v2/stacks/bbc9a1d5-4404-45ee-a5d9-d1142fa4076d"",
        ""events_url"": ""/v2/apps/0b9fd36c-0340-4032-95fe-4a15b5638a10/events"",
        ""service_bindings_url"": ""/v2/apps/0b9fd36c-0340-4032-95fe-4a15b5638a10/service_bindings"",
        ""routes_url"": ""/v2/apps/0b9fd36c-0340-4032-95fe-4a15b5638a10/routes""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllAppsForRouteResponse> page = Utilities.DeserializePage<ListAllAppsForRouteResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("0b9fd36c-0340-4032-95fe-4a15b5638a10", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/apps/0b9fd36c-0340-4032-95fe-4a15b5638a10", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:38Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-05T12:14:38Z", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-197", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Production), true);
            Assert.AreEqual("8613a224-a7a5-4151-9dc4-12d093c852ed", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("bbc9a1d5-4404-45ee-a5d9-d1142fa4076d", TestUtil.ToTestableString(page[0].StackGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Buildpack), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DetectedBuildpack), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EnvironmentJson), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(page[0].Memory), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page[0].Instances), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(page[0].DiskQuota), true);
            Assert.AreEqual("STOPPED", TestUtil.ToTestableString(page[0].State), true);
            Assert.AreEqual("e044b1af-aa46-44d0-b291-4d372cf5e1b0", TestUtil.ToTestableString(page[0].Version), true);
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
            Assert.AreEqual("2016-02-05T12:14:38Z", TestUtil.ToTestableString(page[0].PackageUpdatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DetectedStartCommand), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].EnableSsh), true);
            Assert.AreEqual("/v2/spaces/8613a224-a7a5-4151-9dc4-12d093c852ed", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/stacks/bbc9a1d5-4404-45ee-a5d9-d1142fa4076d", TestUtil.ToTestableString(page[0].StackUrl), true);
            Assert.AreEqual("/v2/apps/0b9fd36c-0340-4032-95fe-4a15b5638a10/events", TestUtil.ToTestableString(page[0].EventsUrl), true);
            Assert.AreEqual("/v2/apps/0b9fd36c-0340-4032-95fe-4a15b5638a10/service_bindings", TestUtil.ToTestableString(page[0].ServiceBindingsUrl), true);
            Assert.AreEqual("/v2/apps/0b9fd36c-0340-4032-95fe-4a15b5638a10/routes", TestUtil.ToTestableString(page[0].RoutesUrl), true);
        }

        [TestMethod]
        public void TestUpdateRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""9b4da90a-a9c9-4580-92a8-c36e8ca8b628"",
    ""url"": ""/v2/routes/9b4da90a-a9c9-4580-92a8-c36e8ca8b628"",
    ""created_at"": ""2016-02-05T12:14:37Z"",
    ""updated_at"": ""2016-02-05T12:14:37Z""
  },
  ""entity"": {
    ""host"": ""new_host"",
    ""path"": ""/apps/v1/path"",
    ""domain_guid"": ""183ba448-9c3e-4840-8dbc-7320f486db4c"",
    ""space_guid"": ""03955faf-b37a-449d-8564-3806ab0b67f7"",
    ""domain_url"": ""/v2/domains/183ba448-9c3e-4840-8dbc-7320f486db4c"",
    ""space_url"": ""/v2/spaces/03955faf-b37a-449d-8564-3806ab0b67f7"",
    ""apps_url"": ""/v2/routes/9b4da90a-a9c9-4580-92a8-c36e8ca8b628/apps""
  }
}";

            UpdateRouteResponse obj = Utilities.DeserializeJson<UpdateRouteResponse>(json);

            Assert.AreEqual("9b4da90a-a9c9-4580-92a8-c36e8ca8b628", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/9b4da90a-a9c9-4580-92a8-c36e8ca8b628", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:37Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-05T12:14:37Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("new_host", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("/apps/v1/path", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("183ba448-9c3e-4840-8dbc-7320f486db4c", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("03955faf-b37a-449d-8564-3806ab0b67f7", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("/v2/domains/183ba448-9c3e-4840-8dbc-7320f486db4c", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/03955faf-b37a-449d-8564-3806ab0b67f7", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/9b4da90a-a9c9-4580-92a8-c36e8ca8b628/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
        }

        [TestMethod]
        public void TestAssociateAppWithRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""869ba864-ba55-4707-b33a-5c7dcb9b8184"",
    ""url"": ""/v2/routes/869ba864-ba55-4707-b33a-5c7dcb9b8184"",
    ""created_at"": ""2016-02-05T12:14:38Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-9"",
    ""path"": """",
    ""domain_guid"": ""3fdc3a5f-b05b-44de-a87b-fdc3974b8a90"",
    ""space_guid"": ""10cb86b7-c38e-4d68-a250-359be99463ed"",
    ""domain_url"": ""/v2/domains/3fdc3a5f-b05b-44de-a87b-fdc3974b8a90"",
    ""space_url"": ""/v2/spaces/10cb86b7-c38e-4d68-a250-359be99463ed"",
    ""apps_url"": ""/v2/routes/869ba864-ba55-4707-b33a-5c7dcb9b8184/apps""
  }
}";

            AssociateAppWithRouteResponse obj = Utilities.DeserializeJson<AssociateAppWithRouteResponse>(json);

            Assert.AreEqual("869ba864-ba55-4707-b33a-5c7dcb9b8184", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/869ba864-ba55-4707-b33a-5c7dcb9b8184", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:38Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-9", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("3fdc3a5f-b05b-44de-a87b-fdc3974b8a90", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("10cb86b7-c38e-4d68-a250-359be99463ed", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("/v2/domains/3fdc3a5f-b05b-44de-a87b-fdc3974b8a90", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/10cb86b7-c38e-4d68-a250-359be99463ed", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/869ba864-ba55-4707-b33a-5c7dcb9b8184/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
        }

        [TestMethod]
        public void TestRemoveAppFromRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""fd7a8689-6de7-4e13-9a0b-64ad64594c1f"",
    ""url"": ""/v2/routes/fd7a8689-6de7-4e13-9a0b-64ad64594c1f"",
    ""created_at"": ""2016-02-05T12:14:38Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-7"",
    ""path"": """",
    ""domain_guid"": ""44181321-3f05-4372-966b-5edd35f533ef"",
    ""space_guid"": ""eb96b19a-540b-483e-bab6-f544453a9456"",
    ""domain_url"": ""/v2/domains/44181321-3f05-4372-966b-5edd35f533ef"",
    ""space_url"": ""/v2/spaces/eb96b19a-540b-483e-bab6-f544453a9456"",
    ""apps_url"": ""/v2/routes/fd7a8689-6de7-4e13-9a0b-64ad64594c1f/apps""
  }
}";

            RemoveAppFromRouteResponse obj = Utilities.DeserializeJson<RemoveAppFromRouteResponse>(json);

            Assert.AreEqual("fd7a8689-6de7-4e13-9a0b-64ad64594c1f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/fd7a8689-6de7-4e13-9a0b-64ad64594c1f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:38Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-7", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("44181321-3f05-4372-966b-5edd35f533ef", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("eb96b19a-540b-483e-bab6-f544453a9456", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("/v2/domains/44181321-3f05-4372-966b-5edd35f533ef", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/eb96b19a-540b-483e-bab6-f544453a9456", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/fd7a8689-6de7-4e13-9a0b-64ad64594c1f/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
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
        ""guid"": ""2badadb5-d9d6-4b28-8958-4ce044ff9784"",
        ""url"": ""/v2/routes/2badadb5-d9d6-4b28-8958-4ce044ff9784"",
        ""created_at"": ""2016-02-05T12:14:38Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""host"": ""host-4"",
        ""path"": """",
        ""domain_guid"": ""686302d8-10a3-459d-bbdb-d4c8e5dd9e7d"",
        ""space_guid"": ""46e813eb-21d7-4449-9b51-781cea730eec"",
        ""domain_url"": ""/v2/domains/686302d8-10a3-459d-bbdb-d4c8e5dd9e7d"",
        ""space_url"": ""/v2/spaces/46e813eb-21d7-4449-9b51-781cea730eec"",
        ""apps_url"": ""/v2/routes/2badadb5-d9d6-4b28-8958-4ce044ff9784/apps""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllRoutesResponse> page = Utilities.DeserializePage<ListAllRoutesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("2badadb5-d9d6-4b28-8958-4ce044ff9784", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/2badadb5-d9d6-4b28-8958-4ce044ff9784", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:38Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("host-4", TestUtil.ToTestableString(page[0].Host), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Path), true);
            Assert.AreEqual("686302d8-10a3-459d-bbdb-d4c8e5dd9e7d", TestUtil.ToTestableString(page[0].DomainGuid), true);
            Assert.AreEqual("46e813eb-21d7-4449-9b51-781cea730eec", TestUtil.ToTestableString(page[0].SpaceGuid), true);
            Assert.AreEqual("/v2/domains/686302d8-10a3-459d-bbdb-d4c8e5dd9e7d", TestUtil.ToTestableString(page[0].DomainUrl), true);
            Assert.AreEqual("/v2/spaces/46e813eb-21d7-4449-9b51-781cea730eec", TestUtil.ToTestableString(page[0].SpaceUrl), true);
            Assert.AreEqual("/v2/routes/2badadb5-d9d6-4b28-8958-4ce044ff9784/apps", TestUtil.ToTestableString(page[0].AppsUrl), true);
        }

        [TestMethod]
        public void TestCreateRouteResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""83aedb19-2c35-4001-8d3b-988a1e80f3db"",
    ""url"": ""/v2/routes/83aedb19-2c35-4001-8d3b-988a1e80f3db"",
    ""created_at"": ""2016-02-05T12:14:38Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": """",
    ""path"": ""/apps/v1/path"",
    ""domain_guid"": ""14e7c4a5-1b21-4d4b-ac7a-431f622f2fde"",
    ""space_guid"": ""b9039181-b780-422e-8a6c-9dad1fd6b9d3"",
    ""domain_url"": ""/v2/domains/14e7c4a5-1b21-4d4b-ac7a-431f622f2fde"",
    ""space_url"": ""/v2/spaces/b9039181-b780-422e-8a6c-9dad1fd6b9d3"",
    ""apps_url"": ""/v2/routes/83aedb19-2c35-4001-8d3b-988a1e80f3db/apps""
  }
}";

            CreateRouteResponse obj = Utilities.DeserializeJson<CreateRouteResponse>(json);

            Assert.AreEqual("83aedb19-2c35-4001-8d3b-988a1e80f3db", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/routes/83aedb19-2c35-4001-8d3b-988a1e80f3db", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-05T12:14:38Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Host), true);
            Assert.AreEqual("/apps/v1/path", TestUtil.ToTestableString(obj.Path), true);
            Assert.AreEqual("14e7c4a5-1b21-4d4b-ac7a-431f622f2fde", TestUtil.ToTestableString(obj.DomainGuid), true);
            Assert.AreEqual("b9039181-b780-422e-8a6c-9dad1fd6b9d3", TestUtil.ToTestableString(obj.SpaceGuid), true);
            Assert.AreEqual("/v2/domains/14e7c4a5-1b21-4d4b-ac7a-431f622f2fde", TestUtil.ToTestableString(obj.DomainUrl), true);
            Assert.AreEqual("/v2/spaces/b9039181-b780-422e-8a6c-9dad1fd6b9d3", TestUtil.ToTestableString(obj.SpaceUrl), true);
            Assert.AreEqual("/v2/routes/83aedb19-2c35-4001-8d3b-988a1e80f3db/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
        }
    }
}
