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
    /// A service for manipulating Shopify customers.
    /// </summary>
    public class CustomerService: ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="CustomerService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomerService(string myShopifyUrl, string shopAccessToken): base (myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all of the shop's customers.
        /// </summary>
        /// <returns>The count of all customers for the shop.</returns>
        public virtual async Task<int> CountAsync()
        {
            IRestRequest req = RequestEngine.CreateRequest("customers/count.json", Method.GET);
            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's customers.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<Customer>> ListAsync(ListFilter filter = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("customers.json", Method.GET, "customers");

            //Add optional parameters to request
            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<Customer>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="Customer"/> with the given id.
        /// </summary>
        /// <param name="customerId">The id of the customer to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Customer"/>.</returns>
        public virtual async Task<Customer> GetAsync(long customerId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"customers/{customerId}.json", Method.GET, "customer");

            if(string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<Customer>(_RestClient, req);
        }

        /// <summary>
        /// Searches through a shop's customers for the given search query. 
        /// </summary>
        /// <param name="query">The search query, in format of 'Bob country:United States', which would search for customers in the United States with a name like 'Bob'.</param>
        /// <param name="order">An optional string to order the results, in format of 'field_name DESC'. Default is 'last_order_date DESC'.</param>
        /// <param name="filter">Options for filtering the results.</param>
        /// <returns>A list of matching customers.</returns>
        public virtual async Task<IEnumerable<Customer>> SearchAsync(string query, string order = null, ListFilter filter = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("customers/search.json", Method.GET, "customers");
            req.AddQueryParameter("query", query);

            if (string.IsNullOrEmpty(order) == false) req.AddQueryParameter("order", order);
            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.QueryString));

            return await RequestEngine.ExecuteRequestAsync<List<Customer>>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="Customer"/> on the store.
        /// </summary>
        /// <param name="customer">A new <see cref="Customer"/>. Id should be set to null.</param>
        /// <param name="options">Options for creating the customer.</param>
        /// <returns>The new <see cref="Customer"/>.</returns>
        public virtual async Task<Customer> CreateAsync(Customer customer, CustomerCreateOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("customers.json", Method.POST, "customer");

            var customerBody = customer.ToDictionary();

            if (options != null)
            {
                foreach (var keyValuePair in options.ToDictionary())
                {
                    customerBody.Add(keyValuePair);
                }
            }

            var requestBody = new { customer = customerBody };

            req.AddJsonBody(requestBody);

            return await RequestEngine.ExecuteRequestAsync<Customer>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="Customer"/>. Id must not be null.
        /// </summary>
        /// <param name="customer">The <see cref="Customer"/> to update.</param>
        /// <param name="options">Options for updating the customer.</param>
        /// <returns>The updated <see cref="Customer"/>.</returns>
        public virtual async Task<Customer> UpdateAsync(Customer customer, CustomerUpdateOptions options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"customers/{customer.Id.Value}.json", Method.PUT, "customer");

            var customerBody = customer.ToDictionary();

            if (options != null)
            {
                foreach (var keyValuePair in options.ToDictionary())
                {
                    customerBody.Add(keyValuePair);
                }
            }

            var requestBody = new { customer = customerBody };

            req.AddJsonBody(requestBody);

            return await RequestEngine.ExecuteRequestAsync<Customer>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a customer with the given Id.
        /// </summary>
        /// <param name="customerId">The customer object's Id.</param>
        public virtual async Task DeleteAsync(long customerId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"customers/{customerId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion
    }
}
