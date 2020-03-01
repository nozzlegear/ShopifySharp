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
    /// A service for manipulating Shopify checkouts.
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
        [Obsolete("This ListAsync method targets a version of Shopify's API which will be deprecated and cease to function in April of 2020. ShopifySharp version 5.0 has been published with support for the newer list API. Make sure you update before April of 2020.")]
        public virtual async Task<IEnumerable<Checkout>> ListAsync(CheckoutFilter options = null)
        {
            var req = PrepareRequest("checkouts.json");

            if (options != null)
            {
                req.QueryParams.AddRange(options.ToParameters());
            }

            return await ExecuteRequestAsync<List<Checkout>>(req, HttpMethod.Get, rootElement: "checkouts");
        }

        /// <summary>
        /// Creates a new Checkout.
        /// </summary>
        public virtual async Task<Checkout> CreateAsync(Checkout checkout)
        {
            var req = PrepareRequest("checkout.json");
            var body = checkout.ToDictionary();

            return await ExecuteRequestAsync<Checkout>(req, HttpMethod.Post, new JsonContent(checkout), rootElement: "checkout");
        }

        /// <summary>
        /// Completes a checkout without requiring payment.
        /// </summary>
        public virtual async Task<Checkout> CompleteAsync(string token)
        {
            var req = PrepareRequest($"checkouts/{token}/complete.json");

            return await ExecuteRequestAsync<Checkout>(req, HttpMethod.Post, rootElement: "checkout");
        }

        /// <summary>
        /// Gets an existing, processing or completed checkout.
        /// </summary>
        public virtual async Task<Checkout> GetAsync(string token)
        {
            var req = PrepareRequest($"checkouts/{token}.json");

            return await ExecuteRequestAsync<Checkout>(req, HttpMethod.Get, rootElement: "checkout");
        }

        /// <summary>
        /// Updates an existing checkout based on the token id.
        /// </summary>
        public virtual async Task<Checkout> UpdateAsync(string token, Checkout updatedCheckout)
        {
            var req = PrepareRequest($"checkouts/{token}.json");

            return await ExecuteRequestAsync<Checkout>(req, HttpMethod.Put, new JsonContent(updatedCheckout), rootElement: "checkout");
        }

        /// <summary>
        /// Retrieves a list of available shipping rates for the specified checkout. Implementers need to poll this endpoint until rates become available. Each shipping rate contains the checkout's 
        /// new subtotal price, total tax, and total price in the event that this shipping rate is selected. This can be used to update the UI without performing further API requests. To apply a 
        /// shipping rate, update the checkout's shipping line with the handle of the selected rate. 
        /// </summary>
        public virtual async Task<IEnumerable<CheckoutShippingRate>> ListShippingRatesAsync(string token)
        {
            var req = PrepareRequest($"checkouts/{token}/shipping_rates.json");

            return await ExecuteRequestAsync<List<CheckoutShippingRate>>(req, HttpMethod.Get, rootElement: "shipping_rates");
        }
    }
}
