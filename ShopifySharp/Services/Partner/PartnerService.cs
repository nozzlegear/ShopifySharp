using Newtonsoft.Json.Linq;
using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
using ShopifySharp.Utilities;

namespace ShopifySharp
{
    /// <summary>
    /// A service to query the GraphQL Partner API
    /// See https://shopify.dev/api/partner
    /// </summary>
    public class PartnerService : ShopifyService, IPartnerService
    {
        private readonly long _organizationId;
        private readonly string _apiVersion;

        public override string APIVersion => _apiVersion ?? base.APIVersion;

        public PartnerService(long organizationId, string accessToken, string apiVersion = null) : base("partners.shopify.com", accessToken)
        {
            _organizationId = organizationId;
            _apiVersion = apiVersion;
        }

        public PartnerService(long organizationId, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base("partners.shopify.com", accessToken, shopifyDomainUtility)
        {
            _organizationId = organizationId;
        }

        /// <inheritdoc />
        public virtual async Task<JToken> PostAsync(string body, CancellationToken cancellationToken = default)
        {
            var req = new RequestUri(new Uri($"https://partners.shopify.com/{_organizationId}/api/{APIVersion}/graphql.json"));
            var content = new StringContent(body, Encoding.UTF8, "application/graphql");
            var response = await ExecuteRequestAsync(req, HttpMethod.Post, cancellationToken, content);
            CheckForErrors(response);
            return response.Result["data"];
        }

        /// <summary>
        /// Since Graph API Errors come back with error code 200, checking for them in a way similar to the REST API
        /// doesn't work well without potentially throwing unnecessary errors. This loses the requestId, but otherwise
        /// is capable of passing along the message.
        /// </summary>
        /// <param name="requestResult">The RequestResult{JToken} response from ExecuteRequestAsync.</param>
        /// <exception cref="ShopifyException">Thrown if <paramref name="requestResult"/> contains an error.</exception>
        private static void CheckForErrors(RequestResult<JToken> requestResult)
        {
            if (requestResult.Result["errors"] is null)
            {
                return;
            }

            var errorList = new List<string>();

            foreach (var error in requestResult.Result["errors"])
            {
                var errorMessage = error["message"];

                if (errorMessage is not null)
                {
                    errorList.Add(errorMessage.ToString());
                }
            }

            var message = requestResult.Result["errors"].FirstOrDefault()?["message"]?.ToString();

            throw new ShopifyException(requestResult.Response, HttpStatusCode.OK, errorList, message, requestResult.RawResult, "");
        }
    }
}
