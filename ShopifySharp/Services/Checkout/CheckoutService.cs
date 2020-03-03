using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify checkouts.
    /// </summary>
    [Obsolete("The endpoints and methods on this service no longer appear to be documented by Shopify. It may be removed in a future version of ShopifySharp.")]
    public class CheckoutService : ShopifyService
    {
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CheckoutService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Creates a new Checkout.
        /// </summary>
        public virtual async Task<Checkout> CreateAsync(Checkout checkout)
        {
            var req = PrepareRequest("checkout.json");
            var body = checkout.ToDictionary();

            var response = await ExecuteRequestAsync<Checkout>(req, HttpMethod.Post, new JsonContent(checkout), rootElement: "checkout");
            return response.Result;
        }

        /// <summary>
        /// Completes a checkout without requiring payment.
        /// </summary>
        public virtual async Task<Checkout> CompleteAsync(string token)
        {
            var req = PrepareRequest($"checkouts/{token}/complete.json");

            var response = await ExecuteRequestAsync<Checkout>(req, HttpMethod.Post, rootElement: "checkout");
            return response.Result;
        }

        /// <summary>
        /// Gets an existing, processing or completed checkout.
        /// </summary>
        public virtual async Task<Checkout> GetAsync(string token)
        {
            var req = PrepareRequest($"checkouts/{token}.json");

            var response = await ExecuteRequestAsync<Checkout>(req, HttpMethod.Get, rootElement: "checkout");
            return response.Result;
        }

        /// <summary>
        /// Updates an existing checkout based on the token id.
        /// </summary>
        public virtual async Task<Checkout> UpdateAsync(string token, Checkout updatedCheckout)
        {
            var req = PrepareRequest($"checkouts/{token}.json");

            var response = await ExecuteRequestAsync<Checkout>(req, HttpMethod.Put, new JsonContent(updatedCheckout), rootElement: "checkout");
            return response.Result;
        }

        /// <summary>
        /// Retrieves a list of available shipping rates for the specified checkout. Implementers need to poll this endpoint until rates become available. Each shipping rate contains the checkout's 
        /// new subtotal price, total tax, and total price in the event that this shipping rate is selected. This can be used to update the UI without performing further API requests. To apply a 
        /// shipping rate, update the checkout's shipping line with the handle of the selected rate. 
        /// </summary>
        public virtual async Task<IEnumerable<CheckoutShippingRate>> ListShippingRatesAsync(string token)
        {
            var req = PrepareRequest($"checkouts/{token}/shipping_rates.json");

            var response = await ExecuteRequestAsync<List<CheckoutShippingRate>>(req, HttpMethod.Get, rootElement: "shipping_rates");
            return response.Result;
        }
    }
}
