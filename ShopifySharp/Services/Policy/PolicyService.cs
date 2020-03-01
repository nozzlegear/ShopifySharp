using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class PolicyService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="PolicyService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public PolicyService(string myShopifyUrl, string shopAccessToken): base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Get the policies and their contents for a shop
        /// </summary>
        [Obsolete("This ListAsync method targets a version of Shopify's API which will be deprecated and cease to function in April of 2020. ShopifySharp version 5.0 has been published with support for the newer list API. Make sure you update before April of 2020.")]
        public virtual async Task<IEnumerable<Policy>> ListAsync()
        {
            var request = PrepareRequest("policies.json");

            return await ExecuteRequestAsync<List<Policy>>(request, HttpMethod.Get, rootElement: "policies");
        }
    }
}
