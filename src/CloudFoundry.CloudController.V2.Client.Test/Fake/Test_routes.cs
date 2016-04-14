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
    public class RoutesEndpoint
{
        [TestMethod]
        public void ListAllRoutesTest()
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
        ""guid"": ""2d670414-3a3e-4d84-8904-e07e0c87b4d9"",
        ""url"": ""/v2/routes/f144d8fc-0c09-4435-a382-387862427168"",
        ""created_at"": ""2016-04-11T13:33:02Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""host"": ""host-28"",
        ""path"": """",
        ""domain_guid"": ""2d670414-3a3e-4d84-8904-e07e0c87b4d9"",
        ""space_guid"": ""2d670414-3a3e-4d84-8904-e07e0c87b4d9"",
        ""service_instance_guid"": ""2d670414-3a3e-4d84-8904-e07e0c87b4d9"",
        ""port"": 0,
        ""domain_url"": ""/v2/domains/21af2ff6-7b51-4596-baa3-da3c32c49b45"",
        ""space_url"": ""/v2/spaces/6f7d07d2-5ef0-4bfd-aa80-b7a1be7fa556"",
        ""service_instance_url"": ""/v2/service_instances/1603133b-1792-4d5e-82c2-7945b91787e1"",
        ""apps_url"": ""/v2/routes/f144d8fc-0c09-4435-a382-387862427168/apps"",
        ""route_mappings_url"": ""/v2/routes/f144d8fc-0c09-4435-a382-387862427168/route_mappings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();


                var obj = cfClient.Routes.ListAllRoutes().Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("2d670414-3a3e-4d84-8904-e07e0c87b4d9", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/f144d8fc-0c09-4435-a382-387862427168", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:02Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-28", TestUtil.ToTestableString(obj[0].Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Path), true);
                Assert.AreEqual("2d670414-3a3e-4d84-8904-e07e0c87b4d9", TestUtil.ToTestableString(obj[0].DomainGuid), true);
                Assert.AreEqual("2d670414-3a3e-4d84-8904-e07e0c87b4d9", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("2d670414-3a3e-4d84-8904-e07e0c87b4d9", TestUtil.ToTestableString(obj[0].ServiceInstanceGuid), true);
                Assert.AreEqual("0", TestUtil.ToTestableString(obj[0].Port), true);
                Assert.AreEqual("/v2/domains/21af2ff6-7b51-4596-baa3-da3c32c49b45", TestUtil.ToTestableString(obj[0].DomainUrl), true);
                Assert.AreEqual("/v2/spaces/6f7d07d2-5ef0-4bfd-aa80-b7a1be7fa556", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/service_instances/1603133b-1792-4d5e-82c2-7945b91787e1", TestUtil.ToTestableString(obj[0].ServiceInstanceUrl), true);
                Assert.AreEqual("/v2/routes/f144d8fc-0c09-4435-a382-387862427168/apps", TestUtil.ToTestableString(obj[0].AppsUrl), true);
                Assert.AreEqual("/v2/routes/f144d8fc-0c09-4435-a382-387862427168/route_mappings", TestUtil.ToTestableString(obj[0].RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void DeleteRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                cfClient.Routes.DeleteRoute(guid).Wait();

            }
        }

        [TestMethod]
        public void UpdateRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""24a75749-479b-4018-bb73-33b2ce5cd1d5"",
    ""url"": ""/v2/routes/495df7ff-1527-483c-adfd-68d3f244c940"",
    ""created_at"": ""2016-04-11T13:33:02Z"",
    ""updated_at"": ""2016-04-11T13:33:02Z""
  },
  ""entity"": {
    ""host"": ""host-30"",
    ""path"": """",
    ""domain_guid"": ""24a75749-479b-4018-bb73-33b2ce5cd1d5"",
    ""space_guid"": ""24a75749-479b-4018-bb73-33b2ce5cd1d5"",
    ""service_instance_guid"": null,
    ""port"": 10000,
    ""domain_url"": ""/v2/domains/fb81253b-1ba1-4bc5-902d-b9aceabd3304"",
    ""space_url"": ""/v2/spaces/ca23113d-21c3-4a61-961d-7d22cb722b42"",
    ""apps_url"": ""/v2/routes/495df7ff-1527-483c-adfd-68d3f244c940/apps"",
    ""route_mappings_url"": ""/v2/routes/495df7ff-1527-483c-adfd-68d3f244c940/route_mappings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                UpdateRouteRequest value = new UpdateRouteRequest();


