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
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.RoutesMappingEndpoint.UpdateRouteMapping()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/234/routes_mapping/updating_a_route_mapping.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class UpdateRouteMappingRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractUpdateRouteMappingRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.RoutesMappingEndpoint.UpdateRouteMapping()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/234/routes_mapping/updating_a_route_mapping.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractUpdateRouteMappingRequest
    {

        /// <summary> 
        /// <para>Port on which the application should</para>
        /// <para>listen, and to which requests for the</para>
        /// <para>mapped route will be routed. Must be</para>
        /// <para>among those already configured for the app.</para>
        /// <para>If a port is not specified when mapping the</para>
        /// <para>route, the first one in the list of those</para>
        /// <para>configured for the app will be chosen.</para>
        /// </summary>
        [JsonProperty("app_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppPort
        {
            get;
            set;
        }
    }
}