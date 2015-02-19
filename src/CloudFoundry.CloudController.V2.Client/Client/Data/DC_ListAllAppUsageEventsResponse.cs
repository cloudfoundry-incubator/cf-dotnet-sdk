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

using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using CloudFoundry.CloudController.V2.Interfaces;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
public class ListAllAppUsageEventsResponse :IResponse
{

    public Metadata EntityMetadata
    {
    get;
    set;
    }



    [JsonProperty("state", NullValueHandling=NullValueHandling.Ignore)]
    public string State
    {
    get;
    set;
    }

    [JsonProperty("memory_in_mb_per_instance", NullValueHandling=NullValueHandling.Ignore)]
    public int? MemoryInMbPerInstance
    {
    get;
    set;
    }

    [JsonProperty("instance_count", NullValueHandling=NullValueHandling.Ignore)]
    public int? InstanceCount
    {
    get;
    set;
    }

    [JsonProperty("app_guid", NullValueHandling=NullValueHandling.Ignore)]
    public string AppGuid
    {
    get;
    set;
    }

    [JsonProperty("app_name", NullValueHandling=NullValueHandling.Ignore)]
    public string AppName
    {
    get;
    set;
    }

    [JsonProperty("space_guid", NullValueHandling=NullValueHandling.Ignore)]
    public string SpaceGuid
    {
    get;
    set;
    }

    [JsonProperty("space_name", NullValueHandling=NullValueHandling.Ignore)]
    public string SpaceName
    {
    get;
    set;
    }

    [JsonProperty("org_guid", NullValueHandling=NullValueHandling.Ignore)]
    public string OrgGuid
    {
    get;
    set;
    }

    [JsonProperty("buildpack_guid", NullValueHandling=NullValueHandling.Ignore)]
    public string BuildpackGuid
    {
    get;
    set;
    }

    [JsonProperty("buildpack_name", NullValueHandling=NullValueHandling.Ignore)]
    public string BuildpackName
    {
    get;
    set;
    }

    [JsonProperty("package_state", NullValueHandling=NullValueHandling.Ignore)]
    public string PackageState
    {
    get;
    set;
    }

}
}