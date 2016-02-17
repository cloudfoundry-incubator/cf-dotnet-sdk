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

using CloudFoundry.CloudController.V3.Client;
using CloudFoundry.CloudController.V3.Client.Data;
using Microsoft.CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CodeDom.Compiler;

namespace CloudFoundry.CloudController.V3.Test.Deserialization
{
    [TestClass]
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ProcessesExperimentalTest
    {


        [TestMethod]
        public void TestListAllProcessesResponse()
        {
            string json = @"{
  ""pagination"": {
    ""total_results"": 3,
    ""first"": {
      ""href"": ""/v3/processes?page=1=2""
    },
    ""last"": {
      ""href"": ""/v3/processes?page=2=2""
    },
    ""next"": {
      ""href"": ""/v3/processes?page=2=2""
    },
    ""previous"": null
  },
  ""resources"": [
    {
      ""guid"": ""1feebc15-2550-4274-94e1-0f3152c55c36"",
      ""type"": ""web"",
      ""command"": null,
      ""instances"": 1,
      ""memory_in_mb"": 1024,
      ""disk_in_mb"": 1024,
      ""created_at"": ""2016-02-11T13:20:55Z"",
      ""updated_at"": ""2016-02-11T13:20:55Z"",
      ""links"": {
        ""self"": {
          ""href"": ""/v3/processes/6423d255-eddb-40ed-aca3-203b62ccc1df""
        },
        ""scale"": {
          ""href"": ""/v3/processes/6423d255-eddb-40ed-aca3-203b62ccc1df/scale"",
          ""method"": ""PUT""
        },
        ""app"": {
          ""href"": ""/v3/apps/67df8345-a357-4c71-a0ff-131bd9a31367""
        },
        ""space"": {
          ""href"": ""/v2/spaces/a1e5a050-cf9a-4be0-9c04-69b0d695b483""
        }
      }
    },
    {
      ""guid"": ""1feebc15-2550-4274-94e1-0f3152c55c36"",
      ""type"": ""web"",
      ""command"": null,
      ""instances"": 1,
      ""memory_in_mb"": 1024,
      ""disk_in_mb"": 1024,
      ""created_at"": ""2016-02-11T13:20:55Z"",
      ""updated_at"": ""2016-02-11T13:20:55Z"",
      ""links"": {
        ""self"": {
          ""href"": ""/v3/processes/cdf553cb-4305-4327-b19f-35e01523afeb""
        },
        ""scale"": {
          ""href"": ""/v3/processes/cdf553cb-4305-4327-b19f-35e01523afeb/scale"",
          ""method"": ""PUT""
        },
        ""app"": {
          ""href"": ""/v3/apps/""
        },
        ""space"": {
          ""href"": ""/v2/spaces/a1e5a050-cf9a-4be0-9c04-69b0d695b483""
        }
      }
    }
  ]
}";

            PagedResponseCollection<ListAllProcessesResponse> page = Utilities.DeserializePage<ListAllProcessesResponse>(json, null);

            Assert.AreEqual("1feebc15-2550-4274-94e1-0f3152c55c36", TestUtil.ToTestableString(page[0].Guid), true);
            Assert.AreEqual("web", TestUtil.ToTestableString(page[0].Type), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[0].Command), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page[0].Instances), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(page[0].MemoryInMb), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(page[0].DiskInMb), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(page[0].CreatedAt), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(page[0].UpdatedAt), true);
            Assert.AreEqual("1feebc15-2550-4274-94e1-0f3152c55c36", TestUtil.ToTestableString(page[1].Guid), true);
            Assert.AreEqual("web", TestUtil.ToTestableString(page[1].Type), true);
            Assert.AreEqual("", TestUtil.ToTestableString(page[1].Command), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(page[1].Instances), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(page[1].MemoryInMb), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(page[1].DiskInMb), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(page[1].CreatedAt), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(page[1].UpdatedAt), true);
        }

        [TestMethod]
        public void TestGetProcessResponse()
        {
            string json = @"{
  ""guid"": ""1b528d13-a00e-40d6-9dce-47460c59ef79"",
  ""type"": ""web"",
  ""command"": null,
  ""instances"": 1,
  ""memory_in_mb"": 1024,
  ""disk_in_mb"": 1024,
  ""created_at"": ""2016-02-11T13:20:55Z"",
  ""updated_at"": ""2016-02-11T13:20:55Z"",
  ""links"": {
    ""self"": {
      ""href"": ""/v3/processes/4cdf92ac-b75e-4427-ae59-f2212c340f91""
    },
    ""scale"": {
      ""href"": ""/v3/processes/4cdf92ac-b75e-4427-ae59-f2212c340f91/scale"",
      ""method"": ""PUT""
    },
    ""app"": {
      ""href"": ""/v3/apps/1411e0c1-c1ea-4970-9671-4aa5895754fb""
    },
    ""space"": {
      ""href"": ""/v2/spaces/1a84ea09-005a-4b16-9a79-1b26f42c2b43""
    }
  }
}";

            GetProcessResponse obj = Utilities.DeserializeJson<GetProcessResponse>(json);

            Assert.AreEqual("1b528d13-a00e-40d6-9dce-47460c59ef79", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("web", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Command), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(obj.Instances), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(obj.MemoryInMb), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(obj.DiskInMb), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(obj.CreatedAt), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(obj.UpdatedAt), true);
        }

        [TestMethod]
        public void TestUpdateProcessResponse()
        {
            string json = @"{
  ""guid"": ""7a19579f-87ec-429b-b430-410d43e60045"",
  ""type"": ""web"",
  ""command"": ""X"",
  ""instances"": 1,
  ""memory_in_mb"": 1024,
  ""disk_in_mb"": 1024,
  ""created_at"": ""2016-02-11T13:20:55Z"",
  ""updated_at"": ""2016-02-11T13:20:55Z"",
  ""links"": {
    ""self"": {
      ""href"": ""/v3/processes/2f001d65-d50f-49a1-b7c6-32343bdc9d89""
    },
    ""scale"": {
      ""href"": ""/v3/processes/2f001d65-d50f-49a1-b7c6-32343bdc9d89/scale"",
      ""method"": ""PUT""
    },
    ""app"": {
      ""href"": ""/v3/apps/""
    },
    ""space"": {
      ""href"": ""/v2/spaces/4c93480a-d4b0-4013-ad0b-284943d898bb""
    }
  }
}";

            UpdateProcessResponse obj = Utilities.DeserializeJson<UpdateProcessResponse>(json);

            Assert.AreEqual("7a19579f-87ec-429b-b430-410d43e60045", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("web", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("X", TestUtil.ToTestableString(obj.Command), true);
            Assert.AreEqual("1", TestUtil.ToTestableString(obj.Instances), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(obj.MemoryInMb), true);
            Assert.AreEqual("1024", TestUtil.ToTestableString(obj.DiskInMb), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(obj.CreatedAt), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(obj.UpdatedAt), true);
        }

        [TestMethod]
        public void TestScalingProcessResponse()
        {
            string json = @"{
  ""guid"": ""d459327e-dcb9-4672-9d19-dcd36a9b7779"",
  ""type"": ""web"",
  ""command"": null,
  ""instances"": 3,
  ""memory_in_mb"": 100,
  ""disk_in_mb"": 100,
  ""created_at"": ""2016-02-11T13:20:55Z"",
  ""updated_at"": ""2016-02-11T13:20:55Z"",
  ""links"": {
    ""self"": {
      ""href"": ""/v3/processes/2c1e3906-0d60-41bd-9532-b318ad43407f""
    },
    ""scale"": {
      ""href"": ""/v3/processes/2c1e3906-0d60-41bd-9532-b318ad43407f/scale"",
      ""method"": ""PUT""
    },
    ""app"": {
      ""href"": ""/v3/apps/abad84a5-c6ef-4611-a754-0b710f867ddd""
    },
    ""space"": {
      ""href"": ""/v2/spaces/1430776c-04e5-44c0-a4b8-76433cdae5a4""
    }
  }
}";

            ScalingProcessResponse obj = Utilities.DeserializeJson<ScalingProcessResponse>(json);

            Assert.AreEqual("d459327e-dcb9-4672-9d19-dcd36a9b7779", TestUtil.ToTestableString(obj.Guid), true);
            Assert.AreEqual("web", TestUtil.ToTestableString(obj.Type), true);
            Assert.AreEqual("", TestUtil.ToTestableString(obj.Command), true);
            Assert.AreEqual("3", TestUtil.ToTestableString(obj.Instances), true);
            Assert.AreEqual("100", TestUtil.ToTestableString(obj.MemoryInMb), true);
            Assert.AreEqual("100", TestUtil.ToTestableString(obj.DiskInMb), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(obj.CreatedAt), true);
            Assert.AreEqual("2016-02-11T13:20:55Z", TestUtil.ToTestableString(obj.UpdatedAt), true);
        }
    }
}