                var obj = cfClient.Routes.UpdateRoute(guid, value).Result;


                Assert.AreEqual("24a75749-479b-4018-bb73-33b2ce5cd1d5", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/495df7ff-1527-483c-adfd-68d3f244c940", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:02Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-04-11T13:33:02Z", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-30", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
                Assert.AreEqual("24a75749-479b-4018-bb73-33b2ce5cd1d5", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("24a75749-479b-4018-bb73-33b2ce5cd1d5", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("10000", TestUtil.ToTestableString(obj.Port), true);
                Assert.AreEqual("/v2/domains/fb81253b-1ba1-4bc5-902d-b9aceabd3304", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/ca23113d-21c3-4a61-961d-7d22cb722b42", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/495df7ff-1527-483c-adfd-68d3f244c940/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
                Assert.AreEqual("/v2/routes/495df7ff-1527-483c-adfd-68d3f244c940/route_mappings", TestUtil.ToTestableString(obj.RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void RetrieveRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""56d58673-7cac-48f4-bd4d-95212301bc68"",
    ""url"": ""/v2/routes/d10f4c72-e98e-4321-abd5-f1482ae75a80"",
    ""created_at"": ""2016-04-11T13:33:01Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-27"",
    ""path"": """",
    ""domain_guid"": ""56d58673-7cac-48f4-bd4d-95212301bc68"",
    ""space_guid"": ""56d58673-7cac-48f4-bd4d-95212301bc68"",
    ""service_instance_guid"": ""56d58673-7cac-48f4-bd4d-95212301bc68"",
    ""port"": 0,
    ""domain_url"": ""/v2/domains/192eb5a6-f9be-4932-b82c-176ee653d0a1"",
    ""space_url"": ""/v2/spaces/edf7dd5e-ec19-46f5-8a22-705b108cf274"",
    ""service_instance_url"": ""/v2/service_instances/785ea3a2-553b-4905-bb82-48a17804907d"",
    ""apps_url"": ""/v2/routes/d10f4c72-e98e-4321-abd5-f1482ae75a80/apps"",
    ""route_mappings_url"": ""/v2/routes/d10f4c72-e98e-4321-abd5-f1482ae75a80/route_mappings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Routes.RetrieveRoute(guid).Result;


                Assert.AreEqual("56d58673-7cac-48f4-bd4d-95212301bc68", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/d10f4c72-e98e-4321-abd5-f1482ae75a80", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:01Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-27", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
                Assert.AreEqual("56d58673-7cac-48f4-bd4d-95212301bc68", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("56d58673-7cac-48f4-bd4d-95212301bc68", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("56d58673-7cac-48f4-bd4d-95212301bc68", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("0", TestUtil.ToTestableString(obj.Port), true);
                Assert.AreEqual("/v2/domains/192eb5a6-f9be-4932-b82c-176ee653d0a1", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/edf7dd5e-ec19-46f5-8a22-705b108cf274", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/service_instances/785ea3a2-553b-4905-bb82-48a17804907d", TestUtil.ToTestableString(obj.ServiceInstanceUrl), true);
                Assert.AreEqual("/v2/routes/d10f4c72-e98e-4321-abd5-f1482ae75a80/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
                Assert.AreEqual("/v2/routes/d10f4c72-e98e-4321-abd5-f1482ae75a80/route_mappings", TestUtil.ToTestableString(obj.RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllRouteMappingsForRouteTest()
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
        ""guid"": ""a06bac52-7b88-4e3f-a8ec-f10b500bb548"",
        ""url"": ""/v2/route_mappings/9390c114-a603-420b-98bd-204e9b018733"",
        ""created_at"": ""2016-04-11T13:33:01Z"",
        ""updated_at"": null
      },
      ""entity"": {
        ""app_port"": 8080,
        ""app_guid"": ""a06bac52-7b88-4e3f-a8ec-f10b500bb548"",
        ""route_guid"": ""a06bac52-7b88-4e3f-a8ec-f10b500bb548"",
        ""app_url"": ""/v2/apps/1cdc34ef-5c56-4c58-8d7f-68a04402660d"",
        ""route_url"": ""/v2/routes/cf72ee74-3782-4d50-bf48-0224e2993388""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Routes.ListAllRouteMappingsForRoute(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("a06bac52-7b88-4e3f-a8ec-f10b500bb548", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/route_mappings/9390c114-a603-420b-98bd-204e9b018733", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:01Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("8080", TestUtil.ToTestableString(obj[0].AppPort), true);
                Assert.AreEqual("a06bac52-7b88-4e3f-a8ec-f10b500bb548", TestUtil.ToTestableString(obj[0].AppGuid), true);
                Assert.AreEqual("a06bac52-7b88-4e3f-a8ec-f10b500bb548", TestUtil.ToTestableString(obj[0].RouteGuid), true);
                Assert.AreEqual("/v2/apps/1cdc34ef-5c56-4c58-8d7f-68a04402660d", TestUtil.ToTestableString(obj[0].AppUrl), true);
                Assert.AreEqual("/v2/routes/cf72ee74-3782-4d50-bf48-0224e2993388", TestUtil.ToTestableString(obj[0].RouteUrl), true);

            }
        }

        [TestMethod]
        public void CreateRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""e473d05b-e700-4a5a-a693-270668110348"",
    ""url"": ""/v2/routes/16e958a7-fbff-4e5c-98d7-40014f004693"",
    ""created_at"": ""2016-04-11T13:33:02Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": """",
    ""path"": """",
    ""domain_guid"": ""e473d05b-e700-4a5a-a693-270668110348"",
    ""space_guid"": ""e473d05b-e700-4a5a-a693-270668110348"",
    ""service_instance_guid"": null,
    ""port"": 10000,
    ""domain_url"": ""/v2/domains/ffd4f7fa-9ba0-4d63-9f16-ffc574b2d106"",
    ""space_url"": ""/v2/spaces/1dc858f3-965f-4302-ba83-709958d69c4f"",
    ""apps_url"": ""/v2/routes/16e958a7-fbff-4e5c-98d7-40014f004693/apps"",
    ""route_mappings_url"": ""/v2/routes/16e958a7-fbff-4e5c-98d7-40014f004693/route_mappings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                CreateRouteRequest value = new CreateRouteRequest();


                var obj = cfClient.Routes.CreateRoute(value).Result;


                Assert.AreEqual("e473d05b-e700-4a5a-a693-270668110348", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/16e958a7-fbff-4e5c-98d7-40014f004693", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:02Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
                Assert.AreEqual("e473d05b-e700-4a5a-a693-270668110348", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("e473d05b-e700-4a5a-a693-270668110348", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("10000", TestUtil.ToTestableString(obj.Port), true);
                Assert.AreEqual("/v2/domains/ffd4f7fa-9ba0-4d63-9f16-ffc574b2d106", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/1dc858f3-965f-4302-ba83-709958d69c4f", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/16e958a7-fbff-4e5c-98d7-40014f004693/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
                Assert.AreEqual("/v2/routes/16e958a7-fbff-4e5c-98d7-40014f004693/route_mappings", TestUtil.ToTestableString(obj.RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void CheckRouteExistsTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? domain_guid = Guid.NewGuid();

                dynamic host = null;

                dynamic path = null;


                cfClient.Routes.CheckRouteExists(domain_guid, host, path).Wait();

            }
        }

        [TestMethod]
        public void AssociateAppWithRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                string json = @"{
  ""metadata"": {
    ""guid"": ""84b50444-8bd1-4af0-ba4d-0f745b6f1192"",
    ""url"": ""/v2/routes/f9221777-afc2-4d18-bfd4-cd8f82a609e3"",
    ""created_at"": ""2016-04-11T13:33:01Z"",
    ""updated_at"": null
  },
  ""entity"": {
    ""host"": ""host-26"",
    ""path"": """",
    ""domain_guid"": ""84b50444-8bd1-4af0-ba4d-0f745b6f1192"",
    ""space_guid"": ""84b50444-8bd1-4af0-ba4d-0f745b6f1192"",
    ""service_instance_guid"": null,
    ""port"": 0,
    ""domain_url"": ""/v2/domains/f7380efe-7457-4e1b-934e-f25864ac3c44"",
    ""space_url"": ""/v2/spaces/cda9dca4-a9e2-4472-8557-fa936d27fd6c"",
    ""apps_url"": ""/v2/routes/f9221777-afc2-4d18-bfd4-cd8f82a609e3/apps"",
    ""route_mappings_url"": ""/v2/routes/f9221777-afc2-4d18-bfd4-cd8f82a609e3/route_mappings""
  }
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)201;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? app_guid = Guid.NewGuid();


                var obj = cfClient.Routes.AssociateAppWithRoute(guid, app_guid).Result;


                Assert.AreEqual("84b50444-8bd1-4af0-ba4d-0f745b6f1192", TestUtil.ToTestableString(obj.EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/routes/f9221777-afc2-4d18-bfd4-cd8f82a609e3", TestUtil.ToTestableString(obj.EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:01Z", TestUtil.ToTestableString(obj.EntityMetadata.CreatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("host-26", TestUtil.ToTestableString(obj.Host), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Path), true);
                Assert.AreEqual("84b50444-8bd1-4af0-ba4d-0f745b6f1192", TestUtil.ToTestableString(obj.DomainGuid), true);
                Assert.AreEqual("84b50444-8bd1-4af0-ba4d-0f745b6f1192", TestUtil.ToTestableString(obj.SpaceGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.ServiceInstanceGuid), true);
                Assert.AreEqual("0", TestUtil.ToTestableString(obj.Port), true);
                Assert.AreEqual("/v2/domains/f7380efe-7457-4e1b-934e-f25864ac3c44", TestUtil.ToTestableString(obj.DomainUrl), true);
                Assert.AreEqual("/v2/spaces/cda9dca4-a9e2-4472-8557-fa936d27fd6c", TestUtil.ToTestableString(obj.SpaceUrl), true);
                Assert.AreEqual("/v2/routes/f9221777-afc2-4d18-bfd4-cd8f82a609e3/apps", TestUtil.ToTestableString(obj.AppsUrl), true);
                Assert.AreEqual("/v2/routes/f9221777-afc2-4d18-bfd4-cd8f82a609e3/route_mappings", TestUtil.ToTestableString(obj.RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void ListAllAppsForRouteTest()
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
        ""guid"": ""1207bc95-2e8d-4702-9336-f86c1ec6ccc6"",
        ""url"": ""/v2/apps/9d49939c-036f-4336-bbc0-f34a482ee03e"",
        ""created_at"": ""2016-04-11T13:33:01Z"",
        ""updated_at"": ""2016-04-11T13:33:01Z""
      },
      ""entity"": {
        ""name"": ""name-668"",
        ""production"": false,
        ""space_guid"": ""1207bc95-2e8d-4702-9336-f86c1ec6ccc6"",
        ""stack_guid"": ""1207bc95-2e8d-4702-9336-f86c1ec6ccc6"",
        ""buildpack"": null,
        ""detected_buildpack"": null,
        ""environment_json"": null,
        ""memory"": 1024,
        ""instances"": 1,
        ""disk_quota"": 1024,
        ""state"": ""STOPPED"",
        ""version"": ""072c1e50-008f-4a38-98de-cf81a4ef27e4"",
        ""command"": null,
        ""console"": false,
        ""debug"": null,
        ""staging_task_id"": null,
        ""package_state"": ""PENDING"",
        ""health_check_type"": ""port"",
        ""health_check_timeout"": null,
        ""staging_failed_reason"": null,
        ""staging_failed_description"": null,
        ""diego"": false,
        ""docker_image"": null,
        ""package_updated_at"": ""2016-04-11T13:33:01Z"",
        ""detected_start_command"": """",
        ""enable_ssh"": true,
        ""docker_credentials_json"": {
          ""redacted_message"": ""[PRIVATE DATA HIDDEN]""
        },
        ""ports"": null,
        ""space_url"": ""/v2/spaces/12d42a1e-c567-454e-a54f-19852936b9fe"",
        ""stack_url"": ""/v2/stacks/6b4e6634-21d5-49e6-9f31-ca403274c451"",
        ""routes_url"": ""/v2/apps/9d49939c-036f-4336-bbc0-f34a482ee03e/routes"",
        ""events_url"": ""/v2/apps/9d49939c-036f-4336-bbc0-f34a482ee03e/events"",
        ""service_bindings_url"": ""/v2/apps/9d49939c-036f-4336-bbc0-f34a482ee03e/service_bindings"",
        ""route_mappings_url"": ""/v2/apps/9d49939c-036f-4336-bbc0-f34a482ee03e/route_mappings""
      }
    }
  ]
}";
                clients.JsonResponse = json;

                clients.ExpectedStatusCode = (HttpStatusCode)200;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();


                var obj = cfClient.Routes.ListAllAppsForRoute(guid).Result;

                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalResults), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj.Properties.TotalPages), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.PreviousUrl), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj.Properties.NextUrl), true);
                Assert.AreEqual("1207bc95-2e8d-4702-9336-f86c1ec6ccc6", TestUtil.ToTestableString(obj[0].EntityMetadata.Guid), true);
                Assert.AreEqual("/v2/apps/9d49939c-036f-4336-bbc0-f34a482ee03e", TestUtil.ToTestableString(obj[0].EntityMetadata.Url), true);
                Assert.AreEqual("2016-04-11T13:33:01Z", TestUtil.ToTestableString(obj[0].EntityMetadata.CreatedAt), true);
                Assert.AreEqual("2016-04-11T13:33:01Z", TestUtil.ToTestableString(obj[0].EntityMetadata.UpdatedAt), true);
                Assert.AreEqual("name-668", TestUtil.ToTestableString(obj[0].Name), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Production), true);
                Assert.AreEqual("1207bc95-2e8d-4702-9336-f86c1ec6ccc6", TestUtil.ToTestableString(obj[0].SpaceGuid), true);
                Assert.AreEqual("1207bc95-2e8d-4702-9336-f86c1ec6ccc6", TestUtil.ToTestableString(obj[0].StackGuid), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Buildpack), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DetectedBuildpack), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].EnvironmentJson), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj[0].Memory), true);
                Assert.AreEqual("1", TestUtil.ToTestableString(obj[0].Instances), true);
                Assert.AreEqual("1024", TestUtil.ToTestableString(obj[0].DiskQuota), true);
                Assert.AreEqual("STOPPED", TestUtil.ToTestableString(obj[0].State), true);
                Assert.AreEqual("072c1e50-008f-4a38-98de-cf81a4ef27e4", TestUtil.ToTestableString(obj[0].Version), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Command), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Console), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Debug), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].StagingTaskId), true);
                Assert.AreEqual("PENDING", TestUtil.ToTestableString(obj[0].PackageState), true);
                Assert.AreEqual("port", TestUtil.ToTestableString(obj[0].HealthCheckType), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].HealthCheckTimeout), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].StagingFailedReason), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].StagingFailedDescription), true);
                Assert.AreEqual("false", TestUtil.ToTestableString(obj[0].Diego), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DockerImage), true);
                Assert.AreEqual("2016-04-11T13:33:01Z", TestUtil.ToTestableString(obj[0].PackageUpdatedAt), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].DetectedStartCommand), true);
                Assert.AreEqual("true", TestUtil.ToTestableString(obj[0].EnableSsh), true);
                Assert.AreEqual("", TestUtil.ToTestableString(obj[0].Ports), true);
                Assert.AreEqual("/v2/spaces/12d42a1e-c567-454e-a54f-19852936b9fe", TestUtil.ToTestableString(obj[0].SpaceUrl), true);
                Assert.AreEqual("/v2/stacks/6b4e6634-21d5-49e6-9f31-ca403274c451", TestUtil.ToTestableString(obj[0].StackUrl), true);
                Assert.AreEqual("/v2/apps/9d49939c-036f-4336-bbc0-f34a482ee03e/routes", TestUtil.ToTestableString(obj[0].RoutesUrl), true);
                Assert.AreEqual("/v2/apps/9d49939c-036f-4336-bbc0-f34a482ee03e/events", TestUtil.ToTestableString(obj[0].EventsUrl), true);
                Assert.AreEqual("/v2/apps/9d49939c-036f-4336-bbc0-f34a482ee03e/service_bindings", TestUtil.ToTestableString(obj[0].ServiceBindingsUrl), true);
                Assert.AreEqual("/v2/apps/9d49939c-036f-4336-bbc0-f34a482ee03e/route_mappings", TestUtil.ToTestableString(obj[0].RouteMappingsUrl), true);

            }
        }

        [TestMethod]
        public void RemoveAppFromRouteTest()
        {
            using (ShimsContext.Create())
            {
                MockClients clients = new MockClients();

                clients.ExpectedStatusCode = (HttpStatusCode)204;
                var cfClient = clients.CreateCloudFoundryClient();

                Guid? guid = Guid.NewGuid();

                Guid? app_guid = Guid.NewGuid();


                cfClient.Routes.RemoveAppFromRoute(guid, app_guid).Wait();

            }
        }

    }
}