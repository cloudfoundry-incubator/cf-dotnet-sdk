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
    public class BuildpacksTest
    {


        [TestMethod]
        public void TestChangePositionOfBuildpackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""8a9fa8d7-0b04-4259-94d6-b0d4913ea233"",
    ""url"": ""/v2/buildpacks/8a9fa8d7-0b04-4259-94d6-b0d4913ea233"",
    ""created_at"": ""2015-07-29T12:47:16Z"",
    ""updated_at"": ""2015-07-29T12:47:16Z""
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 3,
    ""enabled"": true,
    ""locked"": false,
    ""filename"": ""name-265""
  }
}";

            ChangePositionOfBuildpackResponse obj = Utilities.DeserializeJson<ChangePositionOfBuildpackResponse>(json);

            Assert.AreEqual("8a9fa8d7-0b04-4259-94d6-b0d4913ea233", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/8a9fa8d7-0b04-4259-94d6-b0d4913ea233", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:16Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-07-29T12:47:16Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("3", TestUtil.ToTestableString(obj.Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
            Assert.AreEqual("name-265", TestUtil.ToTestableString(obj.Filename), true);
        }

        [TestMethod]
        public void TestLockOrUnlockBuildpackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""ea4fcaa8-01f0-4f6b-9e9f-65af7d598a46"",
    ""url"": ""/v2/buildpacks/ea4fcaa8-01f0-4f6b-9e9f-65af7d598a46"",
    ""created_at"": ""2015-07-29T12:47:16Z"",
    ""updated_at"": ""2015-07-29T12:47:16Z""
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 1,
    ""enabled"": true,
    ""locked"": true,
    ""filename"": ""name-259""
  }
}";

            LockOrUnlockBuildpackResponse obj = Utilities.DeserializeJson<LockOrUnlockBuildpackResponse>(json);

            Assert.AreEqual("ea4fcaa8-01f0-4f6b-9e9f-65af7d598a46", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/ea4fcaa8-01f0-4f6b-9e9f-65af7d598a46", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:16Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-07-29T12:47:16Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Locked), true);
            Assert.AreEqual("name-259", TestUtil.ToTestableString(obj.Filename), true);
        }

        [TestMethod]
        public void TestEnableOrDisableBuildpackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""53179e7b-826c-47b9-81ab-d5522492ea72"",
    ""url"": ""/v2/buildpacks/53179e7b-826c-47b9-81ab-d5522492ea72"",
    ""created_at"": ""2015-07-29T12:47:16Z"",
    ""updated_at"": ""2015-07-29T12:47:16Z""
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 1,
    ""enabled"": false,
    ""locked"": false,
    ""filename"": ""name-262""
  }
}";

            EnableOrDisableBuildpackResponse obj = Utilities.DeserializeJson<EnableOrDisableBuildpackResponse>(json);

            Assert.AreEqual("53179e7b-826c-47b9-81ab-d5522492ea72", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/53179e7b-826c-47b9-81ab-d5522492ea72", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:16Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-07-29T12:47:16Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
            Assert.AreEqual("name-262", TestUtil.ToTestableString(obj.Filename), true);
        }

        [TestMethod]
        public void TestRetrieveBuildpackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""6b15ac5e-2937-494d-940d-918bac90eb49"",
    ""url"": ""/v2/buildpacks/6b15ac5e-2937-494d-940d-918bac90eb49"",
    ""created_at"": ""2015-07-29T12:47:16Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""name_1"",
    ""position"": 1,
    ""enabled"": true,
    ""locked"": false,
    ""filename"": ""name-256""
  }
}";

            RetrieveBuildpackResponse obj = Utilities.DeserializeJson<RetrieveBuildpackResponse>(json);

            Assert.AreEqual("6b15ac5e-2937-494d-940d-918bac90eb49", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/6b15ac5e-2937-494d-940d-918bac90eb49", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:16Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_1", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
            Assert.AreEqual("name-256", TestUtil.ToTestableString(obj.Filename), true);
        }

        [TestMethod]
        public void TestCreatesAdminBuildpackResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""a9873846-2ecc-4995-8ec1-4bea46d251ec"",
    ""url"": ""/v2/buildpacks/a9873846-2ecc-4995-8ec1-4bea46d251ec"",
    ""created_at"": ""2015-07-29T12:47:16Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""name"": ""Golang_buildpack"",
    ""position"": 1,
    ""enabled"": true,
    ""locked"": false,
    ""filename"": null
  }
}";

            CreatesAdminBuildpackResponse obj = Utilities.DeserializeJson<CreatesAdminBuildpackResponse>(json);

            Assert.AreEqual("a9873846-2ecc-4995-8ec1-4bea46d251ec", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/a9873846-2ecc-4995-8ec1-4bea46d251ec", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:16Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("Golang_buildpack", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(obj.Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Locked), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Filename), true);
        }

        [TestMethod]
        public void TestListAllBuildpacksResponse()
        {
            string json = @"{
  ""total_results"": 3,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""f5f02b80-4acf-4ee1-8d3f-357d51c12bd5"",
        ""url"": ""/v2/buildpacks/f5f02b80-4acf-4ee1-8d3f-357d51c12bd5"",
        ""created_at"": ""2015-07-29T12:47:16Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name_1"",
        ""position"": 1,
        ""enabled"": true,
        ""locked"": false,
        ""filename"": ""name-247""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""2891aaa9-bd44-4a06-b852-a8c876772918"",
        ""url"": ""/v2/buildpacks/2891aaa9-bd44-4a06-b852-a8c876772918"",
        ""created_at"": ""2015-07-29T12:47:16Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name_2"",
        ""position"": 2,
        ""enabled"": true,
        ""locked"": false,
        ""filename"": ""name-248""
      }
    },
    {
      ""metadata"": {
        ""guid"": ""de770d7b-0c3d-47a9-a36c-d5e5c8e1a589"",
        ""url"": ""/v2/buildpacks/de770d7b-0c3d-47a9-a36c-d5e5c8e1a589"",
        ""created_at"": ""2015-07-29T12:47:16Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name_3"",
        ""position"": 3,
        ""enabled"": true,
        ""locked"": false,
        ""filename"": ""name-249""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllBuildpacksResponse> page = Utilities.DeserializePage<ListAllBuildpacksResponse>(json, null);

            Assert.AreEqual("3", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("f5f02b80-4acf-4ee1-8d3f-357d51c12bd5", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/f5f02b80-4acf-4ee1-8d3f-357d51c12bd5", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:16Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_1", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page[0].Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Locked), true);
            Assert.AreEqual("name-247", TestUtil.ToTestableString(page[0].Filename), true);
            Assert.AreEqual("2891aaa9-bd44-4a06-b852-a8c876772918", TestUtil.ToTestableString(page[1].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/2891aaa9-bd44-4a06-b852-a8c876772918", TestUtil.ToTestableString(page[1].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:16Z", TestUtil.ToTestableString(page[1].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_2", TestUtil.ToTestableString(page[1].Name), true);
            Assert.AreEqual("2", TestUtil.ToTestableString(page[1].Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[1].Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[1].Locked), true);
            Assert.AreEqual("name-248", TestUtil.ToTestableString(page[1].Filename), true);
            Assert.AreEqual("de770d7b-0c3d-47a9-a36c-d5e5c8e1a589", TestUtil.ToTestableString(page[2].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/buildpacks/de770d7b-0c3d-47a9-a36c-d5e5c8e1a589", TestUtil.ToTestableString(page[2].EntityMetadata.Url), true);
            Assert.AreEqual("2015-07-29T12:47:16Z", TestUtil.ToTestableString(page[2].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[2].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name_3", TestUtil.ToTestableString(page[2].Name), true);
            Assert.AreEqual("3", TestUtil.ToTestableString(page[2].Position), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[2].Enabled), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[2].Locked), true);
            Assert.AreEqual("name-249", TestUtil.ToTestableString(page[2].Filename), true);
        }
    }
}
