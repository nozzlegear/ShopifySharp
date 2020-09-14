using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for working with Shopify's StorefrontAccessTokens API.
    /// </summary>
    public class StorefrontAccessTokenService : ShopifyService
    {
        public StorefrontAccessTokenService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Creates a new <see cref="StorefrontAccessToken"/> with the given <paramref name="title"/>. A store can only have a
        /// maximum of 100 storefront access tokens. 
        /// </summary>
        public async Task<StorefrontAccessToken> CreateAsync(string title, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("storefront_access_tokens.json");
            var content = new JsonContent(new
            {
                storefront_access_token = new
                {
                    title = title 
                }
            });
            var response = await ExecuteRequestAsync<StorefrontAccessToken>(req, HttpMethod.Post, cancellationToken, content, "storefront_access_token");

            return response.Result;
        }

        /// <summary>
        /// Deletes the storefront access token with the given <paramref name="id"/>.
        /// </summary>
        public async Task DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"storefront_access_tokens/{id}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }

        /// <summary>
        /// Gets a list of storefront access tokens. A store can only have a maximum of 100 access tokens. 
        /// </summary>
        public async Task<IEnumerable<StorefrontAccessToken>> ListAsync(CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("storefront_access_tokens.json");
            var response = await ExecuteRequestAsync<IEnumerable<StorefrontAccessToken>>(req, HttpMethod.Get, cancellationToken, rootElement: "storefront_access_tokens");

            return response.Result;
        }
    }
}