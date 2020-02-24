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
        /// <returns>The count of all customers for the shop.</returns>
        public virtual async Task<int> CountAsync(CountFilter filter = null)
        {
            var req = PrepareRequest("customers/count.json");

            //Add optional parameters to request
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            var response = await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
            return response.Result;
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's customers.
        /// </summary>
        public virtual async Task<IListResult<Customer>> ListAsync(IListFilter<Customer> filter)
        {
            var req = PrepareRequest("customers.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<Customer>>(req, HttpMethod.Get, rootElement: "customers");

            return ParseLinkHeaderToListResult(response);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's customers.
        /// </summary>
        public virtual async Task<IListResult<Customer>> ListAsync(CustomerListFilter filter)
        {
            return await ListAsync((IListFilter<Customer>) filter);
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

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<Customer>(req, HttpMethod.Get, rootElement: "customer");
            return response.Result;
        }

        /// <summary>
        /// Searches through a shop's customers for the given search query. NOTE: Assumes the <paramref name="query"/> and <paramref name="order"/> strings are not encoded.
        /// </summary>
        /// <param name="query">The (unencoded) search query, in format of 'Bob country:United States', which would search for customers in the United States with a name like 'Bob'.</param>
        /// <param name="order">An (unencoded) optional string to order the results, in format of 'field_name DESC'. Default is 'last_order_date DESC'.</param>
        /// <param name="filter">Options for filtering the results.</param>
        /// <returns>A list of matching customers.</returns>
        public virtual async Task<IEnumerable<Customer>> SearchAsync(string query, string order = null, ListFilter<Customer> filter = null)
        {
            throw new NotImplementedException();
            // var req = PrepareRequest("customers/search.json");
            // req.QueryParams.Add("query", query);
            //
            // if (!string.IsNullOrEmpty(order))
            // {
            //     req.QueryParams.Add("order", order);
            // }
            //
            // if (filter != null)
            // {
            //     req.QueryParams.AddRange(filter.ToParameters());
            // }
            //
            // return await ExecuteRequestAsync<List<Customer>>(req, HttpMethod.Get, rootElement: "customers");
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

            var response = await ExecuteRequestAsync<Customer>(req, HttpMethod.Post, content, "customer");
            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="Customer"/>.
        /// </summary>
        /// <param name="customerId">Id of the object being updated.</param>
        /// <param name="customer">The <see cref="Customer"/> to update.</param>
        /// <param name="options">Options for updating the customer.</param>
        /// <returns>The updated <see cref="Customer"/>.</returns>
        public virtual async Task<Customer> UpdateAsync(long customerId, Customer customer, CustomerUpdateOptions options = null)
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

            var response = await ExecuteRequestAsync<Customer>(req, HttpMethod.Put, content, "customer");
            return response.Result;
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


        /// <summary>
        /// Send an invite by email to activate a customers account.
        /// </summary>
        /// <param name="customerId">The customer object's Id.</param>
        /// <param name="invite">Options for the invite email request</param>
        /// <returns></returns>
        public virtual async Task<CustomerInvite> SendInviteAsync(long customerId, CustomerInvite invite = null)
        {
            var req = PrepareRequest($"customers/{customerId}/send_invite.json");

            var content = new JsonContent(new
            {
                customer_invite = invite
            });

            var response = await ExecuteRequestAsync<CustomerInvite>(req, HttpMethod.Post, content, "customer_invite");
            return response.Result;
        }

        /// <summary>
        /// Generate and retrieve an account activation URL for a customer who is not yet enabled.
        /// This is useful if you've imported a large number of customers and want to send them activation emails all at once (using this approach, you'll need to generate and send the activation emails yourself).
        /// The account activation URL generated by this endpoint is one time use and will expire after 7 days.
        /// If you make a new POST request to this endpoint, a new URL will be generated which will be again valid for 7 days, but the previous URL will no longer be valid.
        /// </summary>
        /// <param name="customerId">The customer object's Id.</param>
        /// <returns></returns>
        public virtual async Task<string> GetAccountActivationUrl(long customerid)
        {
            var req = PrepareRequest($"customers/{customerid}/account_activation_url.json");
            var response = await ExecuteRequestAsync(req, HttpMethod.Post);

            return response.Result.SelectToken("account_activation_url").ToString();
        }
    }
}
