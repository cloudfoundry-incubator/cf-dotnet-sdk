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
public class GetInstanceInformationForStartedAppResponse :IResponse
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

    [JsonProperty("since", NullValueHandling=NullValueHandling.Ignore)]
    public double? Since
    {
    get;
    set;
    }

    [JsonProperty("debug_ip", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic DebugIp
    {
    get;
    set;
    }

    [JsonProperty("debug_port", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic DebugPort
    {
    get;
    set;
    }

    [JsonProperty("console_ip", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic ConsoleIp
    {
    get;
    set;
    }

    [JsonProperty("console_port", NullValueHandling=NullValueHandling.Ignore)]
    public dynamic ConsolePort
    {
    get;
    set;
    }

}
}