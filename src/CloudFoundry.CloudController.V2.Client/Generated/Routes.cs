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
    /// Routes Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class RoutesEndpoint : CloudFoundry.CloudController.V2.Client.Base.AbstractRoutesEndpoint
    {
        internal RoutesEndpoint(CloudFoundryClient client) : base()
        {
            this.Client = client;
        }
    }
}

namespace CloudFoundry.CloudController.V2.Client.Base
{
    /// <summary>
    /// Base abstract class for Routes Endpoint
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractRoutesEndpoint : BaseEndpoint
    {
        /// <summary>
        /// Initializes the class
        /// </summary>
        protected AbstractRoutesEndpoint()
        {
        }

        /// <summary>
        /// List all Routes
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/224/routes/list_all_routes.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesResponse>> ListAllRoutes()
        {
            return await ListAllRoutes(new RequestOptions());
        }

        /// <summary>
        /// List all Routes
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/224/routes/list_all_routes.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllRoutesResponse>> ListAllRoutes(RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/routes";
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
            return Utilities.DeserializePage<ListAllRoutesResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Check a Route exists
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/224/routes/check_a_route_exists.html"</para>
        /// </summary>
        public async Task CheckRouteExists(Guid? domain_guid, dynamic host, dynamic path)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/routes/reserved/domain/{0}/host/{1}", domain_guid, host, path);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Get;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            var expectedReturnStatus = 204;
            var response = await this.SendAsync(client, expectedReturnStatus);
        }

        /// <summary>
        /// Delete a Particular Route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/224/routes/delete_a_particular_route.html"</para>
        /// </summary>
        public async Task DeleteRoute(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/routes/{0}", guid);
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
        /// Remove App from the Route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/224/routes/remove_app_from_the_route.html"</para>
        /// </summary>
        public async Task RemoveAppFromRoute(Guid? guid, Guid? app_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/routes/{0}/apps/{1}", guid, app_guid);
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
        /// Associate App with the Route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/224/routes/associate_app_with_the_route.html"</para>
        /// </summary>
        public async Task<AssociateAppWithRouteResponse> AssociateAppWithRoute(Guid? guid, Guid? app_guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/routes/{0}/apps/{1}", guid, app_guid);
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
            return Utilities.DeserializeJson<AssociateAppWithRouteResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// List all Apps for the Route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/224/routes/list_all_apps_for_the_route.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppsForRouteResponse>> ListAllAppsForRoute(Guid? guid)
        {
            return await ListAllAppsForRoute(guid, new RequestOptions());
        }

        /// <summary>
        /// List all Apps for the Route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/224/routes/list_all_apps_for_the_route.html"</para>
        /// </summary>
        public async Task<PagedResponseCollection<ListAllAppsForRouteResponse>> ListAllAppsForRoute(Guid? guid, RequestOptions options)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/routes/{0}/apps", guid);
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
            return Utilities.DeserializePage<ListAllAppsForRouteResponse>(await response.ReadContentAsStringAsync(), this.Client);
        }

        /// <summary>
        /// Creating a Route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/224/routes/creating_a_route.html"</para>
        /// </summary>
        public async Task<CreateRouteResponse> CreateRoute(CreateRouteRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = "/v2/routes";
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Post;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<CreateRouteResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Retrieve a Particular Route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/224/routes/retrieve_a_particular_route.html"</para>
        /// </summary>
        public async Task<RetrieveRouteResponse> RetrieveRoute(Guid? guid)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/routes/{0}", guid);
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
            return Utilities.DeserializeJson<RetrieveRouteResponse>(await response.ReadContentAsStringAsync());
        }

        /// <summary>
        /// Update a Route
        /// <para>For detailed information, see online documentation at: "http://apidocs.cloudfoundry.org/224/routes/update_a_route.html"</para>
        /// </summary>
        public async Task<UpdateRouteResponse> UpdateRoute(Guid? guid, UpdateRouteRequest value)
        {
            UriBuilder uriBuilder = new UriBuilder(this.Client.CloudTarget);
            uriBuilder.Path = string.Format(CultureInfo.InvariantCulture, "/v2/routes/{0}", guid);
            var client = this.GetHttpClient();
            client.Uri = uriBuilder.Uri;
            client.Method = HttpMethod.Put;
            var authHeader = await BuildAuthenticationHeader();
            if (!string.IsNullOrWhiteSpace(authHeader.Key))
            {
                client.Headers.Add(authHeader);
            }
            client.ContentType = "application/x-www-form-urlencoded";
            client.Content = ((string)JsonConvert.SerializeObject(value)).ConvertToStream();
            var expectedReturnStatus = 201;
            var response = await this.SendAsync(client, expectedReturnStatus);
            return Utilities.DeserializeJson<UpdateRouteResponse>(await response.ReadContentAsStringAsync());
        }
    }
}
