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
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.OrganizationQuotaDefinitionsEndpoint.CreateOrganizationQuotaDefinition()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/234/organization_quota_definitions/creating_a_organization_quota_definition.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreateOrganizationQuotaDefinitionRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreateOrganizationQuotaDefinitionRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.OrganizationQuotaDefinitionsEndpoint.CreateOrganizationQuotaDefinition()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/234/organization_quota_definitions/creating_a_organization_quota_definition.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreateOrganizationQuotaDefinitionRequest
    {

        /// <summary> 
        /// <para>The name for the Organization Quota Definition.</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>If an organization can have non basic services</para>
        /// </summary>
        [JsonProperty("non_basic_services_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NonBasicServicesAllowed
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How many services an organization can have. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("total_services", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalServices
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How many routes an organization can have. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("total_routes", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRoutes
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How much memory in megabyte an organization can have.</para>
        /// </summary>
        [JsonProperty("memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The maximum amount of memory in megabyte an application instance can have. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("instance_memory_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceMemoryLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How many app instances an organization can create. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("app_instance_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppInstanceLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The number of tasks that can be run per app. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("app_task_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppTaskLimit
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How many service keys an organization can have. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("total_service_keys", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalServiceKeys
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>How many private domains an organization can have. (-1 represents an unlimited amount)</para>
        /// </summary>
        [JsonProperty("total_private_domains", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalPrivateDomains
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>If an organization can have a trial db.</para>
        /// </summary>
        [JsonProperty("trial_db_allowed", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic TrialDbAllowed
        {
            get;
            set;
        }
    }
}