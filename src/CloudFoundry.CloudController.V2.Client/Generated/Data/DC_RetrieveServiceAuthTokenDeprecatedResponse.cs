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
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceAuthTokensDeprecatedEndpoint.RetrieveServiceAuthTokenDeprecated()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/208/serviceauthtokens__deprecated_/retrieve_a_particular_service_auth_token_(deprecated).html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RetrieveServiceAuthTokenDeprecatedResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractRetrieveServiceAuthTokenDeprecatedResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.ServiceAuthTokensDeprecatedEndpoint.RetrieveServiceAuthTokenDeprecated()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/208/serviceauthtokens__deprecated_/retrieve_a_particular_service_auth_token_(deprecated).html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractRetrieveServiceAuthTokenDeprecatedResponse : IResponse
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
        /// <para>The Label</para>
        /// </summary>
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Provider</para>
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider
        {
            get;
            set;
        }
    }
}