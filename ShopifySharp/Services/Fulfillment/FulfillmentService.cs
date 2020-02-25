using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using System;
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

        private async Task<int> _CountAsync(long orderId, ICountFilter filter = null)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/count.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }

            var response = await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
            
            return response.Result;
        }
        
        /// <summary>
        /// Gets a count of all of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the count.</param>
        /// <returns>The count of all fulfillments for the shop.</returns>
        public virtual async Task<int> CountAsync(long orderId, ICountFilter filter = null)
        {
            return await _CountAsync(orderId, filter);
        }

        /// <summary>
        /// Gets a count of all of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the count.</param>
        /// <returns>The count of all fulfillments for the shop.</returns>
        public virtual async Task<int> CountAsync(long orderId, FulfillmentCountFilter filter = null)
        {
            return await _CountAsync(orderId, filter);
        }
        
        /// <summary>
        /// Gets a list of up to 250 of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the list.</param>
        public virtual async Task<IListResult<Fulfillment>> ListAsync(long orderId, IListFilter filter)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<Fulfillment>>(req, HttpMethod.Get, rootElement: "fulfillments");

            return ParseLinkHeaderToListResult(response);
        }

        /// <summary>
        /// Gets a list of up to 250 of the order's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the list.</param>
        public virtual async Task<IListResult<Fulfillment>> ListAsync(long orderId, FulfillmentListFilter filter)
        {
            return await ListAsync(orderId, (IListFilter) filter);
        }

        /// <summary>
        /// Retrieves the <see cref="Fulfillment"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The id of the Fulfillment to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Fulfillment> GetAsync(long orderId, long fulfillmentId, string fields = null)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Get, rootElement: "fulfillment");
            return response.Result;
        }

        /// <summary>
        /// Creates a new <see cref="Fulfillment"/> on the order.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillment">A new <see cref="Fulfillment"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Fulfillment> CreateAsync(long orderId, Fulfillment fulfillment)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments.json");
            var body = fulfillment.ToDictionary();

            var content = new JsonContent(new
            {
                fulfillment = body
            });

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, content, "fulfillment");
            return response.Result;
        }

        /// <summary>
        /// Creates a new <see cref="Fulfillment"/> on the order.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillment">A new <see cref="Fulfillment"/>. Id should be set to null.</param>
        /// <param name="notifyCustomer">Whether the customer should be notified that the fulfillment
        /// has been created.</param>
        /// <returns>The new <see cref="Fulfillment"/>.</returns>
        [Obsolete("The notifyCustomer parameter can already be found on the Fulfillment object. This extra parameter will be removed from FulfillmentService.UpdateAsync in a future release.", false)]
        public virtual async Task<Fulfillment> CreateAsync(long orderId, Fulfillment fulfillment, bool notifyCustomer)
        {
            // Set the notifyCustomer property on the fulfillment
            fulfillment.NotifyCustomer = notifyCustomer;

            return await CreateAsync(orderId, fulfillment);
        }

        /// <summary>
        /// Updates the given <see cref="Fulfillment"/>.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">Id of the object being updated.</param>
        /// <param name="fulfillment">The <see cref="Fulfillment"/> to update.</param>
        /// <returns>The updated <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Fulfillment> UpdateAsync(long orderId, long fulfillmentId, Fulfillment fulfillment)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}.json");
            var body = fulfillment.ToDictionary();
            var content = new JsonContent(new
            {
                fulfillment = body
            });

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Put, content, "fulfillment");
            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="Fulfillment"/>.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">Id of the object being updated.</param>
        /// <param name="fulfillment">The <see cref="Fulfillment"/> to update.</param>
        /// <returns>The updated <see cref="Fulfillment"/>.</returns>
        [Obsolete("The notifyCustomer parameter can already be found on the Fulfillment object. This extra parameter will be removed from FulfillmentService.UpdateAsync in a future release.", false)]
        public virtual async Task<Fulfillment> UpdateAsync(long orderId, long fulfillmentId, Fulfillment fulfillment, bool notifyCustomer = false)
        {
            // Set the notifyCustomer property on the fulfillment
            fulfillment.NotifyCustomer = notifyCustomer;

            return await UpdateAsync(orderId, fulfillmentId, fulfillment);
        }

        /// <summary>
        /// Completes a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        public virtual async Task<Fulfillment> CompleteAsync(long orderId, long fulfillmentId)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/complete.json");

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, rootElement: "fulfillment");
            return response.Result;
        }

        /// <summary>
        /// Cancels a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        public virtual async Task<Fulfillment> CancelAsync(long orderId, long fulfillmentId)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/cancel.json");

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, rootElement: "fulfillment");
            return response.Result;
        }

        /// <summary>
        /// Opens a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        public virtual async Task<Fulfillment> OpenAsync(long orderId, long fulfillmentId)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/open.json");

            var response = await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, rootElement: "fulfillment");
            return response.Result;
        }
    }
}
