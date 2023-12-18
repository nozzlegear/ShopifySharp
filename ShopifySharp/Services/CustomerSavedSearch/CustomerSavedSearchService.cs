using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify saved searches.
    /// </summary>
    [Obsolete("Customer saved searches were deprecated in version 2022-04. Use the GraphQL customer Segment object instead.")]
    public class CustomerSavedSearchService : ShopifyService, ICustomerSavedSearchService
    {
        private const string RootResource = "customer_saved_searches";
        private const string RootElement = "customer_saved_search";

        /// <summary>
        /// Creates a new instance of <see cref="CustomerService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomerSavedSearchService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<int> CountAsync(CustomerSavedSearchCountFilter filter = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<int>($"{RootResource}/count.json", "count", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<CustomerSavedSearch>> ListAsync(ListFilter<CustomerSavedSearch> filter = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetListAsync($"{RootResource}.json", RootResource, filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<CustomerSavedSearch>> ListAsync(CustomerSavedSearchListFilter filter, CancellationToken cancellationToken = default) =>
            await ListAsync((ListFilter<CustomerSavedSearch>) filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<CustomerSavedSearch> GetAsync(long customerSearchId, string fields = null, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"{RootResource}/{customerSearchId}.json");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<CustomerSavedSearch>(req, HttpMethod.Get, cancellationToken, rootElement: RootElement);
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<CustomerSavedSearch> CreateAsync(CustomerSavedSearch customerSavedSearch, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(customerSavedSearch.Name))
            {
                throw new ArgumentException("Name property is required", nameof(customerSavedSearch));
            }

            var req = BuildRequestUri($"{RootResource}.json");
            var body = customerSavedSearch.ToDictionary();

            var content = new JsonContent(new
            {
                customer_saved_search = body
            });

            var response = await ExecuteRequestAsync<CustomerSavedSearch>(req, HttpMethod.Post, cancellationToken, content, RootElement);
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<CustomerSavedSearch> UpdateAsync(long customerSavedSearchId, CustomerSavedSearch customerSavedSearch, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"{RootResource}/{customerSavedSearchId}.json");
            var body = customerSavedSearch.ToDictionary();

            var content = new JsonContent(new
            {
                customer_saved_search = body
            });

            var response = await ExecuteRequestAsync<CustomerSavedSearch>(req, HttpMethod.Put, cancellationToken, content, RootElement);
            return response.Result;
        }

        /// <inheritdoc />
        public virtual Task DeleteAsync(long customerSavedSearchId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"{RootResource}/{customerSavedSearchId}.json");

            return ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<Customer>> GetCustomersFromSavedSearchAsync(long customerSavedSearchId, CustomerSavedSearchFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<List<Customer>>($"{RootResource}/{customerSavedSearchId}/customers.json", "customers", filter, cancellationToken);
        }
    }
}
