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
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.UserProvidedServiceInstancesEndpoint.ListAllUserProvidedServiceInstances()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/234/user_provided_service_instances/list_all_user_provided_service_instances.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ListAllUserProvidedServiceInstancesResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractListAllUserProvidedServiceInstancesResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.UserProvidedServiceInstancesEndpoint.ListAllUserProvidedServiceInstances()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/234/user_provided_service_instances/list_all_user_provided_service_instances.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractListAllUserProvidedServiceInstancesResponse : IResponse
    {
        /// <summary>
        /// Contains the Metadata for this Entity
        /// </summary>
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Name</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Credentials</para>
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Credentials
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Guid</para>
        /// </summary>
        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Type</para>
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Syslog Drain Url</para>
        /// </summary>
        [JsonProperty("syslog_drain_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SyslogDrainUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Route Service Url</para>
        /// </summary>
        [JsonProperty("route_service_url", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic RouteServiceUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Url</para>
        /// </summary>
        [JsonProperty("space_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Service Bindings Url</para>
        /// </summary>
        [JsonProperty("service_bindings_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceBindingsUrl
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Routes Url</para>
        /// </summary>
        [JsonProperty("routes_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RoutesUrl
        {
            get;
            set;
        }
    }
}