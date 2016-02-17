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
        ""guid"": ""42b1cec9-9b84-4282-92e4-337afeefec30"",
        ""url"": ""/v2/config/running_security_groups/f00fd32a-437e-469f-ace2-812e0626455f"",
        ""created_at"": ""2016-02-11T13:20:55Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-2221"",
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
            Assert.AreEqual("42b1cec9-9b84-4282-92e4-337afeefec30", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/running_security_groups/f00fd32a-437e-469f-ace2-812e0626455f", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2221", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].StagingDefault), true);
        }

        [TestMethod]
        public void TestSetSecurityGroupAsDefaultForRunningAppsResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""de1a23b0-f0ba-46fb-839d-44438b996c2b"",
    ""url"": ""/v2/config/running_security_groups/eb3aa531-df1b-4ddd-bbf3-f19a6eff0bef"",
    ""created_at"": ""2016-02-11T13:20:55Z"",
    ""updated_at"": ""2016-02-11T13:20:55Z""
  },
  ""entity"": {
    ""name"": ""name-2216"",
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

            Assert.AreEqual("de1a23b0-f0ba-46fb-839d-44438b996c2b", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/config/running_security_groups/eb3aa531-df1b-4ddd-bbf3-f19a6eff0bef", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-2216", TestUtil.ToTestableString(obj.Name), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.RunningDefault), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.StagingDefault), true);
        }
    }
}
