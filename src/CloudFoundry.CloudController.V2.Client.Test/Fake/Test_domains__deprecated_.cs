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
    public class DomainsDeprecatedEndpoint
{
        [TestMethod]
        public void CreateSharedDomainDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""5e7aeb28-3e9e-4e58-9471-04e09509cbbd"",
    ""url"": ""/v2/shared_domains/ad2b48b9-ae2a-4f18-b5cb-cd9b074a457f"",
    ""created_at"": ""2017-01-04T15:58:37Z"",
    ""updated_at"": ""2017-01-04T15:58:37Z""
  },
  ""entity"": {
    ""name"": ""example.com"",
    ""router_group_guid"": null,
    ""router_group_type"": null
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateSharedDomainDeprecatedRequest value = new CreateSharedDomainDeprecatedRequest();


                var obj = cfClient.DomainsDeprecated.CreateSharedDomainDeprecated(value).Result;


                Assert.AreEqual("5e7aeb28-3e9e-4e58-9471-04e09509cbbd", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/ad2b48b9-ae2a-4f18-b5cb-cd9b074a457f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:37Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:37Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("example.com", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.RouterGroupType), true);

            }
        }

        [TestMethod]
        public void DeleteDomainDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.DomainsDeprecated.DeleteDomainDeprecated(guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllSpacesForDomainDeprecatedTest()
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
        ""guid"": ""4f973ff2-4481-4601-8199-aad8cf1a6cf7"",
        ""url"": ""/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c"",
        ""created_at"": ""2017-01-04T15:58:37Z"",
        ""updated_at"": ""2017-01-04T15:58:37Z""
      },
      ""entity"": {
        ""name"": ""name-157"",
        ""organization_guid"": ""4f973ff2-4481-4601-8199-aad8cf1a6cf7"",
        ""space_quota_definition_guid"": null,
        ""isolation_segment_guid"": null,
        ""allow_ssh"": true,
        ""organization_url"": ""/v2/organizations/419c606e-8940-4157-92aa-b66bfb6aba6b"",
        ""developers_url"": ""/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/developers"",
        ""managers_url"": ""/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/managers"",
        ""auditors_url"": ""/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/auditors"",
        ""apps_url"": ""/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/apps"",
        ""routes_url"": ""/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/routes"",
        ""domains_url"": ""/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/domains"",
        ""service_instances_url"": ""/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/service_instances"",
        ""app_events_url"": ""/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/app_events"",
        ""events_url"": ""/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/events"",
        ""security_groups_url"": ""/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/security_groups"",
        ""staging_security_groups_url"": ""/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/staging_security_groups""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.DomainsDeprecated.ListAllSpacesForDomainDeprecated(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("4f973ff2-4481-4601-8199-aad8cf1a6cf7", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:37Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:37Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-157", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("4f973ff2-4481-4601-8199-aad8cf1a6cf7", TestUtil.ToTestableString(obj[0].OrganizationGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].SpaceQuotaDefinitionGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].IsolationSegmentGuid), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].AllowSsh), true);
                Assert.AreEqual("/v2/organizations/419c606e-8940-4157-92aa-b66bfb6aba6b", TestUtil.ToTestableString(obj[0].OrganizationUrl), true);
                Assert.AreEqual("/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/developers", TestUtil.ToTestableString(obj[0].DevelopersUrl), true);
                Assert.AreEqual("/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/managers", TestUtil.ToTestableString(obj[0].ManagersUrl), true);
                Assert.AreEqual("/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/auditors", TestUtil.ToTestableString(obj[0].AuditorsUrl), true);
                Assert.AreEqual("/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/apps", TestUtil.ToTestableString(obj[0].AppsUrl), true);
                Assert.AreEqual("/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);
                Assert.AreEqual("/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/domains", TestUtil.ToTestableString(obj[0].DomainsUrl), true);
                Assert.AreEqual("/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/service_instances", TestUtil.ToTestableString(obj[0].ServiceInstancesUrl), true);
                Assert.AreEqual("/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/app_events", TestUtil.ToTestableString(obj[0].AppEventsUrl), true);
                Assert.AreEqual("/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/events", TestUtil.ToTestableString(obj[0].EventsUrl), true);
                Assert.AreEqual("/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/security_groups", TestUtil.ToTestableString(obj[0].SecurityGroupsUrl), true);
                Assert.AreEqual("/v2/spaces/f8858555-3c80-4c22-8cfe-9aff673f685c/staging_security_groups", TestUtil.ToTestableString(obj[0].StagingSecurityGroupsUrl), true);

            }
        }

        [TestMethod]
        public void RetrieveDomainDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""56210c84-e386-4ee8-8fe4-b43fadf3d846"",
    ""url"": ""/v2/shared_domains/7a07398c-1b08-4fed-90f0-36d3ca58d064"",
    ""created_at"": ""2017-01-04T15:58:37Z"",
    ""updated_at"": ""2017-01-04T15:58:37Z""
  },
  ""entity"": {
    ""name"": ""domain-34.example.com"",
    ""router_group_guid"": null,
    ""router_group_type"": null
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.DomainsDeprecated.RetrieveDomainDeprecated(guid).Result;


                Assert.AreEqual("56210c84-e386-4ee8-8fe4-b43fadf3d846", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/7a07398c-1b08-4fed-90f0-36d3ca58d064", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:37Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:37Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-34.example.com", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.RouterGroupType), true);

            }
        }

        [TestMethod]
        public void CreateDomainOwnedByGivenOrganizationDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""a84114dc-b845-43f8-95ef-41938ce3761e"",
    ""url"": ""/v2/private_domains/216d993b-41fb-4640-8f1f-2349a3a28c90"",
    ""created_at"": ""2017-01-04T15:58:37Z"",
    ""updated_at"": ""2017-01-04T15:58:37Z""
  },
  ""entity"": {
    ""name"": ""exmaple.com"",
    ""owning_organization_guid"": ""a84114dc-b845-43f8-95ef-41938ce3761e"",
    ""owning_organization_url"": ""/v2/organizations/1c2975e0-2fd0-4b16-9627-946aa0214101"",
    ""spaces_url"": ""/v2/domains/216d993b-41fb-4640-8f1f-2349a3a28c90/spaces""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateDomainOwnedByGivenOrganizationDeprecatedRequest value = new CreateDomainOwnedByGivenOrganizationDeprecatedRequest();


                var obj = cfClient.DomainsDeprecated.CreateDomainOwnedByGivenOrganizationDeprecated(value).Result;


                Assert.AreEqual("a84114dc-b845-43f8-95ef-41938ce3761e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/216d993b-41fb-4640-8f1f-2349a3a28c90", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:37Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:37Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("exmaple.com", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("a84114dc-b845-43f8-95ef-41938ce3761e", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/1c2975e0-2fd0-4b16-9627-946aa0214101", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/domains/216d993b-41fb-4640-8f1f-2349a3a28c90/spaces", TestUtil.ToTestableString(obj.SpacesUrl), true);

            }
        }

        [TestMethod]
        public void ListAllDomainsDeprecatedTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 4,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""b706460a-750c-489f-ae63-8799d315515e"",
        ""url"": ""/v2/shared_domains/9977ee99-36ac-47c4-84b4-55a553760d4d"",
        ""created_at"": ""2017-01-04T15:58:31Z"",
        ""updated_at"": ""2017-01-04T15:58:31Z""
      },
      ""entity"": {
        ""name"": ""customer-app-domain1.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""b706460a-750c-489f-ae63-8799d315515e"",
        ""url"": ""/v2/shared_domains/8312af50-0e52-4f3a-be0c-6738ee83fbb6"",
        ""created_at"": ""2017-01-04T15:58:31Z"",
        ""updated_at"": ""2017-01-04T15:58:31Z""
      },
      ""entity"": {
        ""name"": ""customer-app-domain2.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""b706460a-750c-489f-ae63-8799d315515e"",
        ""url"": ""/v2/private_domains/b990bc27-8884-46cd-8e46-9b869fdefb7e"",
        ""created_at"": ""2017-01-04T15:58:31Z"",
        ""updated_at"": ""2017-01-04T15:58:31Z""
      },
      ""entity"": {
        ""name"": ""vcap.me"",
        ""owning_organization_guid"": ""b706460a-750c-489f-ae63-8799d315515e"",
        ""owning_organization_url"": ""/v2/organizations/f19a3adf-c540-429e-a93b-4128331910aa"",
        ""spaces_url"": ""/v2/domains/b990bc27-8884-46cd-8e46-9b869fdefb7e/spaces""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""b706460a-750c-489f-ae63-8799d315515e"",
        ""url"": ""/v2/shared_domains/5aab5f97-b0fd-4472-9a16-de31431b9166"",
        ""created_at"": ""2017-01-04T15:58:37Z"",
        ""updated_at"": ""2017-01-04T15:58:37Z""
      },
      ""entity"": {
        ""name"": ""domain-30.example.com"",
        ""router_group_guid"": null,
        ""router_group_type"": null
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.DomainsDeprecated.ListAllDomainsDeprecated().Result;

                Assert.AreEqual("4", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("b706460a-750c-489f-ae63-8799d315515e", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/9977ee99-36ac-47c4-84b4-55a553760d4d", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:31Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:31Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].RouterGroupType), true);
                Assert.AreEqual("b706460a-750c-489f-ae63-8799d315515e", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/8312af50-0e52-4f3a-be0c-6738ee83fbb6", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:31Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:31Z", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain2.com", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].RouterGroupType), true);
                Assert.AreEqual("b706460a-750c-489f-ae63-8799d315515e", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/private_domains/b990bc27-8884-46cd-8e46-9b869fdefb7e", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:31Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:31Z", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("vcap.me", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("b706460a-750c-489f-ae63-8799d315515e", TestUtil.ToTestableString(obj[2].OwningOrganizationGuid), true);
                Assert.AreEqual("/v2/organizations/f19a3adf-c540-429e-a93b-4128331910aa", TestUtil.ToTestableString(obj[2].OwningOrganizationUrl), true);
                Assert.AreEqual("/v2/domains/b990bc27-8884-46cd-8e46-9b869fdefb7e/spaces", TestUtil.ToTestableString(obj[2].SpacesUrl), true);
                Assert.AreEqual("b706460a-750c-489f-ae63-8799d315515e", TestUtil.ToTestableString(obj[3].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/5aab5f97-b0fd-4472-9a16-de31431b9166", TestUtil.ToTestableString(obj[3].EntityMetadata.Url), true);
                Assert.AreEqual("2017-01-04T15:58:37Z", TestUtil.ToTestableString(obj[3].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2017-01-04T15:58:37Z", TestUtil.ToTestableString(obj[3].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-30.example.com", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].RouterGroupGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].RouterGroupType), true);

            }
        }

    }
}