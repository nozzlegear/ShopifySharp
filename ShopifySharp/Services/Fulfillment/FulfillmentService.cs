using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

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
        /// Gets a count of all of the shop's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="filter">Options for filtering the count.</param>
        /// <returns>The count of all fulfillments for the shop.</returns>
        public virtual async Task<int> CountAsync(long orderId, CountFilter filter = null)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/count.json");

            if (filter != null)
            {
                req.Url.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="options">Options for filtering the list.</param>
        /// <returns>The list of fulfillments matching the filter.</returns>
        public virtual async Task<IEnumerable<Fulfillment>> ListAsync(long orderId, ListFilter options = null)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments.json");

            if (options != null)
            {
                req.Url.QueryParams.AddRange(options.ToParameters());
            }

            return await ExecuteRequestAsync<List<Fulfillment>>(req, HttpMethod.Get, rootElement: "fulfillments");
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

            if (! string.IsNullOrEmpty(fields))
            {
                req.Url.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Get, rootElement: "fulfillment");
        }

        /// <summary>
        /// Creates a new <see cref="Fulfillment"/> on the store.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillment">A new <see cref="Fulfillment"/>. Id should be set to null.</param>
        /// <param name="notifyCustomer">Whether the customer should be notified that the fulfillment 
        /// has been created.</param>
        /// <returns>The new <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Fulfillment> CreateAsync(long orderId, Fulfillment fulfillment, bool notifyCustomer)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments.json");
            var body = fulfillment.ToDictionary();
            body.Add("notify_customer", notifyCustomer);

            var content = new JsonContent(new
            {
                fulfillment = body
            });
            
            return await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, content, "fulfillment");
        }

        /// <summary>
        /// Updates the given <see cref="Fulfillment"/>. Id must not be null.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillment">The <see cref="Fulfillment"/> to update.</param>
        /// <returns>The updated <see cref="Fulfillment"/>.</returns>
        public virtual async Task<Fulfillment> UpdateAsync(long orderId, Fulfillment fulfillment)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillment.Id.Value}.json");
            var content = new JsonContent(new
            {
                fulfillment = fulfillment
            });

            return await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Put, content, "fulfillment");
        }

        /// <summary>
        /// Completes a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        public virtual async Task<Fulfillment> CompleteAsync(long orderId, long fulfillmentId)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/complete.json");

            return await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, rootElement: "fulfillment");
        }

        /// <summary>
        /// Cancels a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        public virtual async Task<Fulfillment> CancelAsync(long orderId, long fulfillmentId)
        {
            var req = PrepareRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/cancel.json");

            return await ExecuteRequestAsync<Fulfillment>(req, HttpMethod.Post, rootElement: "fulfillment");
        }
    }
}
