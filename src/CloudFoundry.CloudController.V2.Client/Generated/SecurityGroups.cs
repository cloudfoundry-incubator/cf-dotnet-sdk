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

using CloudFoundry.CloudController.Common;
using CloudFoundry.CloudController.V2.Client.Data;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    /// <summary>
    /// SecurityGroups Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class SecurityGroupsEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractSecurityGroupsEndpoint
    {
        internal SecurityGroupsEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for SecurityGroups Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractSecurityGroupsEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractSecurityGroupsEndpoint()
        {
        }

        /// <summary>
        /// Retrieve a Particular Security Group
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/208/security_groups/retrieve_a_particular_security_group.html"</para>
        /// </summary>
        public async Task<RetrieveSecurityGroupResponse> RetrieveSecurityGroup(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/security_groups/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RetrieveSecurityGroupResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Associate Space with the Security Group
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/208/security_groups/associate_space_with_the_security_group.html"</para>
        /// </summary>
        public async Task<AssociateSpaceWithSecurityGroupResponse> AssociateSpaceWithSecurityGroup(Guid? guid, Guid? space_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/security_groups/{0}/spaces/{1}", guid, space_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<AssociateSpaceWithSecurityGroupResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Delete a Particular Security Group
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/208/security_groups/delete_a_particular_security_group.html"</para>
        /// </summary>
        public async Task DeleteSecurityGroup(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/security_groups/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// List all Spaces for the Security Group
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/208/security_groups/list_all_spaces_for_the_security_group.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForSecurityGroupResponse>> ListAllSpacesForSecurityGroup(Guid? guid)
        {
            return await ListAllSpacesForSecurityGroup(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Spaces for the Security Group
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/208/security_groups/list_all_spaces_for_the_security_group.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSpacesForSecurityGroupResponse>> ListAllSpacesForSecurityGroup(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/security_groups/{0}/spaces", guid);
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSpacesForSecurityGroupResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Updating a Security Group
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/208/security_groups/updating_a_security_group.html"</para>
        /// </summary>
        public async Task<UpdateSecurityGroupResponse> UpdateSecurityGroup(Guid? guid, UpdateSecurityGroupRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/security_groups/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateSecurityGroupResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Security Groups
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/208/security_groups/list_all_security_groups.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSecurityGroupsResponse>> ListAllSecurityGroups()
        {
            return await ListAllSecurityGroups(new RequestOptions());
        }

        /// <summary>
        /// List all Security Groups
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/208/security_groups/list_all_security_groups.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllSecurityGroupsResponse>> ListAllSecurityGroups(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/security_groups";
            uriBuilder.Query = options.ToString();
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 200;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializePage<ListAllSecurityGroupsResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Remove Space from the Security Group
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/208/security_groups/remove_space_from_the_security_group.html"</para>
        /// </summary>
        public async Task<RemoveSpaceFromSecurityGroupResponse> RemoveSpaceFromSecurityGroup(Guid? guid, Guid? space_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/security_groups/{0}/spaces/{1}", guid, space_guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Delete;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<RemoveSpaceFromSecurityGroupResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Creating a Security Group
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/208/security_groups/creating_a_security_group.html"</para>
        /// </summary>
        public async Task<CreateSecurityGroupResponse> CreateSecurityGroup(CreateSecurityGroupRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/security_groups";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateSecurityGroupResponse>(await response.ReadContentAsStringAsync());
        }
    }
}
