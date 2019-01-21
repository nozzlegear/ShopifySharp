using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify orders.
    /// </summary>
    public class CheckoutService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="OrderService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CheckoutService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's abandoned checkouts.
        /// </summary>
        /// <param name="filter">Options for filtering the count.</param>
        /// <returns>The count of all orders for the shop.</returns>
        [Obsolete("This endpoint is an undocumented feature. Shopify may remove support for this endpoint at any time, without warning.")]
        public virtual async Task<int> CountAsync(CheckoutFilter filter = null)
        {
            var req = PrepareRequest("checkouts/count.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's abandoned carts.
        /// </summary>
        /// <returns></returns>
        [Obsolete("This endpoint is an undocumented feature. Shopify may remove support for this endpoint at any time, without warning.")]
        public virtual async Task<IEnumerable<Checkout>> ListAsync(CheckoutFilter options = null)
        {
            var req = PrepareRequest("checkouts.json");

            if (options != null)
            {
                req.QueryParams.AddRange(options.ToParameters());
            }

            return await ExecuteRequestAsync<List<Checkout>>(req, HttpMethod.Get, rootElement: "checkouts");
        }

    }
}
