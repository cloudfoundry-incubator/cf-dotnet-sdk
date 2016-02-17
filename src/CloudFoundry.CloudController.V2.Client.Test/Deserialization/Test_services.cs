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
    public class ServicesTest
    {


        [TestMethod]
        public void TestRetrieveServiceResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""b79b521c-b25b-40b5-98d6-36e30762e32a"",
    ""url"": ""/v2/services/db236508-2887-46c6-8cd9-ffdc1f1c136f"",
    ""created_at"": ""2016-02-11T13:20:32Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""label-28"",
    ""provider"": null,
    ""url"": null,
    ""description"": ""desc-63"",
    ""long_description"": null,
    ""version"": null,
    ""info_url"": null,
    ""active"": true,
    ""bindable"": true,
    ""unique_id"": ""a825ddb4-4902-4ea8-9eb9-4fdb80b2827a"",
    ""extra"": null,
    ""tags"": [

    ],
    ""requires"": [

    ],
    ""documentation_url"": null,
    ""service_broker_guid"": ""b79b521c-b25b-40b5-98d6-36e30762e32a"",
    ""plan_updateable"": false,
    ""service_plans_url"": ""/v2/services/db236508-2887-46c6-8cd9-ffdc1f1c136f/service_plans""
  }
}";

            RetrieveServiceResponse obj = Utilities.DeserializeJson<RetrieveServiceResponse>(json);

            Assert.AreEqual("b79b521c-b25b-40b5-98d6-36e30762e32a", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/db236508-2887-46c6-8cd9-ffdc1f1c136f", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:32Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-28", TestUtil.ToTestableString(obj.Label), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Provider), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Url), true);
            Assert.AreEqual("desc-63", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.LongDescription), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.InfoUrl), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Bindable), true);
            Assert.AreEqual("a825ddb4-4902-4ea8-9eb9-4fdb80b2827a", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DocumentationUrl), true);
            Assert.AreEqual("b79b521c-b25b-40b5-98d6-36e30762e32a", TestUtil.ToTestableString(obj.ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.PlanUpdateable), true);
            Assert.AreEqual("/v2/services/db236508-2887-46c6-8cd9-ffdc1f1c136f/service_plans", TestUtil.ToTestableString(obj.ServicePlansUrl), true);
        }

        [TestMethod]
        public void TestListAllServicesResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""6becabd1-40ae-4743-b33d-639994727e4f"",
        ""url"": ""/v2/services/07265ace-1ff4-40b3-9779-5b6fe89ff1dd"",
        ""created_at"": ""2016-02-11T13:20:32Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""label"": ""label-29"",
        ""provider"": null,
        ""url"": null,
        ""description"": ""desc-64"",
        ""long_description"": null,
        ""version"": null,
        ""info_url"": null,
        ""active"": true,
        ""bindable"": true,
        ""unique_id"": ""e99ac008-54aa-4131-9acb-8c42b43e0133"",
        ""extra"": null,
        ""tags"": [

        ],
        ""requires"": [

        ],
        ""documentation_url"": null,
        ""service_broker_guid"": ""6becabd1-40ae-4743-b33d-639994727e4f"",
        ""plan_updateable"": false,
        ""service_plans_url"": ""/v2/services/07265ace-1ff4-40b3-9779-5b6fe89ff1dd/service_plans""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServicesResponse> page = Utilities.DeserializePage<ListAllServicesResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("6becabd1-40ae-4743-b33d-639994727e4f", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/07265ace-1ff4-40b3-9779-5b6fe89ff1dd", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:32Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("label-29", TestUtil.ToTestableString(page[0].Label), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Provider), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Url), true);
            Assert.AreEqual("desc-64", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].LongDescription), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].InfoUrl), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Bindable), true);
            Assert.AreEqual("e99ac008-54aa-4131-9acb-8c42b43e0133", TestUtil.ToTestableString(page[0].UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].DocumentationUrl), true);
            Assert.AreEqual("6becabd1-40ae-4743-b33d-639994727e4f", TestUtil.ToTestableString(page[0].ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].PlanUpdateable), true);
            Assert.AreEqual("/v2/services/07265ace-1ff4-40b3-9779-5b6fe89ff1dd/service_plans", TestUtil.ToTestableString(page[0].ServicePlansUrl), true);
        }

        [TestMethod]
        public void TestListAllServicePlansForServiceResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""ca2cf1af-d8a8-4592-9136-7f12dfbce1e6"",
        ""url"": ""/v2/service_plans/f8ec9a8f-587d-4984-9049-100f3a2b074f"",
        ""created_at"": ""2016-02-11T13:20:32Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""name"": ""name-1164"",
        ""free"": false,
        ""description"": ""desc-69"",
        ""service_guid"": ""ca2cf1af-d8a8-4592-9136-7f12dfbce1e6"",
        ""extra"": null,
        ""unique_id"": ""4ae03f06-e48f-4f44-9232-9ae1a7a91c03"",
        ""public"": true,
        ""active"": true,
        ""service_url"": ""/v2/services/ce370e63-4022-4498-bfb5-3f3ad8d0a38f"",
        ""service_instances_url"": ""/v2/service_plans/f8ec9a8f-587d-4984-9049-100f3a2b074f/service_instances""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServicePlansForServiceResponse> page = Utilities.DeserializePage<ListAllServicePlansForServiceResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("ca2cf1af-d8a8-4592-9136-7f12dfbce1e6", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_plans/f8ec9a8f-587d-4984-9049-100f3a2b074f", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:32Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("name-1164", TestUtil.ToTestableString(page[0].Name), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(page[0].Free), true);
            Assert.AreEqual("desc-69", TestUtil.ToTestableString(page[0].Description), true);
            Assert.AreEqual("ca2cf1af-d8a8-4592-9136-7f12dfbce1e6", TestUtil.ToTestableString(page[0].ServiceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Extra), true);
            Assert.AreEqual("4ae03f06-e48f-4f44-9232-9ae1a7a91c03", TestUtil.ToTestableString(page[0].UniqueId), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Public), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(page[0].Active), true);
            Assert.AreEqual("/v2/services/ce370e63-4022-4498-bfb5-3f3ad8d0a38f", TestUtil.ToTestableString(page[0].ServiceUrl), true);
            Assert.AreEqual("/v2/service_plans/f8ec9a8f-587d-4984-9049-100f3a2b074f/service_instances", TestUtil.ToTestableString(page[0].ServiceInstancesUrl), true);
        }

        [TestMethod]
        public void TestCreateServiceDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""aca9366f-d245-417a-af02-d76e185db2dd"",
    ""url"": ""/v2/services/e91cb21e-fd18-4040-a6e0-ad5d0e6ddc07"",
    ""created_at"": ""2016-02-11T13:20:32Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""label"": ""SomeMysqlService"",
    ""provider"": ""MySql Provider"",
    ""url"": ""http://myql.provider.com"",
    ""description"": ""Mysql stores things for you"",
    ""long_description"": null,
    ""version"": ""2.0"",
    ""info_url"": null,
    ""active"": false,
    ""bindable"": true,
    ""unique_id"": null,
    ""extra"": null,
    ""tags"": [

    ],
    ""requires"": [

    ],
    ""documentation_url"": null,
    ""service_broker_guid"": null,
    ""plan_updateable"": false,
    ""service_plans_url"": ""/v2/services/e91cb21e-fd18-4040-a6e0-ad5d0e6ddc07/service_plans""
  }
}";

            CreateServiceDeprecatedResponse obj = Utilities.DeserializeJson<CreateServiceDeprecatedResponse>(json);

            Assert.AreEqual("aca9366f-d245-417a-af02-d76e185db2dd", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/e91cb21e-fd18-4040-a6e0-ad5d0e6ddc07", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:32Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("SomeMysqlService", TestUtil.ToTestableString(obj.Label), true);
            Assert.AreEqual("MySql Provider", TestUtil.ToTestableString(obj.Provider), true);
            Assert.AreEqual("http://myql.provider.com", TestUtil.ToTestableString(obj.Url), true);
            Assert.AreEqual("Mysql stores things for you", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.LongDescription), true);
            Assert.AreEqual("2.0", TestUtil.ToTestableString(obj.Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.InfoUrl), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Bindable), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DocumentationUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.PlanUpdateable), true);
            Assert.AreEqual("/v2/services/e91cb21e-fd18-4040-a6e0-ad5d0e6ddc07/service_plans", TestUtil.ToTestableString(obj.ServicePlansUrl), true);
        }

        [TestMethod]
        public void TestUpdateServiceDeprecatedResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""d0ae7fae-d62d-4f44-b151-637d436e2c48"",
    ""url"": ""/v2/services/3f05d68d-10b5-4012-b3aa-1f687ce85fe4"",
    ""created_at"": ""2016-02-11T13:20:32Z"",
    ""updated_at"": ""2016-02-11T13:20:32Z""
  },
  ""entity"": {
    ""label"": ""SomeMysqlService"",
    ""provider"": ""MySql Provider"",
    ""url"": ""http://myql.provider.com"",
    ""description"": ""Mysql stores things for you"",
    ""long_description"": null,
    ""version"": ""2.0"",
    ""info_url"": null,
    ""active"": true,
    ""bindable"": true,
    ""unique_id"": ""d09e9965-5db2-4242-8ade-896a145ead64"",
    ""extra"": null,
    ""tags"": [

    ],
    ""requires"": [

    ],
    ""documentation_url"": null,
    ""service_broker_guid"": ""d0ae7fae-d62d-4f44-b151-637d436e2c48"",
    ""plan_updateable"": false,
    ""service_plans_url"": ""/v2/services/3f05d68d-10b5-4012-b3aa-1f687ce85fe4/service_plans""
  }
}";

            UpdateServiceDeprecatedResponse obj = Utilities.DeserializeJson<UpdateServiceDeprecatedResponse>(json);

            Assert.AreEqual("d0ae7fae-d62d-4f44-b151-637d436e2c48", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/services/3f05d68d-10b5-4012-b3aa-1f687ce85fe4", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2016-02-11T13:20:32Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2016-02-11T13:20:32Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("SomeMysqlService", TestUtil.ToTestableString(obj.Label), true);
            Assert.AreEqual("MySql Provider", TestUtil.ToTestableString(obj.Provider), true);
            Assert.AreEqual("http://myql.provider.com", TestUtil.ToTestableString(obj.Url), true);
            Assert.AreEqual("Mysql stores things for you", TestUtil.ToTestableString(obj.Description), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.LongDescription), true);
            Assert.AreEqual("2.0", TestUtil.ToTestableString(obj.Version), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.InfoUrl), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Active), true);
            Assert.AreEqual("true", TestUtil.ToTestableString(obj.Bindable), true);
            Assert.AreEqual("d09e9965-5db2-4242-8ade-896a145ead64", TestUtil.ToTestableString(obj.UniqueId), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Extra), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.DocumentationUrl), true);
            Assert.AreEqual("d0ae7fae-d62d-4f44-b151-637d436e2c48", TestUtil.ToTestableString(obj.ServiceBrokerGuid), true);
            Assert.AreEqual("false", TestUtil.ToTestableString(obj.PlanUpdateable), true);
            Assert.AreEqual("/v2/services/3f05d68d-10b5-4012-b3aa-1f687ce85fe4/service_plans", TestUtil.ToTestableString(obj.ServicePlansUrl), true);
        }
    }
}
