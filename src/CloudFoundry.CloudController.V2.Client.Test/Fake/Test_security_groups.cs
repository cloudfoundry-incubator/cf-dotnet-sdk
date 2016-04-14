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
    public class SecurityGroupsEndpoint
{
        [TestMethod]
        public void UpdateSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""fac15904-29bb-4c00-9692-b0d7e37a13fb"",
    ""url"": ""/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea"",
    ""created_at"": ""2016-04-11T13:32:56Z"",
    ""updated_at"": ""2016-04-11T13:33:05Z""
  },
  ""entity"": {
    ""name"": ""new_name"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateSecurityGroupRequest value = new UpdateSecurityGroupRequest();


                var obj = cfClient.SecurityGroups.UpdateSecurityGroup(guid, value).Result;


                Assert.AreEqual("fac15904-29bb-4c00-9692-b0d7e37a13fb", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:32:56Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-04-11T13:33:05Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("new_name", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void ListAllSpacesForSecurityGroupTest()
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
        ""guid"": ""a7b378af-25da-445c-9614-9cfceb2d4601"",
        ""url"": ""/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce"",
        ""created_at"": ""2016-04-11T13:33:06Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-841"",
        ""organization_guid"": ""a7b378af-25da-445c-9614-9cfceb2d4601"",
        ""space_quota_definition_guid"": null,
        ""allow_ssh"": true,
        ""organization_url"": ""/v2/organizations/410cf013-5e19-408a-b118-c3dcf572a32f"",
        ""developers_url"": ""/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/developers"",
        ""managers_url"": ""/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/managers"",
        ""auditors_url"": ""/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/auditors"",
        ""apps_url"": ""/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/apps"",
        ""routes_url"": ""/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/routes"",
        ""domains_url"": ""/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/domains"",
        ""service_instances_url"": ""/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/service_instances"",
        ""app_events_url"": ""/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/app_events"",
        ""events_url"": ""/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/events"",
        ""security_groups_url"": ""/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/security_groups""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroups.ListAllSpacesForSecurityGroup(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("a7b378af-25da-445c-9614-9cfceb2d4601", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:06Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-841", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("a7b378af-25da-445c-9614-9cfceb2d4601", TestUtil.ToTestableString(obj[0].OrganizationGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SpaceQuotaDefinitionGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].AllowSsh), true);
                Assert.AreEqual("/v2/organizations/410cf013-5e19-408a-b118-c3dcf572a32f", TestUtil.ToTestableString(obj[0].OrganizationUrl), true);
                Assert.AreEqual("/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/developers", TestUtil.ToTestableString(obj[0].DevelopersUrl), true);
                Assert.AreEqual("/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/managers", TestUtil.ToTestableString(obj[0].ManagersUrl), true);
                Assert.AreEqual("/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/auditors", TestUtil.ToTestableString(obj[0].AuditorsUrl), true);
                Assert.AreEqual("/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/apps", TestUtil.ToTestableString(obj[0].AppsUrl), true);
                Assert.AreEqual("/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);
                Assert.AreEqual("/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/domains", TestUtil.ToTestableString(obj[0].DomainsUrl), true);
                Assert.AreEqual("/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/service_instances", TestUtil.ToTestableString(obj[0].ServiceInstancesUrl), true);
                Assert.AreEqual("/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/app_events", TestUtil.ToTestableString(obj[0].AppEventsUrl), true);
                Assert.AreEqual("/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/events", TestUtil.ToTestableString(obj[0].EventsUrl), true);
                Assert.AreEqual("/v2/spaces/0043fcff-61f9-4c36-9d08-62f2d78df8ce/security_groups", TestUtil.ToTestableString(obj[0].SecurityGroupsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllSecurityGroupsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 5,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""9a3905f8-8ce5-40f3-a413-854b36776625"",
        ""url"": ""/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea"",
        ""created_at"": ""2016-04-11T13:32:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""dummy1"",
        ""rules"": [

        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""9a3905f8-8ce5-40f3-a413-854b36776625"",
        ""url"": ""/v2/security_groups/6422bb80-3e2e-43c3-a9f3-919d7fa14392"",
        ""created_at"": ""2016-04-11T13:32:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""dummy2"",
        ""rules"": [

        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/6422bb80-3e2e-43c3-a9f3-919d7fa14392/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""9a3905f8-8ce5-40f3-a413-854b36776625"",
        ""url"": ""/v2/security_groups/d639358f-1d07-47e0-9605-e23635fa0d3d"",
        ""created_at"": ""2016-04-11T13:33:05Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-826"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/d639358f-1d07-47e0-9605-e23635fa0d3d/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""9a3905f8-8ce5-40f3-a413-854b36776625"",
        ""url"": ""/v2/security_groups/68ce26c3-57a1-4265-baa7-a9966f61d27d"",
        ""created_at"": ""2016-04-11T13:33:05Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-827"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/68ce26c3-57a1-4265-baa7-a9966f61d27d/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""9a3905f8-8ce5-40f3-a413-854b36776625"",
        ""url"": ""/v2/security_groups/fe2ae736-e54a-42a3-8afa-efacb314b6f5"",
        ""created_at"": ""2016-04-11T13:33:05Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-828"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/fe2ae736-e54a-42a3-8afa-efacb314b6f5/spaces""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SecurityGroups.ListAllSecurityGroups().Result;

                Assert.AreEqual("5", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("9a3905f8-8ce5-40f3-a413-854b36776625", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:32:56Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea/spaces", TestUtil.ToTestableString(obj[0].SpacesUrl), true);
                Assert.AreEqual("9a3905f8-8ce5-40f3-a413-854b36776625", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/6422bb80-3e2e-43c3-a9f3-919d7fa14392", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:32:56Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy2", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[1].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[1].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/6422bb80-3e2e-43c3-a9f3-919d7fa14392/spaces", TestUtil.ToTestableString(obj[1].SpacesUrl), true);
                Assert.AreEqual("9a3905f8-8ce5-40f3-a413-854b36776625", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/d639358f-1d07-47e0-9605-e23635fa0d3d", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:05Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-826", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[2].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[2].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/d639358f-1d07-47e0-9605-e23635fa0d3d/spaces", TestUtil.ToTestableString(obj[2].SpacesUrl), true);
                Assert.AreEqual("9a3905f8-8ce5-40f3-a413-854b36776625", TestUtil.ToTestableString(obj[3].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/68ce26c3-57a1-4265-baa7-a9966f61d27d", TestUtil.ToTestableString(obj[3].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:05Z", TestUtil.ToTestableString(obj[3].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-827", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[3].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[3].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/68ce26c3-57a1-4265-baa7-a9966f61d27d/spaces", TestUtil.ToTestableString(obj[3].SpacesUrl), true);
                Assert.AreEqual("9a3905f8-8ce5-40f3-a413-854b36776625", TestUtil.ToTestableString(obj[4].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/fe2ae736-e54a-42a3-8afa-efacb314b6f5", TestUtil.ToTestableString(obj[4].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:05Z", TestUtil.ToTestableString(obj[4].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-828", TestUtil.ToTestableString(obj[4].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[4].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[4].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/fe2ae736-e54a-42a3-8afa-efacb314b6f5/spaces", TestUtil.ToTestableString(obj[4].SpacesUrl), true);

            }
        }

        [TestMethod]
        public void RetrieveSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""a26580e7-d480-417b-9e47-e8647070cd1c"",
    ""url"": ""/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea"",
    ""created_at"": ""2016-04-11T13:32:56Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroups.RetrieveSecurityGroup(guid).Result;


                Assert.AreEqual("a26580e7-d480-417b-9e47-e8647070cd1c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:32:56Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void DeleteSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SecurityGroups.DeleteSecurityGroup(guid).Wait();

            }
        }

        [TestMethod]
        public void AssociateSpaceWithSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""dc5495c1-5e8b-4b02-a08c-42045b7010eb"",
    ""url"": ""/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea"",
    ""created_at"": ""2016-04-11T13:32:56Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? space_guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroups.AssociateSpaceWithSecurityGroup(guid, space_guid).Result;


                Assert.AreEqual("dc5495c1-5e8b-4b02-a08c-42045b7010eb", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:32:56Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/b9af05cb-24b1-4ae3-bbbd-3fb48f9fa0ea/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void RemoveSpaceFromSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? space_guid = Guid.NewGuid();


                cfClient.SecurityGroups.RemoveSpaceFromSecurityGroup(guid, space_guid).Wait();

            }
        }

        [TestMethod]
        public void CreateSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""8f6b28b8-76f0-4562-8dee-4feef9f7235d"",
    ""url"": ""/v2/security_groups/df719c87-8da5-4a62-b1d4-bccc9b4fc8b1"",
    ""created_at"": ""2016-04-11T13:33:06Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""my_super_sec_group"",
    ""rules"": [
      {
        ""protocol"": ""icmp"",
        ""destination"": ""0.0.0.0/0"",
        ""type"": 0,
        ""code"": 1
      },
      {
        ""protocol"": ""tcp"",
        ""destination"": ""0.0.0.0/0"",
        ""ports"": ""2048-3000"",
        ""log"": true
      },
      {
        ""protocol"": ""udp"",
        ""destination"": ""0.0.0.0/0"",
        ""ports"": ""53, 5353""
      },
      {
        ""protocol"": ""all"",
        ""destination"": ""0.0.0.0/0""
      }
    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/df719c87-8da5-4a62-b1d4-bccc9b4fc8b1/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateSecurityGroupRequest value = new CreateSecurityGroupRequest();


                var obj = cfClient.SecurityGroups.CreateSecurityGroup(value).Result;


                Assert.AreEqual("8f6b28b8-76f0-4562-8dee-4feef9f7235d", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/df719c87-8da5-4a62-b1d4-bccc9b4fc8b1", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:06Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("my_super_sec_group", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/df719c87-8da5-4a62-b1d4-bccc9b4fc8b1/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

    }
}