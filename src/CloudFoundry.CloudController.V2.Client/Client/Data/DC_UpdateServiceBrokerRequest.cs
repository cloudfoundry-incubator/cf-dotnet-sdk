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
public class UpdateServiceBrokerRequest
{



    [JsonProperty("auth_username", NullValueHandling=NullValueHandling.Ignore)]
    public string AuthUsername
    {
    get;
    set;
    }

    [JsonProperty("auth_password", NullValueHandling=NullValueHandling.Ignore)]
    public string AuthPassword
    {
    get;
    set;
    }

    [JsonProperty("broker_url", NullValueHandling=NullValueHandling.Ignore)]
    public string BrokerUrl
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

}
}