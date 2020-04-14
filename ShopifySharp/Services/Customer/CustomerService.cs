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
    /// A service for manipulating Shopify customers.
    /// </summary>
    public class CustomerService : ShopifyService
    {
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomerService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's customers.
        /// </summary>
        /// <remarks>
        /// According to Shopify's documentation, the count endpoint does not support any parameters. 
        /// </remarks>
        public virtual async Task<int> CountAsync(CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>($"customers/count.json", "count", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's customers.
        /// </summary>
        public virtual async Task<ListResult<Customer>> ListAsync(ListFilter<Customer> filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("customers.json", "customers", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's customers.
        /// </summary>
        public virtual async Task<ListResult<Customer>> ListAsync(CustomerListFilter filter, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="Customer"/> with the given id.
        /// </summary>
        /// <param name="customerId">The id of the customer to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Customer"/>.</returns>
        public virtual async Task<Customer> GetAsync(long customerId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<Customer>($"customers/{customerId}.json", "customer", fields, cancellationToken);
        }

        /// <summary>
        /// Searches through a shop's customers for the given search query. NOTE: Assumes the <paramref name="query"/> and <paramref name="order"/> strings are not encoded.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<Customer>> SearchAsync(ListFilter<Customer> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("customers/search.json", "customers", filter, cancellationToken);
        }

        /// <summary>
        /// Searches through a shop's customers for the given search query. NOTE: Assumes the <paramref name="query"/> and <paramref name="order"/> strings are not encoded.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<Customer>> SearchAsync(CustomerSearchListFilter filter, CancellationToken cancellationToken = default)
        {
            return await SearchAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Creates a new <see cref="Customer"/> on the store.
        /// </summary>
        /// <param name="customer">A new <see cref="Customer"/>. Id should be set to null.</param>
        /// <param name="options">Options for creating the customer.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Customer"/>.</returns>
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

        /// <summary>
        /// Updates the given <see cref="Customer"/>.
        /// </summary>
        /// <param name="customerId">Id of the object being updated.</param>
        /// <param name="customer">The <see cref="Customer"/> to update.</param>
        /// <param name="options">Options for updating the customer.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Customer"/>.</returns>
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

        /// <summary>
        /// Deletes a customer with the given Id.
        /// </summary>
        /// <param name="customerId">The customer object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long customerId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"customers/{customerId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken: cancellationToken);
        }


        /// <summary>
        /// Send an invite by email to activate a customers account.
        /// </summary>
        /// <param name="customerId">The customer object's Id.</param>
        /// <param name="invite">Options for the invite email request</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns></returns>
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

        /// <summary>
        /// Generate and retrieve an account activation URL for a customer who is not yet enabled.
        /// This is useful if you've imported a large number of customers and want to send them activation emails all at once (using this approach, you'll need to generate and send the activation emails yourself).
        /// The account activation URL generated by this endpoint is one time use and will expire after 7 days.
        /// If you make a new POST request to this endpoint, a new URL will be generated which will be again valid for 7 days, but the previous URL will no longer be valid.
        /// </summary>
        /// <param name="customerId">The customer object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns></returns>
        public virtual async Task<string> GetAccountActivationUrl(long customerid, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"customers/{customerid}/account_activation_url.json");
            var response = await ExecuteRequestAsync(req, HttpMethod.Post, cancellationToken);

            return response.Result.SelectToken("account_activation_url").ToString();
        }

        /// <summary>
        /// Gets a list of the customer's orders.
        /// </summary>
        /// <param name="customerId">The id of the customer to list orders for.</param>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <remarks>
        /// Previously this was part of the OrderService, and was documented under the Orders API in Shopify.
        /// Shopify appears to have moved it to the Customers API.
        /// https://shopify.dev/docs/admin-api/rest/reference/customers/customer#orders-2020-01
        /// This list does not appear to be paginated. 
        /// </remarks>
        public virtual async Task<IEnumerable<Order>> ListOrdersForCustomerAsync(long customerId, CustomerOrderListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<List<Order>>($"customers/{customerId}/orders.json", "orders", filter, cancellationToken);
        }
    }
}
