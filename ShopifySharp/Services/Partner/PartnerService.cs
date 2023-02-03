using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using System.Net;
using System.Threading;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// A service to query the GraphQL Partner API
    /// See https://shopify.dev/api/partner
    /// </summary>
    public class PartnerService : ShopifyService
    {
        private readonly long _organizationId;
        private readonly string _apiVersion;

        public override string APIVersion => _apiVersion ?? base.APIVersion;

        /// <summary>
        /// Creates a new instance of <see cref="GraphService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public PartnerService(long organizationId, string accessToken, string apiVersion = null) : base("partners.shopify.com", accessToken) 
        {
            _organizationId = organizationId;
            _apiVersion = apiVersion;
        }

        /// <summary>
        /// Executes a Graph API Call.
        /// </summary>
        /// <param name="body">The query you would like to execute. Please see documentation for formatting.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>A JToken containing the data from the request.</returns>
        public virtual async Task<JToken> PostAsync(string body, CancellationToken cancellationToken = default)
        {
            var req = new RequestUri(new Uri($"https://partners.shopify.com/{_organizationId}/api/{APIVersion}/graphql.json"));
            var content = new StringContent(body, Encoding.UTF8, "application/graphql");
            var response = await ExecuteRequestAsync(req, HttpMethod.Post, cancellationToken, content);
            CheckForErrors(response);
            return response.Result["data"];
        }

        /// <summary>
        /// Since Graph API Errors come back with error code 200, checking for them in a way similar to the REST API doesn't work well without potentially throwing unnecessary errors. This loses the requestId, but otherwise is capable of passing along the message.
        /// </summary>
        /// <param name="requestResult">The RequestResult<JToken> response from ExecuteRequestAsync.</param>
        /// <returns>Task.</returns>
        private void CheckForErrors(RequestResult<JToken> requestResult)
        {
            if (requestResult.Result["errors"] != null)
            {
                var errorList = new List<string>();
                
                foreach (var error in requestResult.Result["errors"])
                {
                    errorList.Add(error["message"].ToString());
                }

                var message = requestResult.Result["errors"].FirstOrDefault()["message"].ToString();

                throw new ShopifyException(requestResult.Response, HttpStatusCode.OK, errorList, message, requestResult.RawResult, "");
            }
        }
    }
}
