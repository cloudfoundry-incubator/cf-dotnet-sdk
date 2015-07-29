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
    /// Data class used for serializing the "CloudFoundry.CloudController.V3.Client.PackagesExperimentalEndpoint.CreatePackage()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/208/packages__experimental_/create_a_package.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreatePackageRequest : CloudFoundry.CloudController.V3.Client.Data.Base.AbstractCreatePackageRequest
    {
    }
}

namespace CloudFoundry.CloudController.V3.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V3.Client.PackagesExperimentalEndpoint.CreatePackage()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/208/packages__experimental_/create_a_package.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreatePackageRequest
    {

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
        /// <para>The Url</para>
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url
        {
            get;
            set;
        }
    }
}