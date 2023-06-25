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
        /// Cancel a fulfillment order with the given id.
        /// </summary>
        /// <param name="fulfillmentOrderId">The fulfillment order to which the fulfillment orders belong.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<FulfillmentOrder> CancelAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"fulfillment_orders/{fulfillmentOrderId}/cancel.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <summary>
        /// Marks an in progress fulfillment order as incomplete, indicating the fulfillment service is unable to ship any remaining items and intends to close the fulfillment order.
        /// </summary>
        /// <param name="fulfillmentOrderId">The fulfillment order id.</param>
        /// <param name="message">Close reason.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<FulfillmentOrder> CloseAsync(long fulfillmentOrderId, string message, CancellationToken cancellationToken = default)
        {
            var body = new
            {
                message = message,
            }.ToDictionary();
            var content = new JsonContent(new
            {
                fulfillment_order = body,
            });

            var req = PrepareRequest($"fulfillment_orders/{fulfillmentOrderId}/close.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, content, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <summary>
        /// Halts all fulfillment work on a fulfillment order with status OPEN and changes the status of the fulfillment order to ON_HOLD.
        /// </summary>
        /// <param name="fulfillmentOrderId">The fulfillment order id.</param>
        /// <param name="fulfillmentHold">The fulfillment hold.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<FulfillmentOrder> HoldAsync(long fulfillmentOrderId, FulfillmentHold fulfillmentHold, CancellationToken cancellationToken = default)
        {
            var body = fulfillmentHold.ToDictionary();
            var content = new JsonContent(new
            {
                fulfillment_hold = body,
            });

            var req = PrepareRequest($"fulfillment_orders/{fulfillmentOrderId}/hold.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, content, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <summary>
        /// Moves a fulfillment order from one merchant managed location to another merchant managed location.
        /// </summary>
        /// <param name="fulfillmentOrderId">The fulfillment order id.</param>
        /// <param name="newLocationId">The new fulfillment order location.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<FulfillmentOrderMove> MoveAsync(long fulfillmentOrderId, long newLocationId, CancellationToken cancellationToken = default)
        {
            var body = new
            {
                new_location_id = newLocationId,
            }.ToDictionary();
            var content = new JsonContent(new
            {
                fulfillment_order = body,
            });

            var req = PrepareRequest($"fulfillment_orders/{fulfillmentOrderId}/move.json");

            //needs to be original_fulfillment_order
            var response = await ExecuteRequestAsync<FulfillmentOrderMove>(req, HttpMethod.Post, cancellationToken, content, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <summary>
        /// Marks a scheduled fulfillment order as ready for fulfillment.
        /// </summary>
        /// <param name="fulfillmentOrderId">The fulfillment order to which the fulfillment orders belong.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<FulfillmentOrder> OpenAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"fulfillment_orders/{fulfillmentOrderId}/open.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <summary>
        /// Release the fulfillment hold on a fulfillment order and changes the status of the fulfillment order to OPEN or SCHEDULED
        /// </summary>
        /// <param name="fulfillmentOrderId">The fulfillment order to which the fulfillment orders belong.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<FulfillmentOrder> ReleaseHoldAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"fulfillment_orders/{fulfillmentOrderId}/release_hold.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <summary>
        /// Updates the fulfill_at time of a scheduled fulfillment order. This endpoint is used to manage the time a scheduled fulfillment order will be marked as ready for fulfillment.
        /// </summary>
        /// <param name="fulfillmentOrderId">The fulfillment order id.</param>
        /// <param name="newFulfillAt">The new fulfill date.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<FulfillmentOrder> RescheduleAsync(long fulfillmentOrderId, DateTimeOffset newFulfillAt, CancellationToken cancellationToken = default)
        {
            var body  = new
            {
                new_fulfill_at = newFulfillAt,
            }.ToDictionary();
            var content = new JsonContent(new
            {
                fulfillment_order = body,
            });

            var req = PrepareRequest($"fulfillment_orders/{fulfillmentOrderId}/reschedule.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, content, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <summary>
        /// Gets a fulfillment order with the given id.
        /// </summary>
        /// <param name="fulfillmentOrderId">The fulfillment order to which the fulfillment orders belong.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<FulfillmentOrder> GetAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"fulfillment_orders/{fulfillmentOrderId}.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Get, cancellationToken, rootElement: "fulfillment_order");

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
