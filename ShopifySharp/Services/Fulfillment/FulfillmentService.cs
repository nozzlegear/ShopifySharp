using Newtonsoft.Json.Linq;
using RestSharp;
using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var req = RequestEngine.CreateRequest($"orders/{orderId}/fulfillments/count.json", Method.GET);

            //Add optional parameters to request
            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));

            var responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's fulfillments.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="options">Options for filtering the list.</param>
        /// <returns>The list of fulfillments matching the filter.</returns>
        public virtual async Task<IEnumerable<ShopifyFulfillment>> ListAsync(long orderId, ListFilter options = null)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/fulfillments.json", Method.GET, "fulfillments");

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyFulfillment>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyFulfillment"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The id of the Fulfillment to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyFulfillment"/>.</returns>
        public virtual async Task<ShopifyFulfillment> GetAsync(long orderId, long fulfillmentId, string fields = null)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/fulfillments/{fulfillmentId}.json", Method.GET, "fulfillment");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyFulfillment>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ShopifyFulfillment"/> on the store.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillment">A new <see cref="ShopifyFulfillment"/>. Id should be set to null.</param>
        /// <param name="notifyCustomer">Whether the customer should be notified that the fulfillment 
        /// has been created.</param>
        /// <returns>The new <see cref="ShopifyFulfillment"/>.</returns>
        public virtual async Task<ShopifyFulfillment> CreateAsync(long orderId, ShopifyFulfillment fulfillment, bool notifyCustomer)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/fulfillments.json", Method.POST, "fulfillment");
            
            //Convert the fulfillment to a dictionary and add the notifyCustomer prop
            var body = fulfillment.ToDictionary();
            body.Add("notify_customer", notifyCustomer);

            req.AddJsonBody(new { fulfillment = body });

            return await RequestEngine.ExecuteRequestAsync<ShopifyFulfillment>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ShopifyFulfillment"/>. Id must not be null.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillment">The <see cref="ShopifyFulfillment"/> to update.</param>
        /// <returns>The updated <see cref="ShopifyFulfillment"/>.</returns>
        public virtual async Task<ShopifyFulfillment> UpdateAsync(long orderId, ShopifyFulfillment fulfillment)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/fulfillments/{fulfillment.Id.Value}.json", Method.PUT, "fulfillment");

            req.AddJsonBody(new { fulfillment });

            return await RequestEngine.ExecuteRequestAsync<ShopifyFulfillment>(_RestClient, req);
        }

        /// <summary>
        /// Completes a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        public virtual async Task<ShopifyFulfillment> CompleteAsync(long orderId, long fulfillmentId)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/complete.json", Method.POST, "fulfillment");

            return await RequestEngine.ExecuteRequestAsync<ShopifyFulfillment>(_RestClient, req);
        }

        /// <summary>
        /// Cancels a pending fulfillment with the given id.
        /// </summary>
        /// <param name="orderId">The order id to which the fulfillments belong.</param>
        /// <param name="fulfillmentId">The fulfillment's id.</param>
        public virtual async Task<ShopifyFulfillment> CancelAsync(long orderId, long fulfillmentId)
        {
            var req = RequestEngine.CreateRequest($"orders/{orderId}/fulfillments/{fulfillmentId}/cancel.json", Method.POST, "fulfillment");

            return await RequestEngine.ExecuteRequestAsync<ShopifyFulfillment>(_RestClient, req);
        }
    }
}
