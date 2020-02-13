using System;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify saved searches.
    /// </summary>
    public class CustomerSavedSearchService : ShopifyService
    {
        private const string RootResource = "customer_saved_searches";
        private const string RootElement = "customer_saved_search";

        /// <summary>
        /// Creates a new instance of <see cref="CustomerService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomerSavedSearchService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's customers.
        /// </summary>
        /// <returns>The count of all customers for the shop.</returns>
        public virtual async Task<int> CountAsync()
        {
            var req = PrepareRequest($"{RootResource}/count.json");

            var response = await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
            return response.Result;
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's customer saved searches.
        /// </summary>
        public virtual async Task<IListResult<CustomerSavedSearch>> ListAsync(IListFilter filter)
        {
            var req = PrepareRequest($"{RootResource}.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<CustomerSavedSearch>>(req, HttpMethod.Get, rootElement: RootResource);

            return ParseLinkHeaderToListResult(response);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's customer saved searches.
        /// </summary>
        public virtual async Task<IListResult<CustomerSavedSearch>> ListAsync(CustomerSavedSearchListFilter filter)
        {
            return await ListAsync((IListFilter) filter);
        }

        /// <summary>
        /// Retrieves the <see cref="Customer"/>s from the search with the given id.
        /// </summary>
        /// <param name="customerSearchId">The id of the customer to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Customer"/>.</returns>
        public virtual async Task<CustomerSavedSearch> GetAsync(long customerSearchId, string fields = null)
        {
            var req = PrepareRequest($"{RootResource}/{customerSearchId}.json");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<CustomerSavedSearch>(req, HttpMethod.Get, rootElement: RootElement);
            return response.Result;
        }

        /// <summary>
        /// Searches through a shop's customers for the given search query. NOTE: Assumes the <paramref name="query"/> and <paramref name="order"/> strings are not encoded.
        /// </summary>
        /// <param name="query">The (unencoded) search query, in format of 'Bob country:United States', which would search for customers in the United States with a name like 'Bob'.</param>
        /// <param name="sinceId">Restricts results to after a given id.</param>
        /// <param name="filter">Options for filtering the results.</param>
        /// <returns>A list of matching customers.</returns>
        public virtual Task<List<CustomerSavedSearch>> SearchAsync(string query, string sinceId = null, ListFilter filter = null)
        {
            throw new NotImplementedException();
            // var req = PrepareRequest($"{RootResource}.json");
            // req.QueryParams.Add("query", query);
            //
            // if (!string.IsNullOrEmpty(sinceId))
            // {
            //     req.QueryParams.Add("since_id", sinceId);
            // }
            //
            // if (filter != null)
            // {
            //     req.QueryParams.AddRange(filter.ToParameters());
            // }
            //
            // return ExecuteRequestAsync<List<CustomerSavedSearch>>(req, HttpMethod.Get, rootElement: RootResource);
        }

        /// <summary>
        /// Creates a new <see cref="Customer"/> on the store.
        /// </summary>
        /// <param name="customerSavedSearch">A new <see cref="CustomerSavedSearch"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="Customer"/>.</returns>
        public virtual async Task<CustomerSavedSearch> CreateAsync(CustomerSavedSearch customerSavedSearch)
        {
            if (string.IsNullOrWhiteSpace(customerSavedSearch.Name))
            {
                throw new ArgumentException("Name property is required", nameof(customerSavedSearch));
            }

            var req = PrepareRequest($"{RootResource}.json");
            var body = customerSavedSearch.ToDictionary();

            var content = new JsonContent(new
            {
                customer_saved_search = body
            });

            var response = await ExecuteRequestAsync<CustomerSavedSearch>(req, HttpMethod.Post, content, RootElement);
            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="CustomerSavedSearch"/>.
        /// </summary>
        /// <param name="customerSavedSearchId">Id of the object being updated.</param>
        /// <param name="customerSavedSearch">The <see cref="CustomerSavedSearch"/> to update.</param>
        public virtual async Task<CustomerSavedSearch> UpdateAsync(long customerSavedSearchId, CustomerSavedSearch customerSavedSearch)
        {
            var req = PrepareRequest($"{RootResource}/{customerSavedSearchId}.json");
            var body = customerSavedSearch.ToDictionary();

            var content = new JsonContent(new
            {
                customer_saved_search = body
            });

            var response = await ExecuteRequestAsync<CustomerSavedSearch>(req, HttpMethod.Put, content, RootElement);
            return response.Result;
        }

        /// <summary>
        /// Deletes a customer with the given Id.
        /// </summary>
        /// <param name="customerSavedSearchId">The customer object's Id.</param>
        public virtual Task DeleteAsync(long customerSavedSearchId)
        {
            var req = PrepareRequest($"{RootResource}/{customerSavedSearchId}.json");

            return ExecuteRequestAsync(req, HttpMethod.Delete);
        }

        /// <summary>
        /// Returns a list of all <see cref="Customer"/> that are in the saved search
        /// </summary>
        /// <param name="customerSavedSearchId">Id of the Customer Saved Search</param>
        /// <returns></returns>
        public Task<List<Customer>> GetCustomersFromSavedSearch(long customerSavedSearchId, string query = null, ListFilter filter = null)
        {
            throw new NotImplementedException();
            // var req = PrepareRequest($"{RootResource}/{customerSavedSearchId}/customers.json");
            //
            // if (query != null)
            // {
            //     req.QueryParams.Add("query", query);
            // }
            //
            // if (filter != null)
            // {
            //     req.QueryParams.AddRange(filter.ToParameters());
            // }
            //
            // return ExecuteRequestAsync<List<Customer>>(req, HttpMethod.Get, rootElement: "customers");
        }
    }
}
