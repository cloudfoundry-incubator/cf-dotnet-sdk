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
    public class ServiceBindingsTest
    {


        [TestMethod]
        public void TestListAllServiceBindingsResponse()
        {
            string json = @"{
  ""total_results"": 1,
  ""total_pages"": 1,
  ""prev_url"": null,
  ""next_url"": null,
  ""resources"": [
    {
      ""metadata"": {
        ""guid"": ""e5606aa2-e940-402c-bf4d-2d2535b6722d"",
        ""url"": ""/v2/service_bindings/dabdcf7e-7820-4a37-8247-a75d006ff857"",
        ""created_at"": ""2017-01-04T15:59:08Z"",
        ""updated_at"": ""2017-01-04T15:59:08Z""
      },
      ""entity"": {
        ""app_guid"": ""e5606aa2-e940-402c-bf4d-2d2535b6722d"",
        ""service_instance_guid"": ""e5606aa2-e940-402c-bf4d-2d2535b6722d"",
        ""credentials"": {
          ""creds-key-67"": ""creds-val-67""
        },
        ""binding_options"": {

        },
        ""gateway_data"": null,
        ""gateway_name"": """",
        ""syslog_drain_url"": null,
        ""volume_mounts"": [

        ],
        ""app_url"": ""/v2/apps/5c09f07e-4136-4ffd-844f-00e100b3cdd5"",
        ""service_instance_url"": ""/v2/service_instances/959c75f2-d2ea-4bde-99b0-ae666adf2dfa""
      }
    }
  ]
}";

            PagedResponseCollection<ListAllServiceBindingsResponse> page = Utilities.DeserializePage<ListAllServiceBindingsResponse>(json, null);

            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalResults), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page.Properties.TotalPages), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.PreviousUrl), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page.Properties.NextUrl), true);
            Assert.AreEqual("e5606aa2-e940-402c-bf4d-2d2535b6722d", TestUtil.ToTestableString(page[0].EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/dabdcf7e-7820-4a37-8247-a75d006ff857", TestUtil.ToTestableString(page[0].EntityMetadata.Url), true);
            Assert.AreEqual("2017-01-04T15:59:08Z", TestUtil.ToTestableString(page[0].EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2017-01-04T15:59:08Z", TestUtil.ToTestableString(page[0].EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("e5606aa2-e940-402c-bf4d-2d2535b6722d", TestUtil.ToTestableString(page[0].AppGuid), true);
            Assert.AreEqual("e5606aa2-e940-402c-bf4d-2d2535b6722d", TestUtil.ToTestableString(page[0].ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/5c09f07e-4136-4ffd-844f-00e100b3cdd5", TestUtil.ToTestableString(page[0].AppUrl), true);
            Assert.AreEqual("/v2/service_instances/959c75f2-d2ea-4bde-99b0-ae666adf2dfa", TestUtil.ToTestableString(page[0].ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestRetrieveServiceBindingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""d6bde765-c4a1-449e-b13c-2f9d084b3bcc"",
    ""url"": ""/v2/service_bindings/6ed2703a-472f-4376-9b6d-2eebab0df032"",
    ""created_at"": ""2017-01-04T15:59:08Z"",
    ""updated_at"": ""2017-01-04T15:59:08Z""
  },
  ""entity"": {
    ""app_guid"": ""d6bde765-c4a1-449e-b13c-2f9d084b3bcc"",
    ""service_instance_guid"": ""d6bde765-c4a1-449e-b13c-2f9d084b3bcc"",
    ""credentials"": {
      ""creds-key-74"": ""creds-val-74""
    },
    ""binding_options"": {

    },
    ""gateway_data"": null,
    ""gateway_name"": """",
    ""syslog_drain_url"": null,
    ""volume_mounts"": [

    ],
    ""app_url"": ""/v2/apps/fa0d91d6-17f1-45a0-9c77-726ad918cece"",
    ""service_instance_url"": ""/v2/service_instances/99acdef0-ae9f-41a2-a854-c34ac64eb022""
  }
}";

            RetrieveServiceBindingResponse obj = Utilities.DeserializeJson<RetrieveServiceBindingResponse>(json);

            Assert.AreEqual("d6bde765-c4a1-449e-b13c-2f9d084b3bcc", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/6ed2703a-472f-4376-9b6d-2eebab0df032", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2017-01-04T15:59:08Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2017-01-04T15:59:08Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("d6bde765-c4a1-449e-b13c-2f9d084b3bcc", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("d6bde765-c4a1-449e-b13c-2f9d084b3bcc", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/fa0d91d6-17f1-45a0-9c77-726ad918cece", TestUtil.ToTestableString(obj.AppUrl), true);
            Assert.AreEqual("/v2/service_instances/99acdef0-ae9f-41a2-a854-c34ac64eb022", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);
        }

        [TestMethod]
        public void TestCreateServiceBindingResponse()
        {
            string json = @"{
  ""metadata"": {
    ""guid"": ""c1aeb11b-8f02-4eb7-88d8-fc62959fe80e"",
    ""url"": ""/v2/service_bindings/6370bf79-0371-4955-b1bd-b917ca6f8a22"",
    ""created_at"": ""2017-01-04T15:59:08Z"",
    ""updated_at"": ""2017-01-04T15:59:08Z""
  },
  ""entity"": {
    ""app_guid"": ""c1aeb11b-8f02-4eb7-88d8-fc62959fe80e"",
    ""service_instance_guid"": ""c1aeb11b-8f02-4eb7-88d8-fc62959fe80e"",
    ""credentials"": {
      ""creds-key-73"": ""creds-val-73""
    },
    ""binding_options"": {

    },
    ""gateway_data"": null,
    ""gateway_name"": """",
    ""syslog_drain_url"": null,
    ""volume_mounts"": [

    ],
    ""app_url"": ""/v2/apps/e041725b-73ab-4bf8-b98d-bf8403c659e6"",
    ""service_instance_url"": ""/v2/user_provided_service_instances/27225b7c-894e-45a8-bad2-d2110a51356e""
  }
}";

            CreateServiceBindingResponse obj = Utilities.DeserializeJson<CreateServiceBindingResponse>(json);

            Assert.AreEqual("c1aeb11b-8f02-4eb7-88d8-fc62959fe80e", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
            Assert.AreEqual("/v2/service_bindings/6370bf79-0371-4955-b1bd-b917ca6f8a22", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
            Assert.AreEqual("2017-01-04T15:59:08Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
            Assert.AreEqual("2017-01-04T15:59:08Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
            Assert.AreEqual("c1aeb11b-8f02-4eb7-88d8-fc62959fe80e", TestUtil.ToTestableString(obj.AppGuid), true);
            Assert.AreEqual("c1aeb11b-8f02-4eb7-88d8-fc62959fe80e", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayData), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.GatewayName), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.SyslogDrainUrl), true);
            Assert.AreEqual("/v2/apps/e041725b-73ab-4bf8-b98d-bf8403c659e6", TestUtil.ToTestableString(obj.AppUrl), true);
            Assert.AreEqual("/v2/user_provided_service_instances/27225b7c-894e-45a8-bad2-d2110a51356e", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);
        }
    }
}
