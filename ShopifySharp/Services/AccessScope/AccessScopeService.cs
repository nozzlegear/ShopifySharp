using System;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for getting the access scopes associated with the access token
    /// </summary>
    public class AccessScopeService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of the service.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public AccessScopeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        //oauth endpoints don't support versioning
        protected override bool SupportsAPIVersioning => false;

        /// <summary>
        /// Retrieves a list of access scopes associated to the access token.
        /// </summary>
        [Obsolete("This ListAsync method targets a version of Shopify's API which will be deprecated and cease to function in April of 2020. ShopifySharp version 5.0 has been published with support for the newer list API. Make sure you update before April of 2020.")]
        public virtual async Task<IEnumerable<AccessScope>> ListAsync()
        {
            var req = PrepareRequest($"oauth/access_scopes.json");
            return await ExecuteRequestAsync<List<AccessScope>>(req, HttpMethod.Get, rootElement: "access_scopes");
        }
    }
}
