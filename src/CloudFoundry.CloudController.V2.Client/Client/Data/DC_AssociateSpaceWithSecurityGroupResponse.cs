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
public class AssociateSpaceWithSecurityGroupResponse :IResponse
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

    [JsonProperty("rules", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic[] Rules
    {
    get;
    set;
    }

    [JsonProperty("running_default", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic RunningDefault
    {
    get;
    set;
    }

    [JsonProperty("staging_default", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic StagingDefault
    {
    get;
    set;
    }

    [JsonProperty("spaces_url", NullValueHandling=NullValueHandling.Ignore)]
    public string SpacesUrl
    {
    get;
    set;
    }

}
}