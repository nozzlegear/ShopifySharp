using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify customers.
    /// </summary>
    public class CustomerService : ShopifyService, ICustomerService
    {
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomerService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<int> CountAsync(CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<int>($"customers/count.json", "count", cancellationToken: cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Customer>> ListAsync(ListFilter<Customer> filter = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetListAsync("customers.json", "customers", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Customer>> ListAsync(CustomerListFilter filter, CancellationToken cancellationToken = default) =>
            await ListAsync(filter?.AsListFilter(), cancellationToken);

        /// <inheritdoc />
        public virtual async Task<Customer> GetAsync(long customerId, string fields = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<Customer>($"customers/{customerId}.json", "customer", fields, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Customer>> SearchAsync(ListFilter<Customer> filter, CancellationToken cancellationToken = default) =>
            await ExecuteGetListAsync("customers/search.json", "customers", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Customer>> SearchAsync(CustomerSearchListFilter filter, CancellationToken cancellationToken = default) =>
            await SearchAsync(filter?.AsListFilter(), cancellationToken);

        /// <inheritdoc />
        public virtual async Task<Customer> CreateAsync(Customer customer, CustomerCreateOptions options = null, CancellationToken cancellationToken = default)
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

            var response = await ExecuteRequestAsync<Customer>(req, HttpMethod.Post, cancellationToken, content, "customer");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<Customer> UpdateAsync(long customerId, Customer customer, CustomerUpdateOptions options = null, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"customers/{customerId}.json");
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

            var response = await ExecuteRequestAsync<Customer>(req, HttpMethod.Put, cancellationToken, content, "customer");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task DeleteAsync(long customerId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"customers/{customerId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public virtual async Task<CustomerInvite> SendInviteAsync(long customerId, CustomerInvite invite = null, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"customers/{customerId}/send_invite.json");

            var content = new JsonContent(new
            {
                customer_invite = invite
            });

            var response = await ExecuteRequestAsync<CustomerInvite>(req, HttpMethod.Post, cancellationToken, content, "customer_invite");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<string> GetAccountActivationUrl(long customerid, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"customers/{customerid}/account_activation_url.json");
            var response = await ExecuteRequestAsync(req, HttpMethod.Post, cancellationToken);

            return response.Result.SelectToken("account_activation_url").ToString();
        }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<Order>> ListOrdersForCustomerAsync(long customerId, CustomerOrderListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<List<Order>>($"customers/{customerId}/orders.json", "orders", filter, cancellationToken);
        }
    }
}