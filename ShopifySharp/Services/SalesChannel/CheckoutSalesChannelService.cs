using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Entities.SalesChannel;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    ///  A service use the Checkout API to let customers purchase products from Shopify stores that have installed your sales channel.
    /// </summary>
    public class CheckoutSalesChannelService: ShopifyService
    {
        public CheckoutSalesChannelService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken)
        { }

        /// <summary>
        /// Creates a new Checkout.
        /// </summary>
        public virtual async Task<CheckoutSalesChannel> CreateAsync(CheckoutSalesChannel checkout,
            CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("checkouts.json");

            var response = await ExecuteRequestAsync<CheckoutSalesChannel>(req, HttpMethod.Post, cancellationToken,
                new JsonContent(new {checkout}), "checkout");
            return response.Result;
        }

        /// <summary>
        /// Completes a checkout without requiring payment.
        /// </summary>
        public virtual async Task<CheckoutSalesChannel> CompleteAsync(string token, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"checkouts/{token}/complete.json");

            var response = await ExecuteRequestAsync<CheckoutSalesChannel>(req, HttpMethod.Post, cancellationToken, rootElement: "checkout");
            return response.Result;
        }

        /// <summary>
        /// Updates an existing checkout based on the token id.
        /// </summary>
        public virtual async Task<CheckoutSalesChannel> UpdateAsync(string token, CheckoutSalesChannel checkout,
            CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"checkouts/{token}.json");

            var response = await ExecuteRequestAsync<CheckoutSalesChannel>(req, HttpMethod.Put, cancellationToken,
                new JsonContent(new { checkout }), "checkout");
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
