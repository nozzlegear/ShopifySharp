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
    public class CustomerAddressService: ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CustomerAddressService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomerAddressService(string myShopifyUrl, string shopAccessToken): base (myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of up to 250 of the shop customers's addresses.
        /// </summary>
        /// <param name="customerId">The id of the customer to retrieve.</param>
        /// <returns></returns>
        public virtual async Task<IEnumerable<Address>> ListAsync(long customerId, ListFilter filter = null)
        {
            var req = PrepareRequest($"customers/{customerId}/addresses.json");

            if (filter != null)
            {
                req.Url.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<List<Address>>(req, HttpMethod.Get, rootElement: "addresses");
        }

        /// <summary>
        /// Retrieves the <see cref="Address"/> with the given id.
        /// </summary>
        /// <param name="customerId">The id of the customer to retrieve.</param>
        /// <param name="addressId">The id of the customer address to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Address"/>.</returns>
        public virtual async Task<Address> GetAsync(long customerId, long addressId, string fields = null)
        {
            var req = PrepareRequest($"customers/{customerId}/addresses/{addressId}.json");

            if(string.IsNullOrEmpty(fields) == false)
            {
                req.Url.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<Address>(req, HttpMethod.Get, rootElement: "customer_address");
        }


        /// <summary>
        /// Creates a new <see cref="Address"/> on the store.
        /// </summary>
        /// <param name="customerId">The id of the customer to create address for.</param>
        /// <param name="address">A new <see cref="Address"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="Address"/>.</returns>
        public virtual async Task<Address> CreateAsync(long customerId, Address address)
        {
            var req = PrepareRequest($"customers/{customerId}/addresses.json");
            var addressBody = address.ToDictionary();
            var content = new JsonContent(new
            {
                address = addressBody
            });

            return await ExecuteRequestAsync<Address>(req, HttpMethod.Post, content, "customer_address");
        }

        /// <summary>
        /// Updates the given <see cref="Address"/>.
        /// </summary>
        /// <param name="customerId">Id of the customer object being updated.</param>
        /// <param name="addressId">Id of the address object being updated.</param>
        /// <param name="address">The <see cref="Address"/> to update.</param>
        /// <returns>The updated <see cref="Customer"/>.</returns>
        public virtual async Task<Address> UpdateAsync(long customerId, long addressId, Address address)
        {
            var req = PrepareRequest($"customers/{customerId}/addresses/{addressId}.json");
            var addressBody = address.ToDictionary();

            var content = new JsonContent(new
            {
                address = addressBody
            });

            return await ExecuteRequestAsync<Address>(req, HttpMethod.Put, content, "customer_address");
        }

        /// <summary>
        /// Deletes a address with the given Id from a customer.
        /// </summary>
        /// <param name="customerId">The customer object's Id.</param>
        /// <param name="addressId">The address object's Id.</param>
        public virtual async Task DeleteAsync(long customerId, long addressId)
        {
            var req = PrepareRequest($"customers/{customerId}/addresses/{addressId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }

        /// <summary>
        /// Sets the specified address as the default for a customer
        /// </summary>
        /// <param name="customerId">The customer object's Id.</param>
        /// <param name="addressId">The address object's Id.</param>
        /// <returns></returns>
        public virtual async Task<Address> SetDefault(long customerId, long addressId)
        {
            var req = PrepareRequest($"customers/{customerId}/addresses/{addressId}/default.json");

            return await ExecuteRequestAsync<Address>(req, HttpMethod.Put, rootElement: "customer_address");

        }

    }
}
