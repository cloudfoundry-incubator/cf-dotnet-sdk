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
    public class StacksEndpoint
{
        [TestMethod]
        public void ListAllStacksTest()
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
        ""guid"": ""44fd604b-c698-414f-ae80-3de25c42f572"",
        ""url"": ""/v2/stacks/3e9c95e9-df2c-47b4-8068-a11b1dfbeddd"",
        ""created_at"": ""2016-04-11T13:32:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""cflinuxfs2"",
        ""description"": ""cflinuxfs2""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""44fd604b-c698-414f-ae80-3de25c42f572"",
        ""url"": ""/v2/stacks/34090e48-9d46-45f4-bfe0-97942ddfa111"",
        ""created_at"": ""2016-04-11T13:32:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""default-stack-name"",
        ""description"": ""default-stack-description""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""44fd604b-c698-414f-ae80-3de25c42f572"",
        ""url"": ""/v2/stacks/f2242b0d-a7f3-4714-825c-02ce9296398e"",
        ""created_at"": ""2016-04-11T13:32:56Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""cider"",
        ""description"": ""cider-description""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Stacks.ListAllStacks().Result;

                Assert.AreEqual("3", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("44fd604b-c698-414f-ae80-3de25c42f572", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/3e9c95e9-df2c-47b4-8068-a11b1dfbeddd", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:32:56Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj[0].Description), true);
                Assert.AreEqual("44fd604b-c698-414f-ae80-3de25c42f572", TestUtil.ToTestableString(obj[1].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/34090e48-9d46-45f4-bfe0-97942ddfa111", TestUtil.ToTestableString(obj[1].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:32:56Z", TestUtil.ToTestableString(obj[1].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[1].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("default-stack-name", TestUtil.ToTestableString(obj[1].Name), true);
                Assert.AreEqual("default-stack-description", TestUtil.ToTestableString(obj[1].Description), true);
                Assert.AreEqual("44fd604b-c698-414f-ae80-3de25c42f572", TestUtil.ToTestableString(obj[2].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/f2242b0d-a7f3-4714-825c-02ce9296398e", TestUtil.ToTestableString(obj[2].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:32:56Z", TestUtil.ToTestableString(obj[2].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[2].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("cider", TestUtil.ToTestableString(obj[2].Name), true);
                Assert.AreEqual("cider-description", TestUtil.ToTestableString(obj[2].Description), true);

            }
        }

        [TestMethod]
        public void RetrieveStackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""9edadb74-9f75-41e6-8c2a-6613e363bfe9"",
    ""url"": ""/v2/stacks/3e9c95e9-df2c-47b4-8068-a11b1dfbeddd"",
    ""created_at"": ""2016-04-11T13:32:56Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""cflinuxfs2"",
    ""description"": ""cflinuxfs2""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Stacks.RetrieveStack(guid).Result;


                Assert.AreEqual("9edadb74-9f75-41e6-8c2a-6613e363bfe9", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/3e9c95e9-df2c-47b4-8068-a11b1dfbeddd", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:32:56Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("cflinuxfs2", TestUtil.ToTestableString(obj.Description), true);

            }
        }

        [TestMethod]
        public void CreateStackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""d7b72ecd-5ec0-471e-ba76-86da40870041"",
    ""url"": ""/v2/stacks/e2b85c59-b893-44d0-877e-964e7a552a0b"",
    ""created_at"": ""2016-04-11T13:33:04Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""example_stack"",
    ""description"": ""Description for the example stack""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateStackRequest value = new CreateStackRequest();


                var obj = cfClient.Stacks.CreateStack(value).Result;


                Assert.AreEqual("d7b72ecd-5ec0-471e-ba76-86da40870041", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/stacks/e2b85c59-b893-44d0-877e-964e7a552a0b", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:04Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("example_stack", TestUtil.ToTestableString(obj.Name), true);
                Assert.AreEqual("Description for the example stack", TestUtil.ToTestableString(obj.Description), true);

            }
        }

        [TestMethod]
        public void DeleteStackTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.Stacks.DeleteStack(guid).Wait();

            }
        }

    }
}