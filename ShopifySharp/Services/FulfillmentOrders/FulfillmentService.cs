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
        /// <remarks>
        /// This endpoint is not supported in 2019-10.
        /// </remarks>
        public override string APIVersion => "2020-07";

        /// <summary>
        /// Creates a new instance of <see cref="FulfillmentOrderService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public FulfillmentOrderService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of up to 250 of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<FulfillmentOrder>> ListAsync(long orderId, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync<FulfillmentOrder>($"orders/{orderId}/fulfillment_orders.json", "fulfillment_orders",null, cancellationToken);
        }

    }
}
