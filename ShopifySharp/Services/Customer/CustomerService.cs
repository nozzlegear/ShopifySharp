using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify customers.
    /// </summary>
    public class CustomerService: ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CustomerService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomerService(string myShopifyUrl, string shopAccessToken): base (myShopifyUrl, shopAccessToken) { }
        
        /// <summary>
        /// Gets a count of all of the shop's customers.
        /// </summary>
        /// <returns>The count of all customers for the shop.</returns>
        public virtual async Task<int> CountAsync()
        {
            var req = PrepareRequest("customers/count.json");
            
            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's customers.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<Customer>> ListAsync(ListFilter filter = null)
        {
            var req = PrepareRequest("customers.json");

            if (filter != null)
            {
                req.Url.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<List<Customer>>(req, HttpMethod.Get, rootElement: "customers");
        }

        /// <summary>
        /// Retrieves the <see cref="Customer"/> with the given id.
        /// </summary>
        /// <param name="customerId">The id of the customer to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Customer"/>.</returns>
        public virtual async Task<Customer> GetAsync(long customerId, string fields = null)
        {
            var req = PrepareRequest($"customers/{customerId}.json");

            if(string.IsNullOrEmpty(fields) == false)
            {
                req.Url.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<Customer>(req, HttpMethod.Get, rootElement: "customer");
        }

        /// <summary>
        /// Searches through a shop's customers for the given search query. NOTE: Assumes the <paramref name="query"/> and <paramref name="order"/> strings are not encoded.
        /// </summary>
        /// <param name="query">The (unencoded) search query, in format of 'Bob country:United States', which would search for customers in the United States with a name like 'Bob'.</param>
        /// <param name="order">An (unencoded) optional string to order the results, in format of 'field_name DESC'. Default is 'last_order_date DESC'.</param>
        /// <param name="filter">Options for filtering the results.</param>
        /// <returns>A list of matching customers.</returns>
        public virtual async Task<IEnumerable<Customer>> SearchAsync(string query, string order = null, ListFilter filter = null)
        {
            var req = PrepareRequest("customers/search.json");
            req.Url.QueryParams.Add("query", query, false);

            if (! string.IsNullOrEmpty(order))
            {
                req.Url.QueryParams.Add("order", order, false);
            }

            if (filter != null)
            {
                req.Url.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<List<Customer>>(req, HttpMethod.Get, rootElement: "customers");
        }

        /// <summary>
        /// Creates a new <see cref="Customer"/> on the store.
        /// </summary>
        /// <param name="customer">A new <see cref="Customer"/>. Id should be set to null.</param>
        /// <param name="options">Options for creating the customer.</param>
        /// <returns>The new <see cref="Customer"/>.</returns>
        public virtual async Task<Customer> CreateAsync(Customer customer, CustomerCreateOptions options = null)
        {
            var req = PrepareRequest("customers.json");
            var body = customer.ToDictionary();

            if (options != null)
            {
                foreach (var keyValuePair in options.ToDictionary())
                {
                    body.Add(keyValuePair);
                }
            }

            var content = new JsonContent(new
            {
                customer = body
            });

            return await ExecuteRequestAsync<Customer>(req, HttpMethod.Post, content, "customer");
        }

        /// <summary>
        /// Updates the given <see cref="Customer"/>. Id must not be null.
        /// </summary>
        /// <param name="customer">The <see cref="Customer"/> to update.</param>
        /// <param name="options">Options for updating the customer.</param>
        /// <returns>The updated <see cref="Customer"/>.</returns>
        public virtual async Task<Customer> UpdateAsync(Customer customer, CustomerUpdateOptions options = null)
        {
            var req = PrepareRequest($"customers/{customer.Id.Value}.json");
            var body = customer.ToDictionary();

            if (options != null)
            {
                foreach (var keyValuePair in options.ToDictionary())
                {
                    body.Add(keyValuePair);
                }
            }

            var content = new JsonContent(new
            {
                customer = body
            });

            return await ExecuteRequestAsync<Customer>(req, HttpMethod.Put, content, "customer");
        }

        /// <summary>
        /// Deletes a customer with the given Id.
        /// </summary>
        /// <param name="customerId">The customer object's Id.</param>
        public virtual async Task DeleteAsync(long customerId)
        {
            var req = PrepareRequest($"customers/{customerId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
