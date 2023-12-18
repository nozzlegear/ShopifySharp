using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify fulfillment orders.
    /// </summary>
    public class FulfillmentOrderService : ShopifyService, IFulfillmentOrderService
    {
        /// <summary>
        /// Creates a new instance of <see cref="FulfillmentOrderService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public FulfillmentOrderService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<FulfillmentOrder> CancelAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"fulfillment_orders/{fulfillmentOrderId}/cancel.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <inheritdoc />
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

            var req = BuildRequestUri($"fulfillment_orders/{fulfillmentOrderId}/close.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, content, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<FulfillmentOrder> HoldAsync(long fulfillmentOrderId, FulfillmentHold fulfillmentHold, CancellationToken cancellationToken = default)
        {
            var body = fulfillmentHold.ToDictionary();
            var content = new JsonContent(new
            {
                fulfillment_hold = body,
            });

            var req = BuildRequestUri($"fulfillment_orders/{fulfillmentOrderId}/hold.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, content, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <inheritdoc />
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

            var req = BuildRequestUri($"fulfillment_orders/{fulfillmentOrderId}/move.json");

            //needs to be original_fulfillment_order
            var response = await ExecuteRequestAsync<FulfillmentOrderMove>(req, HttpMethod.Post, cancellationToken, content);

            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<FulfillmentOrder> OpenAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"fulfillment_orders/{fulfillmentOrderId}/open.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<FulfillmentOrder> ReleaseHoldAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"fulfillment_orders/{fulfillmentOrderId}/release_hold.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <inheritdoc />
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

            var req = BuildRequestUri($"fulfillment_orders/{fulfillmentOrderId}/reschedule.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Post, cancellationToken, content, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<FulfillmentOrder> GetAsync(long fulfillmentOrderId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"fulfillment_orders/{fulfillmentOrderId}.json");
            var response = await ExecuteRequestAsync<FulfillmentOrder>(req, HttpMethod.Get, cancellationToken, rootElement: "fulfillment_order");

            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<FulfillmentOrder>> ListAsync(long orderId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"orders/{orderId}/fulfillment_orders.json");
            var response = await ExecuteRequestAsync<IEnumerable<FulfillmentOrder>>(req, HttpMethod.Get, cancellationToken, rootElement: "fulfillment_orders");

            return response.Result;
        }
    }
}