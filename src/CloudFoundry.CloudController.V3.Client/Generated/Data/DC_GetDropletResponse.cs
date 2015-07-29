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

namespace CloudFoundry.CloudController.V3.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V3.Client.DropletsExperimentalEndpoint.GetDroplet()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/208/droplets__experimental_/get_a_droplet.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class GetDropletResponse : CloudFoundry.CloudController.V3.Client.Data.Base.AbstractGetDropletResponse
    {
    }
}

namespace CloudFoundry.CloudController.V3.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V3.Client.DropletsExperimentalEndpoint.GetDroplet()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/208/droplets__experimental_/get_a_droplet.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractGetDropletResponse
    {

        /// <summary> 
        /// <para>The Guid</para>
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public string Guid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The State</para>
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Hash</para>
        /// </summary>
        [JsonProperty("hash", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Hash
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Buildpack Git Url</para>
        /// </summary>
        [JsonProperty("buildpack_git_url", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BuildpackGitUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Failure Reason</para>
        /// </summary>
        [JsonProperty("failure_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailureReason
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Detected Start Command</para>
        /// </summary>
        [JsonProperty("detected_start_command", NullValueHandling = NullValueHandling.Ignore)]
        public string DetectedStartCommand
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Procfile</para>
        /// </summary>
        [JsonProperty("procfile", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Procfile
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Environment Variables</para>
        /// </summary>
        [JsonProperty("environment_variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> EnvironmentVariables
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Created At</para>
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Updated At</para>
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic UpdatedAt
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Links</para>
        /// </summary>
        [JsonProperty("_links", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Links
        {
            get;
            set;
        }
    }
}