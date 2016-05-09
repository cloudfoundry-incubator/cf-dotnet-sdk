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
    public class ServiceBrokersEndpoint
{
        [TestMethod]
        public void RetrieveServiceBrokerTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""f1cc80ea-21a6-484f-879c-feb240f6ba5f"",
    ""url"": ""/v2/service_brokers/d06939a0-f94d-4955-a993-15b816f447f2"",
    ""created_at"": ""2016-05-05T14:14:53Z"",
    ""updated_at"": ""2016-05-05T14:14:53Z""
  },
  ""entity"": {
    ""name"": ""name-230"",
    ""broker_url"": ""https://foo.com/url-44"",
    ""auth_username"": ""auth_username-26"",
    ""space_guid"": ""f1cc80ea-21a6-484f-879c-feb240f6ba5f""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceBrokers.RetrieveServiceBroker(guid).Result;


                Assert.AreEqual("f1cc80ea-21a6-484f-879c-feb240f6ba5f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_brokers/d06939a0-f94d-4955-a993-15b816f447f2", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:53Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-05-05T14:14:53Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-230", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("https://foo.com/url-44", TestUtil.ToTestableString(obj.BrokerUrl), true);
                Assert.AreEqual("auth_username-26", TestUtil.ToTestableString(obj.AuthUsername), true);
                Assert.AreEqual("f1cc80ea-21a6-484f-879c-feb240f6ba5f", TestUtil.ToTestableString(obj.SpaceGuid), true);

            }
        }

        [TestMethod]
        public void CreateServiceBrokerTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""78979dae-8247-4e07-b02a-fe6d1d81ddbf"",
    ""created_at"": ""2016-05-05T14:14:52Z"",
    ""updated_at"": null,
    ""url"": ""/v2/service_brokers/8dce51c0-93e6-4202-8fc5-77d962aecf6e""
  },
  ""entity"": {
    ""name"": ""service-broker-name"",
    ""broker_url"": ""https://broker.example.com"",
    ""auth_username"": ""admin"",
    ""space_guid"": null
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServiceBrokerRequest value = new CreateServiceBrokerRequest();


                var obj = cfClient.ServiceBrokers.CreateServiceBroker(value).Result;


                Assert.AreEqual("78979dae-8247-4e07-b02a-fe6d1d81ddbf", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-05-05T14:14:52Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("/v2/service_brokers/8dce51c0-93e6-4202-8fc5-77d962aecf6e", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("service-broker-name", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("https://broker.example.com", TestUtil.ToTestableString(obj.BrokerUrl), true);
                Assert.AreEqual("admin", TestUtil.ToTestableString(obj.AuthUsername), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.SpaceGuid), true);

            }
        }

        [TestMethod]
        public void DeleteServiceBrokerTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServiceBrokers.DeleteServiceBroker(guid).Wait();

            }
        }

        [TestMethod]
        public void ListAllServiceBrokersTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""362eccbf-0934-49cc-be40-91611662a08f"",
        ""url"": ""/v2/service_brokers/c5d725ed-3479-465a-9b02-270001a8604d"",
        ""created_at"": ""2016-05-05T14:14:52Z"",
        ""updated_at"": ""2016-05-05T14:14:52Z""
      },
      ""entity"": {
        ""name"": ""name-212"",
        ""broker_url"": ""https://foo.com/url-35"",
        ""auth_username"": ""auth_username-17"",
        ""space_guid"": ""362eccbf-0934-49cc-be40-91611662a08f""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""362eccbf-0934-49cc-be40-91611662a08f"",
        ""url"": ""/v2/service_brokers/c05f7a82-1cf3-4067-83c2-95e0e29631ec"",
        ""created_at"": ""2016-05-05T14:14:52Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-213"",
        ""broker_url"": ""https://foo.com/url-36"",
        ""auth_username"": ""auth_username-18"",
        ""space_guid"": null
      }
    },
    {
      ""metadata"": {
        ""guid"": ""362eccbf-0934-49cc-be40-91611662a08f"",
        ""url"": ""/v2/service_brokers/f1fdbffe-4879-4db8-b60e-45bec3d687b8"",
        ""created_at"": ""2016-05-05T14:14:52Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-214"",
        ""broker_url"": ""https://foo.com/url-37"",
        ""auth_username"": ""auth_username-19"",
        ""space_guid"": null
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceBrokers.ListAllServiceBrokers().Result;

                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("362eccbf-0934-49cc-be40-91611662a08f", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_brokers/c5d725ed-3479-465a-9b02-270001a8604d", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:52Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-05-05T14:14:52Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-212", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("https://foo.com/url-35", TestUtil.ToTestableString(obj[0].BrokerUrl), true);
                Assert.AreEqual("auth_username-17", TestUtil.ToTestableString(obj[0].AuthUsername), true);
                Assert.AreEqual("362eccbf-0934-49cc-be40-91611662a08f", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("362eccbf-0934-49cc-be40-91611662a08f", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_brokers/c05f7a82-1cf3-4067-83c2-95e0e29631ec", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:52Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-213", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("https://foo.com/url-36", TestUtil.ToTestableString(obj[1].BrokerUrl), true);
                Assert.AreEqual("auth_username-18", TestUtil.ToTestableString(obj[1].AuthUsername), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].SpaceGuid), true);
                Assert.AreEqual("362eccbf-0934-49cc-be40-91611662a08f", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_brokers/f1fdbffe-4879-4db8-b60e-45bec3d687b8", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-05-05T14:14:52Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-214", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("https://foo.com/url-37", TestUtil.ToTestableString(obj[2].BrokerUrl), true);
                Assert.AreEqual("auth_username-19", TestUtil.ToTestableString(obj[2].AuthUsername), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].SpaceGuid), true);

            }
        }

        [TestMethod]
        public void UpdateServiceBrokerTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""c9f6a6aa-f226-4af8-a668-e543ff67d6fd"",
    ""created_at"": ""2016-05-05T14:14:52Z"",
    ""updated_at"": ""2016-05-05T14:14:52Z"",
    ""url"": ""/v2/service_brokers/3e0fab3f-5f84-4b76-a48c-353f2e3a99f7""
  },
  ""entity"": {
    ""name"": ""name-206"",
    ""broker_url"": ""https://mybroker.example.com"",
    ""auth_username"": ""admin-user"",
    ""space_guid"": ""c9f6a6aa-f226-4af8-a668-e543ff67d6fd""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateServiceBrokerRequest value = new UpdateServiceBrokerRequest();


                var obj = cfClient.ServiceBrokers.UpdateServiceBroker(guid, value).Result;


                Assert.AreEqual("c9f6a6aa-f226-4af8-a668-e543ff67d6fd", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("2016-05-05T14:14:52Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-05-05T14:14:52Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("/v2/service_brokers/3e0fab3f-5f84-4b76-a48c-353f2e3a99f7", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("name-206", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("https://mybroker.example.com", TestUtil.ToTestableString(obj.BrokerUrl), true);
                Assert.AreEqual("admin-user", TestUtil.ToTestableString(obj.AuthUsername), true);
                Assert.AreEqual("c9f6a6aa-f226-4af8-a668-e543ff67d6fd", TestUtil.ToTestableString(obj.SpaceGuid), true);

            }
        }

    }
}