using Newtonsoft.Json.Linq;
using RestSharp;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify orders.
    /// </summary>
    public class OrderService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="OrderService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public OrderService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all of the shop's orders.
        /// </summary>
        /// <param name="filter">Options for filtering the count.</param>
        /// <returns>The count of all orders for the shop.</returns>
        public virtual async Task<int> CountAsync(OrderFilter filter = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("orders/count.json", Method.GET);

            //Add optional parameters to request
            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's orders.
        /// </summary>
        /// <param name="options">Options for filtering the list.</param>
        /// <returns>The list of orders matching the filter.</returns>
        public virtual async Task<IEnumerable<Order>> ListAsync(OrderFilter options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("orders.json", Method.GET, "orders");

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<Order>>(_RestClient, req);
        }

        /// <summary>
        /// Gets a list of up to 250 of the customer's orders.
        /// </summary>
        /// <param name="customerId">The id of the customer to list orders for.</param>
        /// <param name="options">Options for filtering the list.</param>
        /// <returns>The list of orders matching the filter.</returns>
        public virtual async Task<IEnumerable<Order>> ListForCustomerAsync(long customerId, OrderFilter options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("orders.json", Method.GET, "orders");

            //Add the customer id to the filter
            req.Parameters.Add(new Parameter() { Name = "customer_id", Value = customerId, Type = ParameterType.GetOrPost });

            //Add optional parameters to request
            if (options != null) req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<Order>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="Order"/> with the given id.
        /// </summary>
        /// <param name="orderId">The id of the order to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Order"/>.</returns>
        public virtual async Task<Order> GetAsync(long orderId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"orders/{orderId}.json", Method.GET, "order");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<Order>(_RestClient, req);
        }

        /// <summary>
        /// Closes an order.
        /// </summary>
        /// <param name="id">The order's id.</param>
        public virtual async Task<Order> CloseAsync(long id)
        {
            var req = RequestEngine.CreateRequest($"orders/{id}/close.json", Method.POST, "order");

            return await RequestEngine.ExecuteRequestAsync<Order>(_RestClient, req);
        }

        /// <summary>
        /// Opens a closed order.
        /// </summary>
        /// <param name="id">The order's id.</param>
        public virtual async Task<Order> OpenAsync(long id)
        {
            var req = RequestEngine.CreateRequest($"orders/{id}/open.json", Method.POST, "order");

            return await RequestEngine.ExecuteRequestAsync<Order>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="Order"/> on the store.
        /// </summary>
        /// <param name="order">A new <see cref="Order"/>. Id should be set to null.</param>
        /// <param name="options">Options for creating the order.</param>
        /// <returns>The new <see cref="Order"/>.</returns>
        public virtual async Task<Order> CreateAsync(Order order, OrderCreateOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("orders.json", Method.POST, "order");

            //Build the request body
            Dictionary<string, object> body = new Dictionary<string, object>(options?.ToDictionary() ?? new Dictionary<string, object>())
            {
                { "order", order }
            };

            req.AddJsonBody(body);

            return await RequestEngine.ExecuteRequestAsync<Order>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="Order"/>. Id must not be null.
        /// </summary>
        /// <param name="order">The <see cref="Order"/> to update.</param>
        /// <returns>The updated <see cref="Order"/>.</returns>
        public virtual async Task<Order> UpdateAsync(Order order)
        {
            IRestRequest req = RequestEngine.CreateRequest($"orders/{order.Id.Value}.json", Method.PUT, "order");

            req.AddJsonBody(new { order });

            return await RequestEngine.ExecuteRequestAsync<Order>(_RestClient, req);
        }

        /// <summary>
        /// Deletes an order with the given Id.
        /// </summary>
        /// <param name="orderId">The order object's Id.</param>
        public virtual async Task DeleteAsync(long orderId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"orders/{orderId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="orderId">The order's id.</param>
        /// <returns>The cancelled <see cref="Order"/>.</returns>
        public virtual async Task CancelAsync(long orderId, OrderCancelOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"orders/{orderId}/cancel.json", Method.POST);

            req.AddJsonBody(options);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion
    }
}
