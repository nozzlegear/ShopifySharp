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

        [Obsolete]
        /// <summary>
        /// Creates a new <see cref="Fulfillment"/> on the order.
        /// <see href="https://shopify.dev/api/admin/rest/reference/shipping-and-fulfillment/fulfillment#createV2-2021-07">API Reference</see>
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillment">A new <see cref="Fulfillment"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Fulfillment> CreateAsync(long orderId, Fulfillment fulfillment, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments.json");
            var body = fulfillment.ToDictionary();

            var content = new JsonContent(new
            {
                fulfillment = body
            });

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, cancellationToken, content, "fulfillment");
            return response.Result;
        }

        /// <summary>
        /// Creates a new <see cref="Fulfillment"/> on the order.
        /// </summary>
        /// <param name="fulfillment">A new <see cref="Fulfillment"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Fulfillment> CreateForFulfillmentAsync(FulfillmentShipping fulfillment, CancellationToken cancellationToken = default)
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

        [Obsolete]
        /// <summary>
        /// Updates the given <see cref="Fulfillment"/>.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">Id of the object being updated.</param>
        /// <param name="fulfillment">The <see cref="Fulfillment"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Fulfillment> UpdateAsync(long orderId, long fulfillmentId, Fulfillment fulfillment, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}.json");
            var body = fulfillment.ToDictionary();
            var content = new JsonContent(new
            {
                fulfillment = body
            });

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Put, cancellationToken, content, "fulfillment");
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

        [Obsolete]
        /// <summary>
        /// Completes a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<Fulfillment> CompleteAsync(long orderId, long fulfillmentId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/complete.json");

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment");
            return response.Result;
        }

        [Obsolete]
        /// <summary>
        /// Cancels a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<Fulfillment> CancelAsync(long orderId, long fulfillmentId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/cancel.json");

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment");
            return response.Result;
        }

        [Obsolete]
        /// <summary>
        /// Opens a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<Fulfillment> OpenAsync(long orderId, long fulfillmentId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/open.json");

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, cancellationToken, rootElement: "fulfillment");
            return response.Result;
        }
    }
}
