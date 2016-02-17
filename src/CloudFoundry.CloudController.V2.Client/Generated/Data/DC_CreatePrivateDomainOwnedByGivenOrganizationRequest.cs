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
    /// Data class used for serializing the "CloudFoundry.CloudController.V2.Client.PrivateDomainsEndpoint.CreatePrivateDomainOwnedByGivenOrganization()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/224/private_domains/create_a_private_domain_owned_by_the_given_organization.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class CreatePrivateDomainOwnedByGivenOrganizationRequest : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractCreatePrivateDomainOwnedByGivenOrganizationRequest
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for serializing the "CloudFoundry.CloudController.V2.Client.PrivateDomainsEndpoint.CreatePrivateDomainOwnedByGivenOrganization()" Request
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/224/private_domains/create_a_private_domain_owned_by_the_given_organization.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractCreatePrivateDomainOwnedByGivenOrganizationRequest
    {

        /// <summary> 
        /// <para>The name of the domain.</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The organization that owns the domain. If not specified, the domain is shared.</para>
        /// </summary>
        [JsonProperty("owning_organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OwningOrganizationGuid
        {
            get;
            set;
        }
    }
}