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
using System.Collections.Generic;
using CloudFoundry.CloudController.V2.Interfaces;

namespace CloudFoundry.CloudController.V2.Client.Data
{
public class UpdateServicePlanDeprecatedResponse :IResponse
{

    public Metadata EntityMetadata
    {
    get;
    set;
    }



    [JsonProperty("name", NullValueHandling=NullValueHandling.Ignore)]
    public string Name
    {
    get;
    set;
    }

    [JsonProperty("free", NullValueHandling=NullValueHandling.Ignore)]
    public bool? Free
    {
    get;
    set;
    }

    [JsonProperty("description", NullValueHandling=NullValueHandling.Ignore)]
    public string Description
    {
    get;
    set;
    }

    [JsonProperty("service_guid", NullValueHandling=NullValueHandling.Ignore)]
    public Guid? ServiceGuid
    {
    get;
    set;
    }

    [JsonProperty("extra", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic Extra
    {
    get;
    set;
    }

    [JsonProperty("unique_id", NullValueHandling=NullValueHandling.Ignore)]
    public Guid? UniqueId
    {
    get;
    set;
    }

    [JsonProperty("public", NullValueHandling=NullValueHandling.Ignore)]
    public bool? Public
    {
    get;
    set;
    }

    [JsonProperty("active", NullValueHandling=NullValueHandling.Ignore)]
    public bool? Active
    {
    get;
    set;
    }

    [JsonProperty("service_url", NullValueHandling=NullValueHandling.Ignore)]
    public string ServiceUrl
    {
    get;
    set;
    }

    [JsonProperty("service_instances_url", NullValueHandling=NullValueHandling.Ignore)]
    public string ServiceInstancesUrl
    {
    get;
    set;
    }

}
}