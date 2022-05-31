using System;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify saved searches.
    /// </summary>
    [Obsolete("Customer saved searches were deprecated in version 2022-04. Use the GraphQL customer Segment object instead.")]
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
        public virtual async Task<int> CountAsync(CustomerSavedSearchCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>($"{RootResource}/count.json", "count", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's customer saved searches.
        /// </summary>
        public virtual async Task<ListResult<CustomerSavedSearch>> ListAsync(ListFilter<CustomerSavedSearch> filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync($"{RootResource}.json", RootResource, filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's customer saved searches.
        /// </summary>
        public virtual async Task<ListResult<CustomerSavedSearch>> ListAsync(CustomerSavedSearchListFilter filter, CancellationToken cancellationToken = default)
        {
            return await ListAsync((ListFilter<CustomerSavedSearch>) filter, cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="Customer"/>s from the search with the given id.
        /// </summary>
        /// <param name="customerSearchId">The id of the customer to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Customer"/>.</returns>
        public virtual async Task<CustomerSavedSearch> GetAsync(long customerSearchId, string fields = null, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"{RootResource}/{customerSearchId}.json");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<CustomerSavedSearch>(req, HttpMethod.Get, cancellationToken, rootElement: RootElement);
            return response.Result;
        }

        /// <summary>
        /// Creates a new <see cref="Customer"/> on the store.
        /// </summary>
        /// <param name="customerSavedSearch">A new <see cref="CustomerSavedSearch"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Customer"/>.</returns>
        public virtual async Task<CustomerSavedSearch> CreateAsync(CustomerSavedSearch customerSavedSearch, CancellationToken cancellationToken = default)
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

            var response = await ExecuteRequestAsync<CustomerSavedSearch>(req, HttpMethod.Post, cancellationToken, content, RootElement);
            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="CustomerSavedSearch"/>.
        /// </summary>
        /// <param name="customerSavedSearchId">Id of the object being updated.</param>
        /// <param name="customerSavedSearch">The <see cref="CustomerSavedSearch"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<CustomerSavedSearch> UpdateAsync(long customerSavedSearchId, CustomerSavedSearch customerSavedSearch, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"{RootResource}/{customerSavedSearchId}.json");
            var body = customerSavedSearch.ToDictionary();

            var content = new JsonContent(new
            {
                customer_saved_search = body
            });

            var response = await ExecuteRequestAsync<CustomerSavedSearch>(req, HttpMethod.Put, cancellationToken, content, RootElement);
            return response.Result;
        }

        /// <summary>
        /// Deletes a customer with the given Id.
        /// </summary>
        /// <param name="customerSavedSearchId">The customer object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual Task DeleteAsync(long customerSavedSearchId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"{RootResource}/{customerSavedSearchId}.json");

            return ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }

        /// <summary>
        /// Returns a list of all <see cref="Customer"/> that are in the saved search.
        /// </summary>
        /// <param name="customerSavedSearchId">Id of the Customer Saved Search.</param>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<IEnumerable<Customer>> GetCustomersFromSavedSearchAsync(long customerSavedSearchId, CustomerSavedSearchFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<List<Customer>>($"{RootResource}/{customerSavedSearchId}/customers.json", "customers", filter, cancellationToken);
        }
    }
}
