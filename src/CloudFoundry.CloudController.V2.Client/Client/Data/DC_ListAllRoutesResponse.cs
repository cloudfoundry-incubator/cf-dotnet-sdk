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
public class ListAllRoutesResponse :IResponse
{

    public Metadata EntityMetadata
    {
    get;
    set;
    }



    [JsonProperty("host", NullValueHandling=NullValueHandling.Ignore)]
    public string Host
    {
    get;
    set;
    }

    [JsonProperty("domain_guid", NullValueHandling=NullValueHandling.Ignore)]
    public Guid? DomainGuid
    {
    get;
    set;
    }

    [JsonProperty("space_guid", NullValueHandling=NullValueHandling.Ignore)]
    public Guid? SpaceGuid
    {
    get;
    set;
    }

    [JsonProperty("domain_url", NullValueHandling=NullValueHandling.Ignore)]
    public string DomainUrl
    {
    get;
    set;
    }

    [JsonProperty("space_url", NullValueHandling=NullValueHandling.Ignore)]
    public string SpaceUrl
    {
    get;
    set;
    }

    [JsonProperty("apps_url", NullValueHandling=NullValueHandling.Ignore)]
    public string AppsUrl
    {
    get;
    set;
    }

}
}