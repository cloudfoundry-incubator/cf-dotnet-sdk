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

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServicesEndpoint.UpdateServiceDeprecated()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/236/services/updating_a_service_(deprecated).html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateServiceDeprecatedRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateServiceDeprecatedRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.ServicesEndpoint.UpdateServiceDeprecated()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/236/services/updating_a_service_(deprecated).html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateServiceDeprecatedRequest
    {

        /// <summary> 
        /// <para>The name of the service</para>
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A short blurb describing the service</para>
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The name of the service provider (used only by v1 service gateways)</para>
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The version of the service (used only by v1 service gateways)</para>
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The url of ther service provider (used only by v1 service gateways)</para>
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the service</para>
        /// </summary>
        [JsonProperty("guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A longer description of the service</para>
        /// </summary>
        [JsonProperty("long_description", NullValueHandling = NullValueHandling.Ignore)]
        public string LongDescription
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A url that points to an info page for the service</para>
        /// </summary>
        [JsonProperty("info_url", NullValueHandling = NullValueHandling.Ignore)]
        public string InfoUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A url that points to a documentation page for the service</para>
        /// </summary>
        [JsonProperty("documentation_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentationUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A timeout used by the v1 service gateway client</para>
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Timeout
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A boolean describing that the service can be provisioned by users</para>
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Active
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A boolean describing that the service can be bound to applications</para>
        /// </summary>
        [JsonProperty("bindable", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Bindable
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A JSON field with extra data pertaining to the service</para>
        /// </summary>
        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public string Extra
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A guid that identifies the service with the broker (not the same as the guid above)</para>
        /// </summary>
        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic UniqueId
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A list of tags for the service</para>
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A list of dependencies for services. The presence of "syslog_drain" indicates that on binding an instance of the service to an application,</para>
        /// <para>logs for the app will be streamed to a url provided by the service. The presence of "route_forwarding" indicates that on binding an instance of the</para>
        /// <para>service to a route, requests for the route may be processed by the service before being forwarded to an application mapped to the route.</para>
        /// </summary>
        [JsonProperty("requires", NullValueHandling = NullValueHandling.Ignore)]
        public string Requires
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The guid of the v2 service broker associated with the service</para>
        /// </summary>
        [JsonProperty("service_broker_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceBrokerGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>A boolean describing that an instance of this service can be updated to a different plan</para>
        /// </summary>
        [JsonProperty("plan_updateable", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic PlanUpdateable
        {
            get;
            set;
        }
    }
}