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
    public class PrivateDomainsTest
    {


        [TestMethod]
        public void TestFilterPrivateDomainsByNameResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""266d4f20-3b92-435d-8620-1310378403ab"",
        ""url"": ""/v2/private_domains/266d4f20-3b92-435d-8620-1310378403ab"",
        ""created_at"": ""2015-07-29T12:47:18Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""my-domain.com"",
        ""owning_organization_guid"": ""f33358df-3963-4603-9877-b99b9ec253b5"",
        ""owning_organization_url"": ""/v2/organizations/f33358df-3963-4603-9877-b99b9ec253b5"",
        ""shared_organizations_url"": ""/v2/private_domains/266d4f20-3b92-435d-8620-1310378403ab/shared_organizations""
      }
    }
  ]
}";

            PagedResponseCollection<FilterPrivateDomainsByNameResponse> page = Utilities.DeserializePage<FilterPrivateDomainsByNameResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("266d4f20-3b92-435d-8620-1310378403ab", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/266d4f20-3b92-435d-8620-1310378403ab", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:18Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("my-domain.com", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("f33358df-3963-4603-9877-b99b9ec253b5", TestUtil.ToTestableString(page[0].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/f33358df-3963-4603-9877-b99b9ec253b5", TestUtil.ToTestableString(page[0].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/266d4f20-3b92-435d-8620-1310378403ab/shared_organizations", TestUtil.ToTestableString(page[0].SharedOrganizationsUrl), true);
        }

        [TestMethod]
        public void TestListAllSharedOrganizationsForPrivateDomainResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""9cdb31bf-070a-4ed0-82a4-55ac426988a4"",
        ""url"": ""/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4"",
        ""created_at"": ""2015-07-29T12:47:18Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-409"",
        ""billing_enabled"": false,
        ""quota_definition_guid"": ""ac981d09-a5a1-488e-9a39-ae28f2e778a0"",
        ""status"": ""active"",
        ""quota_definition_url"": ""/v2/quota_definitions/ac981d09-a5a1-488e-9a39-ae28f2e778a0"",
        ""spaces_url"": ""/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/spaces"",
        ""domains_url"": ""/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/domains"",
        ""private_domains_url"": ""/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/private_domains"",
        ""users_url"": ""/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/users"",
        ""managers_url"": ""/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/managers"",
        ""billing_managers_url"": ""/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/billing_managers"",
        ""auditors_url"": ""/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/auditors"",
        ""app_events_url"": ""/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/app_events"",
        ""space_quota_definitions_url"": ""/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/space_quota_definitions""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllSharedOrganizationsForPrivateDomainResponse> page = Utilities.DeserializePage<ListAllSharedOrganizationsForPrivateDomainResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("9cdb31bf-070a-4ed0-82a4-55ac426988a4", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:18Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-409", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].BillingEnabled), true);
            Assert.AreEqual("ac981d09-a5a1-488e-9a39-ae28f2e778a0", TestUtil.ToTestableString(page[0].QuotaDefinitionGuid), true);
            Assert.AreEqual("active", TestUtil.ToTestableString(page[0].Status), true);
            Assert.AreEqual("/v2/quota_definitions/ac981d09-a5a1-488e-9a39-ae28f2e778a0", TestUtil.ToTestableString(page[0].QuotaDefinitionUrl), true);
            Assert.AreEqual("/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/spaces", TestUtil.ToTestableString(page[0].SpacesUrl), true);
            Assert.AreEqual("/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/domains", TestUtil.ToTestableString(page[0].DomainsUrl), true);
            Assert.AreEqual("/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/private_domains", TestUtil.ToTestableString(page[0].PrivateDomainsUrl), true);
            Assert.AreEqual("/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/users", TestUtil.ToTestableString(page[0].UsersUrl), true);
            Assert.AreEqual("/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/managers", TestUtil.ToTestableString(page[0].ManagersUrl), true);
            Assert.AreEqual("/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/billing_managers", TestUtil.ToTestableString(page[0].BillingManagersUrl), true);
            Assert.AreEqual("/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/auditors", TestUtil.ToTestableString(page[0].AuditorsUrl), true);
            Assert.AreEqual("/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/app_events", TestUtil.ToTestableString(page[0].AppEventsUrl), true);
            Assert.AreEqual("/v2/organizations/9cdb31bf-070a-4ed0-82a4-55ac426988a4/space_quota_definitions", TestUtil.ToTestableString(page[0].SpaceQuotaDefinitionsUrl), true);
        }

        [TestMethod]
        public void TestRetrievePrivateDomainResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""4e335186-814f-4293-814a-fb042d4c89ff"",
    ""url"": ""/v2/private_domains/4e335186-814f-4293-814a-fb042d4c89ff"",
    ""created_at"": ""2015-07-29T12:47:17Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""vcap.me"",
    ""owning_organization_guid"": ""670702ab-b7e2-425b-92bd-f20954f3f0eb"",
    ""owning_organization_url"": ""/v2/organizations/670702ab-b7e2-425b-92bd-f20954f3f0eb"",
    ""shared_organizations_url"": ""/v2/private_domains/4e335186-814f-4293-814a-fb042d4c89ff/shared_organizations""
  }
}";

            RetrievePrivateDomainResponse obj = Utilities.DeserializeJson<RetrievePrivateDomainResponse>(json);

            Assert.AreEqual("4e335186-814f-4293-814a-fb042d4c89ff", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/4e335186-814f-4293-814a-fb042d4c89ff", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:17Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("vcap.me", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("670702ab-b7e2-425b-92bd-f20954f3f0eb", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/670702ab-b7e2-425b-92bd-f20954f3f0eb", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/4e335186-814f-4293-814a-fb042d4c89ff/shared_organizations", TestUtil.ToTestableString(obj.SharedOrganizationsUrl), true);
        }

        [TestMethod]
        public void TestCreatePrivateDomainOwnedByGivenOrganizationResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""bb83b116-c635-4ef4-84e7-9fa7398a41f2"",
    ""url"": ""/v2/private_domains/bb83b116-c635-4ef4-84e7-9fa7398a41f2"",
    ""created_at"": ""2015-07-29T12:47:18Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""exmaple.com"",
    ""owning_organization_guid"": ""3e642b2b-d9b6-4d43-9a93-efb9c57e30b5"",
    ""owning_organization_url"": ""/v2/organizations/3e642b2b-d9b6-4d43-9a93-efb9c57e30b5"",
    ""shared_organizations_url"": ""/v2/private_domains/bb83b116-c635-4ef4-84e7-9fa7398a41f2/shared_organizations""
  }
}";

            CreatePrivateDomainOwnedByGivenOrganizationResponse obj = Utilities.DeserializeJson<CreatePrivateDomainOwnedByGivenOrganizationResponse>(json);

            Assert.AreEqual("bb83b116-c635-4ef4-84e7-9fa7398a41f2", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/bb83b116-c635-4ef4-84e7-9fa7398a41f2", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:18Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("exmaple.com", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("3e642b2b-d9b6-4d43-9a93-efb9c57e30b5", TestUtil.ToTestableString(obj.OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/3e642b2b-d9b6-4d43-9a93-efb9c57e30b5", TestUtil.ToTestableString(obj.OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/bb83b116-c635-4ef4-84e7-9fa7398a41f2/shared_organizations", TestUtil.ToTestableString(obj.SharedOrganizationsUrl), true);
        }

        [TestMethod]
        public void TestListAllPrivateDomainsResponse()
        {
            string json = @"{
  ""total_results"": 4,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""4e335186-814f-4293-814a-fb042d4c89ff"",
        ""url"": ""/v2/private_domains/4e335186-814f-4293-814a-fb042d4c89ff"",
        ""created_at"": ""2015-07-29T12:47:17Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""vcap.me"",
        ""owning_organization_guid"": ""670702ab-b7e2-425b-92bd-f20954f3f0eb"",
        ""owning_organization_url"": ""/v2/organizations/670702ab-b7e2-425b-92bd-f20954f3f0eb"",
        ""shared_organizations_url"": ""/v2/private_domains/4e335186-814f-4293-814a-fb042d4c89ff/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""1b337481-3111-49e2-8f1b-6e915ad116d7"",
        ""url"": ""/v2/private_domains/1b337481-3111-49e2-8f1b-6e915ad116d7"",
        ""created_at"": ""2015-07-29T12:47:18Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-17.example.com"",
        ""owning_organization_guid"": ""7c95fd15-1cff-4aa7-ae88-70844bec8081"",
        ""owning_organization_url"": ""/v2/organizations/7c95fd15-1cff-4aa7-ae88-70844bec8081"",
        ""shared_organizations_url"": ""/v2/private_domains/1b337481-3111-49e2-8f1b-6e915ad116d7/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""c7c5e6fa-dc03-4b23-aeb0-1b57ae2fd6ff"",
        ""url"": ""/v2/private_domains/c7c5e6fa-dc03-4b23-aeb0-1b57ae2fd6ff"",
        ""created_at"": ""2015-07-29T12:47:18Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-18.example.com"",
        ""owning_organization_guid"": ""29042c9c-21b2-4f44-a858-f76c0cc780a8"",
        ""owning_organization_url"": ""/v2/organizations/29042c9c-21b2-4f44-a858-f76c0cc780a8"",
        ""shared_organizations_url"": ""/v2/private_domains/c7c5e6fa-dc03-4b23-aeb0-1b57ae2fd6ff/shared_organizations""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""06197196-49df-4029-89ec-b7a6852ddffd"",
        ""url"": ""/v2/private_domains/06197196-49df-4029-89ec-b7a6852ddffd"",
        ""created_at"": ""2015-07-29T12:47:18Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-19.example.com"",
        ""owning_organization_guid"": ""900297ba-2ca2-4c11-a6f6-c0d49f3d7232"",
        ""owning_organization_url"": ""/v2/organizations/900297ba-2ca2-4c11-a6f6-c0d49f3d7232"",
        ""shared_organizations_url"": ""/v2/private_domains/06197196-49df-4029-89ec-b7a6852ddffd/shared_organizations""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllPrivateDomainsResponse> page = Utilities.DeserializePage<ListAllPrivateDomainsResponse>(json, null);

            Assert.AreEqual("4", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("4e335186-814f-4293-814a-fb042d4c89ff", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/4e335186-814f-4293-814a-fb042d4c89ff", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:17Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("vcap.me", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("670702ab-b7e2-425b-92bd-f20954f3f0eb", TestUtil.ToTestableString(page[0].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/670702ab-b7e2-425b-92bd-f20954f3f0eb", TestUtil.ToTestableString(page[0].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/4e335186-814f-4293-814a-fb042d4c89ff/shared_organizations", TestUtil.ToTestableString(page[0].SharedOrganizationsUrl), true);
            Assert.AreEqual("1b337481-3111-49e2-8f1b-6e915ad116d7", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/1b337481-3111-49e2-8f1b-6e915ad116d7", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:18Z", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-17.example.com", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("7c95fd15-1cff-4aa7-ae88-70844bec8081", TestUtil.ToTestableString(page[1].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/7c95fd15-1cff-4aa7-ae88-70844bec8081", TestUtil.ToTestableString(page[1].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/1b337481-3111-49e2-8f1b-6e915ad116d7/shared_organizations", TestUtil.ToTestableString(page[1].SharedOrganizationsUrl), true);
            Assert.AreEqual("c7c5e6fa-dc03-4b23-aeb0-1b57ae2fd6ff", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/c7c5e6fa-dc03-4b23-aeb0-1b57ae2fd6ff", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:18Z", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-18.example.com", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("29042c9c-21b2-4f44-a858-f76c0cc780a8", TestUtil.ToTestableString(page[2].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/29042c9c-21b2-4f44-a858-f76c0cc780a8", TestUtil.ToTestableString(page[2].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/c7c5e6fa-dc03-4b23-aeb0-1b57ae2fd6ff/shared_organizations", TestUtil.ToTestableString(page[2].SharedOrganizationsUrl), true);
            Assert.AreEqual("06197196-49df-4029-89ec-b7a6852ddffd", TestUtil.ToTestableString(page[3].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/private_domains/06197196-49df-4029-89ec-b7a6852ddffd", TestUtil.ToTestableString(page[3].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:18Z", TestUtil.ToTestableString(page[3].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[3].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("domain-19.example.com", TestUtil.ToTestableString(page[3].Name), true);
            Assert.AreEqual("900297ba-2ca2-4c11-a6f6-c0d49f3d7232", TestUtil.ToTestableString(page[3].OwningOrganizationGuid), true);
            Assert.AreEqual("/v2/organizations/900297ba-2ca2-4c11-a6f6-c0d49f3d7232", TestUtil.ToTestableString(page[3].OwningOrganizationUrl), true);
            Assert.AreEqual("/v2/private_domains/06197196-49df-4029-89ec-b7a6852ddffd/shared_organizations", TestUtil.ToTestableString(page[3].SharedOrganizationsUrl), true);
        }
    }
}
