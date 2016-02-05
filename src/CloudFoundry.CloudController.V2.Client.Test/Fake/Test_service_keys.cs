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
    public class ServiceKeysEndpoint
{
        [TestMethod]
        public void DeleteServiceKeyTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.ServiceKeys.DeleteServiceKey(guid).Wait();

            }
        }

        [TestMethod]
        public void RetrieveServiceKeyTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""9837b905-71aa-4a56-9593-f725de9ac4a3"",
    ""url"": ""/v2/service_keys/9837b905-71aa-4a56-9593-f725de9ac4a3"",
    ""created_at"": ""2016-02-05T12:14:48Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1725"",
    ""service_instance_guid"": ""b691654b-7864-4b3b-9e0d-54616aa972e7"",
    ""credentials"": {
      ""creds-key-441"": ""creds-val-441""
    },
    ""service_instance_url"": ""/v2/service_instances/b691654b-7864-4b3b-9e0d-54616aa972e7""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.ServiceKeys.RetrieveServiceKey(guid).Result;


                Assert.AreEqual("9837b905-71aa-4a56-9593-f725de9ac4a3", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_keys/9837b905-71aa-4a56-9593-f725de9ac4a3", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-05T12:14:48Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1725", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("b691654b-7864-4b3b-9e0d-54616aa972e7", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("/v2/service_instances/b691654b-7864-4b3b-9e0d-54616aa972e7", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void CreateServiceKeyTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""e3159ab6-2234-4b7b-a10e-74543305622c"",
    ""url"": ""/v2/service_keys/e3159ab6-2234-4b7b-a10e-74543305622c"",
    ""created_at"": ""2016-02-05T12:14:48Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name-1738"",
    ""service_instance_guid"": ""185ddc10-7cf0-49ac-94b2-5c7a8dc9f8c4"",
    ""credentials"": {
      ""creds-key-445"": ""creds-val-445""
    },
    ""service_instance_url"": ""/v2/service_instances/185ddc10-7cf0-49ac-94b2-5c7a8dc9f8c4""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateServiceKeyRequest value = new CreateServiceKeyRequest();


                var obj = cfClient.ServiceKeys.CreateServiceKey(value).Result;


                Assert.AreEqual("e3159ab6-2234-4b7b-a10e-74543305622c", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_keys/e3159ab6-2234-4b7b-a10e-74543305622c", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-05T12:14:48Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1738", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("185ddc10-7cf0-49ac-94b2-5c7a8dc9f8c4", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("/v2/service_instances/185ddc10-7cf0-49ac-94b2-5c7a8dc9f8c4", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);

            }
        }

        [TestMethod]
        public void ListAllServiceKeysTest()
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
        ""guid"": ""b226fd70-5bfa-4cde-996d-cdec1f69ec23"",
        ""url"": ""/v2/service_keys/b226fd70-5bfa-4cde-996d-cdec1f69ec23"",
        ""created_at"": ""2016-02-05T12:14:48Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1712"",
        ""service_instance_guid"": ""b38c706b-6684-4ffd-9ba6-b35f5d659460"",
        ""credentials"": {
          ""creds-key-436"": ""creds-val-436""
        },
        ""service_instance_url"": ""/v2/service_instances/b38c706b-6684-4ffd-9ba6-b35f5d659460""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.ServiceKeys.ListAllServiceKeys().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("b226fd70-5bfa-4cde-996d-cdec1f69ec23", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/service_keys/b226fd70-5bfa-4cde-996d-cdec1f69ec23", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-02-05T12:14:48Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-1712", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("b38c706b-6684-4ffd-9ba6-b35f5d659460", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("/v2/service_instances/b38c706b-6684-4ffd-9ba6-b35f5d659460", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);

            }
        }

    }
}