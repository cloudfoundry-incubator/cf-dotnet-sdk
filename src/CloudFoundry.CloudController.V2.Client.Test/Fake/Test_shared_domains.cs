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
    public class SharedDomainsEndpoint
{
        [TestMethod]
        public void FilterSharedDomainsByNameTest()
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
        ""guid"": ""fe86e084-8eb8-4b15-b312-be5c0e96126f"",
        ""url"": ""/v2/shared_domains/fe86e084-8eb8-4b15-b312-be5c0e96126f"",
        ""created_at"": ""2015-04-10T20:04:35+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""shared-domain.com""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SharedDomains.FilterSharedDomainsByName().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("fe86e084-8eb8-4b15-b312-be5c0e96126f", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/fe86e084-8eb8-4b15-b312-be5c0e96126f", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:35+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("shared-domain.com", TestUtil.ToTestableString(obj[0].Name), true);

            }
        }

        [TestMethod]
        public void CreateSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""be188d0a-8b88-4bf2-8a3f-b6f666d382b2"",
    ""url"": ""/v2/shared_domains/be188d0a-8b88-4bf2-8a3f-b6f666d382b2"",
    ""created_at"": ""2015-04-10T20:04:35+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example.com""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateSharedDomainRequest value = new CreateSharedDomainRequest();


                var obj = cfClient.SharedDomains.CreateSharedDomain(value).Result;


                Assert.AreEqual("be188d0a-8b88-4bf2-8a3f-b6f666d382b2", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/be188d0a-8b88-4bf2-8a3f-b6f666d382b2", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:35+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("example.com", TestUtil.ToTestableString(obj.Name), true);

            }
        }

        [TestMethod]
        public void DeleteSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.SharedDomains.DeleteSharedDomain(guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllSharedDomainsTest()
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
        ""guid"": ""8c827319-3606-4bae-9e9b-6816cde64a57"",
        ""url"": ""/v2/shared_domains/8c827319-3606-4bae-9e9b-6816cde64a57"",
        ""created_at"": ""2015-04-10T20:04:27+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain1.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""d616b632-3803-400c-b732-46a3709542fc"",
        ""url"": ""/v2/shared_domains/d616b632-3803-400c-b732-46a3709542fc"",
        ""created_at"": ""2015-04-10T20:04:27+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""customer-app-domain2.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""77fa1559-6d11-424c-97c1-e2c5165f902c"",
        ""url"": ""/v2/shared_domains/77fa1559-6d11-424c-97c1-e2c5165f902c"",
        ""created_at"": ""2015-04-10T20:04:34+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-28.example.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""ef8d39eb-7171-4f87-bd06-ea0ff9652ce2"",
        ""url"": ""/v2/shared_domains/ef8d39eb-7171-4f87-bd06-ea0ff9652ce2"",
        ""created_at"": ""2015-04-10T20:04:34+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-29.example.com""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""eb851a96-114b-4212-b65d-e621b6caeb7f"",
        ""url"": ""/v2/shared_domains/eb851a96-114b-4212-b65d-e621b6caeb7f"",
        ""created_at"": ""2015-04-10T20:04:34+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""domain-30.example.com""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.SharedDomains.ListAllSharedDomains().Result;

                Assert.AreEqual("5", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("8c827319-3606-4bae-9e9b-6816cde64a57", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/8c827319-3606-4bae-9e9b-6816cde64a57", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:27+00:00", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("d616b632-3803-400c-b732-46a3709542fc", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/d616b632-3803-400c-b732-46a3709542fc", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:27+00:00", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain2.com", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("77fa1559-6d11-424c-97c1-e2c5165f902c", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/77fa1559-6d11-424c-97c1-e2c5165f902c", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:34+00:00", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-28.example.com", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("ef8d39eb-7171-4f87-bd06-ea0ff9652ce2", TestUtil.ToTestableString(obj[3].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/ef8d39eb-7171-4f87-bd06-ea0ff9652ce2", TestUtil.ToTestableString(obj[3].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:34+00:00", TestUtil.ToTestableString(obj[3].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[3].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-29.example.com", TestUtil.ToTestableString(obj[3].Name), true);
                Assert.AreEqual("eb851a96-114b-4212-b65d-e621b6caeb7f", TestUtil.ToTestableString(obj[4].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/eb851a96-114b-4212-b65d-e621b6caeb7f", TestUtil.ToTestableString(obj[4].EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:34+00:00", TestUtil.ToTestableString(obj[4].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[4].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("domain-30.example.com", TestUtil.ToTestableString(obj[4].Name), true);

            }
        }

        [TestMethod]
        public void RetrieveSharedDomainTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""8c827319-3606-4bae-9e9b-6816cde64a57"",
    ""url"": ""/v2/shared_domains/8c827319-3606-4bae-9e9b-6816cde64a57"",
    ""created_at"": ""2015-04-10T20:04:27+00:00"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""customer-app-domain1.com""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.SharedDomains.RetrieveSharedDomain(guid).Result;


                Assert.AreEqual("8c827319-3606-4bae-9e9b-6816cde64a57", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/shared_domains/8c827319-3606-4bae-9e9b-6816cde64a57", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2015-04-10T20:04:27+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("customer-app-domain1.com", TestUtil.ToTestableString(obj.Name), true);

            }
        }

    }
}