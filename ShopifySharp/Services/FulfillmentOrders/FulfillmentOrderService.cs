using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using System;
using System.Threading;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify fulfillment orders.
    /// </summary>
    public class FulfillmentOrderService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="FulfillmentOrderService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public FulfillmentOrderService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a fulfillment order with the given id.
        /// </summary>
        /// <param name="fulfillmentOrderId">The fulfillment order to which the fulfillment orders belong.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<IEnumerable<FulfillmentOrder>> GetAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"fulfillment_orders/{fulfillmentOrderId}.json");
            var response = await ExecuteRequestAsync<IEnumerable<FulfillmentOrder>>(req, HttpMethod.Get, cancellationToken, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <summary>
        /// Gets a list of up to 250 of the order's fulfillment orders.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillment orders belong.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<IEnumerable<FulfillmentOrder>> ListAsync(long orderId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillment_orders.json");
            var response = await ExecuteRequestAsync<IEnumerable<FulfillmentOrder>>(req, HttpMethod.Get, cancellationToken, rootElement: "fulfillment_orders");

            return response.Result;
        }
    }
}
