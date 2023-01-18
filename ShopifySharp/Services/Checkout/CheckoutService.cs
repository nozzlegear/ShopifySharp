using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using System;
using System.Threading;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for working with abandoned checkouts.
    /// </summary>
    public class CheckoutService : ShopifyService
    {
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CheckoutService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's orders.
        /// </summary>
        /// <param name="filter">Options for filtering the count.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The count of all orders for the shop.</returns>
        public virtual async Task<int> CountAsync(CheckoutCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>("checkouts/count.json", "count", filter, cancellationToken);
        }
        
        /// <summary>
        /// Gets a list of up to 250 of the shop's abandoned checkouts.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<Checkout>> ListAsync(ListFilter<Checkout> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("checkouts.json", "checkouts", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's abandoned checkouts.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<Checkout>> ListAsync(CheckoutListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }
        
        /// <summary>
        /// Creates a new Checkout.
        /// </summary>
        public virtual async Task<Checkout> CreateAsync(Checkout checkout, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("checkouts.json");
            var body = checkout.ToDictionary();

            var response = await ExecuteRequestAsync<Checkout>(req, HttpMethod.Post, cancellationToken, new JsonContent(new { checkout }), "checkout");
            return response.Result;
        }

        /// <summary>
        /// Completes a checkout without requiring payment.
        /// </summary>
        public virtual async Task<Checkout> CompleteAsync(string token, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"checkouts/{token}/complete.json");

            var response = await ExecuteRequestAsync<Checkout>(req, HttpMethod.Post, cancellationToken, rootElement: "checkout");
            return response.Result;
        }

        /// <summary>
        /// Gets an existing, processing or completed checkout.
        /// </summary>
        public virtual async Task<Checkout> GetAsync(string token, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"checkouts/{token}.json");

            var response = await ExecuteRequestAsync<Checkout>(req, HttpMethod.Get, cancellationToken, rootElement: "checkout");
            return response.Result;
        }

        /// <summary>
        /// Updates an existing checkout based on the token id.
        /// </summary>
        public virtual async Task<Checkout> UpdateAsync(string token, Checkout updatedCheckout, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"checkouts/{token}.json");

            var response = await ExecuteRequestAsync<Checkout>(req, HttpMethod.Put, cancellationToken, new JsonContent(new { checkout = updatedCheckout }), "checkout");
            return response.Result;
        }

        /// <summary>
        /// Retrieves a list of available shipping rates for the specified checkout. Implementers need to poll this endpoint until rates become available. Each shipping rate contains the checkout's 
        /// new subtotal price, total tax, and total price in the event that this shipping rate is selected. This can be used to update the UI without performing further API requests. To apply a 
        /// shipping rate, update the checkout's shipping line with the handle of the selected rate. 
        /// </summary>
        public virtual async Task<IEnumerable<CheckoutShippingRate>> ListShippingRatesAsync(string token, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"checkouts/{token}/shipping_rates.json");

            var response = await ExecuteRequestAsync<List<CheckoutShippingRate>>(req, HttpMethod.Get, cancellationToken, rootElement: "shipping_rates");
            return response.Result;
        }
    }
}
