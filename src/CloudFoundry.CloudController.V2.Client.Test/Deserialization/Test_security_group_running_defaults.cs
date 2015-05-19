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
    public class SecurityGroupRunningDefaultsTest
    {


        [TestMethod]
        public void TestSetSecurityGroupAsDefaultForRunningAppsResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""b809577b-e391-468d-8b41-6e4379a9852f"",
    ""url"": ""/v2/config/running_security_groups/b809577b-e391-468d-8b41-6e4379a9852f"",
    ""created_at"": ""2015-05-19T15:27:02+00:00"",
    ""updated_at"": ""2015-05-19T15:27:02+00:00""
  },
  ""entity"": {
    ""name"": ""name-28"",
    ""rules"": [
      {
        ""protocol"": ""udp"",
        ""ports"": ""8080"",
        ""destination"": ""198.41.191.47/1""
      }
    ],
    ""running_default"": true,
    ""staging_default"": false
  }
}";

            SetSecurityGroupAsDefaultForRunningAppsResponse obj = Utilities.DeserializeJson<SetSecurityGroupAsDefaultForRunningAppsResponse>(json);

            Assert.AreEqual("b809577b-e391-468d-8b41-6e4379a9852f", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/running_security_groups/b809577b-e391-468d-8b41-6e4379a9852f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2015-05-19T15:27:02+00:00", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-28", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
        }

        [TestMethod]
        public void TestReturnSecurityGroupsUsedForRunningAppsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""f1415ae7-5d9f-43c6-be4c-6274d6aafa35"",
        ""url"": ""/v2/config/running_security_groups/f1415ae7-5d9f-43c6-be4c-6274d6aafa35"",
        ""created_at"": ""2015-05-19T15:27:02+00:00"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-27"",
        ""rules"": [
          {
            ""protocol"": ""udp"",
            ""ports"": ""8080"",
            ""destination"": ""198.41.191.47/1""
          }
        ],
        ""running_default"": true,
        ""staging_default"": false
      }
    }
  ]
}";

            PagedResponseCollection<ReturnSecurityGroupsUsedForRunningAppsResponse> page = Utilities.DeserializePage<ReturnSecurityGroupsUsedForRunningAppsResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("f1415ae7-5d9f-43c6-be4c-6274d6aafa35", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/running_security_groups/f1415ae7-5d9f-43c6-be4c-6274d6aafa35", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2015-05-19T15:27:02+00:00", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-27", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].StagingDefault), true);
        }
    }
}
