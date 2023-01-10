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
    /// A service for manipulating Shopify fulfillments.
    /// </summary>
    public class FulfillmentService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="FulfillmentService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public FulfillmentService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the count.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The count of all fulfillments for the shop.</returns>
        public virtual async Task<int> CountAsync(long orderId, FulfillmentCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>($"orders/{orderId}/fulfillments/count.json", "count", filter, cancellationToken);
        }
        
        /// <summary>
        /// Gets a list of up to 250 of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<Fulfillment>> ListAsync(long orderId, ListFilter<Fulfillment> filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync($"orders/{orderId}/fulfillments.json", "fulfillments", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<Fulfillment>> ListAsync(long orderId, FulfillmentListFilter filter, CancellationToken cancellationToken = default)
        {
            return await ListAsync(orderId, filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="Fulfillment"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The id of the Fulfillment to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Fulfillment> GetAsync(long orderId, long fulfillmentId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<Fulfillment>($"orders/{orderId}/fulfillments/{fulfillmentId}.json", "fulfillment", fields, cancellationToken);
        }
        
        /// <summary>
        /// Creates a fulfillment for one or many fulfillment orders.
        /// </summary>
        /// <param name="fulfillment">An object containing fulfillment order and tracking data.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Fulfillment> CreateAsync(FulfillmentShipping fulfillment, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"fulfillments.json");
            var body = fulfillment.ToDictionary();

            var content = new JsonContent(new
            {
                fulfillment = body
            });

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, cancellationToken, content, "fulfillment");
            return response.Result;
        }

        /// <summary>
        /// Updates tracking for the given <see cref="Fulfillment"/>.
        /// </summary>
        /// <param name="fulfillmentId">Id of the object being updated.</param>
        /// <param name="fulfillment">The <see cref="Fulfillment"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Fulfillment> UpdateTrackingAsync(long fulfillmentId, FulfillmentShipping fulfillment, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"fulfillments/{fulfillmentId}/update_tracking.json");
            var body = fulfillment.ToDictionary();
            var content = new JsonContent(new
            {
                fulfillment = body
            });

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, cancellationToken, content, "fulfillment");
            return response.Result;
        }

        /// <summary>
        /// Creates a fulfillment for one or many fulfillment orders.
        /// </summary>
        /// <param name="fulfillment">An object containing fulfillment order and tracking data.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Fulfillment"/>.</returns>
        [Obsolete("This method has been renamed to CreateAsync and will be removed in a future release.")]
        public virtual async Task<Fulfillment> CreateForFulfillmentAsync(FulfillmentShipping fulfillment, CancellationToken cancellationToken = default)
        {
            return await CreateAsync(fulfillment, cancellationToken);
        }
    }
}
