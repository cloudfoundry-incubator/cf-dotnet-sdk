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
        public void RetrieveSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""created_at"": ""2015-05-19T15:27:04+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroups.RetrieveSecurityGroup(guid).Result;


                Assert.AreEqual("5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

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
    ""guid"": ""5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""created_at"": ""2015-05-19T15:27:04+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? space_guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroups.AssociateSpaceWithSecurityGroup(guid, space_guid).Result;


                Assert.AreEqual("5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

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
        ""guid"": ""9d13a7ab-0f36-4036-8caa-f47fc414d1cb"",
        ""url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb"",
        ""created_at"": ""2015-05-19T15:27:15+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1458"",
        ""organization_guid"": ""52242bb3-fa53-4279-9e78-ba91a4d484b6"",
        ""space_quota_definition_guid"": null,
        ""organization_url"": ""/v2/organizations/52242bb3-fa53-4279-9e78-ba91a4d484b6"",
        ""developers_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/developers"",
        ""managers_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/managers"",
        ""auditors_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/auditors"",
        ""apps_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/apps"",
        ""routes_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/routes"",
        ""domains_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/domains"",
        ""service_instances_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/service_instances"",
        ""app_events_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/app_events"",
        ""events_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/events"",
        ""security_groups_url"": ""/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/security_groups""
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
                Assert.AreEqual("9d13a7ab-0f36-4036-8caa-f47fc414d1cb", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:15+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1458", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("52242bb3-fa53-4279-9e78-ba91a4d484b6", TestUtil.ToTestableString(obj[0].OrganizationGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SpaceQuotaDefinitionGuid), true);
                Assert.AreEqual("/v2/organizations/52242bb3-fa53-4279-9e78-ba91a4d484b6", TestUtil.ToTestableString(obj[0].OrganizationUrl), true);
                Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/developers", TestUtil.ToTestableString(obj[0].DevelopersUrl), true);
                Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/managers", TestUtil.ToTestableString(obj[0].ManagersUrl), true);
                Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/auditors", TestUtil.ToTestableString(obj[0].AuditorsUrl), true);
                Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/apps", TestUtil.ToTestableString(obj[0].AppsUrl), true);
                Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);
                Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/domains", TestUtil.ToTestableString(obj[0].DomainsUrl), true);
                Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/service_instances", TestUtil.ToTestableString(obj[0].ServiceInstancesUrl), true);
                Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/app_events", TestUtil.ToTestableString(obj[0].AppEventsUrl), true);
                Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/events", TestUtil.ToTestableString(obj[0].EventsUrl), true);
                Assert.AreEqual("/v2/spaces/9d13a7ab-0f36-4036-8caa-f47fc414d1cb/security_groups", TestUtil.ToTestableString(obj[0].SecurityGroupsUrl), true);

            }
        }

        [TestMethod]
        public void UpdateSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""created_at"": ""2015-05-19T15:27:04+00:00"",
    ""updated_at"": ""2015-05-19T15:27:16+00:00""
  },
  ""entity"": {
    ""name"": ""new_name"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateSecurityGroupRequest value = new UpdateSecurityGroupRequest();


                var obj = cfClient.SecurityGroups.UpdateSecurityGroup(guid, value).Result;


                Assert.AreEqual("5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2015-05-19T15:27:16+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("new_name", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

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
        ""guid"": ""5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
        ""url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
        ""created_at"": ""2015-05-19T15:27:04+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""dummy1"",
        ""rules"": [

        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""d9f82a70-e5a2-430e-b8b4-169a82d4dc03"",
        ""url"": ""/v2/security_groups/d9f82a70-e5a2-430e-b8b4-169a82d4dc03"",
        ""created_at"": ""2015-05-19T15:27:04+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""dummy2"",
        ""rules"": [

        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/d9f82a70-e5a2-430e-b8b4-169a82d4dc03/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""2d659b5d-92c9-4893-9d3c-8e19979a4ffa"",
        ""url"": ""/v2/security_groups/2d659b5d-92c9-4893-9d3c-8e19979a4ffa"",
        ""created_at"": ""2015-05-19T15:27:16+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1461"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/2d659b5d-92c9-4893-9d3c-8e19979a4ffa/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""ac339892-bd4b-446f-9bb6-127d58764867"",
        ""url"": ""/v2/security_groups/ac339892-bd4b-446f-9bb6-127d58764867"",
        ""created_at"": ""2015-05-19T15:27:16+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1462"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/ac339892-bd4b-446f-9bb6-127d58764867/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""5476cbbf-96b1-4e8c-9776-83ef564f99c2"",
        ""url"": ""/v2/security_groups/5476cbbf-96b1-4e8c-9776-83ef564f99c2"",
        ""created_at"": ""2015-05-19T15:27:16+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1463"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": false,
        ""staging_default"": false,
        ""spaces_url"": ""/v2/security_groups/5476cbbf-96b1-4e8c-9776-83ef564f99c2/spaces""
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
                Assert.AreEqual("5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces", TestUtil.ToTestableString(obj[0].SpacesUrl), true);
                Assert.AreEqual("d9f82a70-e5a2-430e-b8b4-169a82d4dc03", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/d9f82a70-e5a2-430e-b8b4-169a82d4dc03", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy2", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[1].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[1].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/d9f82a70-e5a2-430e-b8b4-169a82d4dc03/spaces", TestUtil.ToTestableString(obj[1].SpacesUrl), true);
                Assert.AreEqual("2d659b5d-92c9-4893-9d3c-8e19979a4ffa", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/2d659b5d-92c9-4893-9d3c-8e19979a4ffa", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:16+00:00", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1461", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[2].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[2].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/2d659b5d-92c9-4893-9d3c-8e19979a4ffa/spaces", TestUtil.ToTestableString(obj[2].SpacesUrl), true);
                Assert.AreEqual("ac339892-bd4b-446f-9bb6-127d58764867", TestUtil.ToTestableString(obj[3].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/ac339892-bd4b-446f-9bb6-127d58764867", TestUtil.ToTestableString(obj[3].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:16+00:00", TestUtil.ToTestableString(obj[3].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1462", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[3].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[3].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/ac339892-bd4b-446f-9bb6-127d58764867/spaces", TestUtil.ToTestableString(obj[3].SpacesUrl), true);
                Assert.AreEqual("5476cbbf-96b1-4e8c-9776-83ef564f99c2", TestUtil.ToTestableString(obj[4].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/5476cbbf-96b1-4e8c-9776-83ef564f99c2", TestUtil.ToTestableString(obj[4].EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:16+00:00", TestUtil.ToTestableString(obj[4].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1463", TestUtil.ToTestableString(obj[4].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[4].RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[4].StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/5476cbbf-96b1-4e8c-9776-83ef564f99c2/spaces", TestUtil.ToTestableString(obj[4].SpacesUrl), true);

            }
        }

        [TestMethod]
        public void RemoveSpaceFromSecurityGroupTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53"",
    ""created_at"": ""2015-05-19T15:27:04+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""dummy1"",
    ""rules"": [

    ],
    ""running_default"": false,
    ""staging_default"": false,
    ""spaces_url"": ""/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? space_guid = Guid.NewGuid();


                var obj = cfClient.SecurityGroups.RemoveSpaceFromSecurityGroup(guid, space_guid).Result;


                Assert.AreEqual("5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:04+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("dummy1", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/5f9970c6-7fe0-46d4-ae4a-341c12682b53/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

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
    ""guid"": ""088de609-e103-4228-8ae8-6956fbb77229"",
    ""url"": ""/v2/security_groups/088de609-e103-4228-8ae8-6956fbb77229"",
    ""created_at"": ""2015-05-19T15:27:16+00:00"",
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
    ""spaces_url"": ""/v2/security_groups/088de609-e103-4228-8ae8-6956fbb77229/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateSecurityGroupRequest value = new CreateSecurityGroupRequest();


                var obj = cfClient.SecurityGroups.CreateSecurityGroup(value).Result;


                Assert.AreEqual("088de609-e103-4228-8ae8-6956fbb77229", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/security_groups/088de609-e103-4228-8ae8-6956fbb77229", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-05-19T15:27:16+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("my_super_sec_group", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.RunningDefault), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
                Assert.AreEqual("/v2/security_groups/088de609-e103-4228-8ae8-6956fbb77229/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

    }
}