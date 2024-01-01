using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify customers addresses.
    /// </summary>
    public class CustomerAddressService : ShopifyService, ICustomerAddressService
    {
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomerAddressService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
        internal CustomerAddressService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
        /// <inheritdoc />
        public virtual async Task<ListResult<Address>> ListAsync(long customerId, ListFilter<Address> filter = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetListAsync($"customers/{customerId}/addresses.json", "addresses", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<Address> GetAsync(long customerId, long addressId, string fields = null, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"customers/{customerId}/addresses/{addressId}.json");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<Address>(req, HttpMethod.Get, cancellationToken, rootElement: "customer_address");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<Address> CreateAsync(long customerId, Address address, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"customers/{customerId}/addresses.json");
            var addressBody = address.ToDictionary();
            var content = new JsonContent(new
            {
                address = addressBody
            });

            var response = await ExecuteRequestAsync<Address>(req, HttpMethod.Post, cancellationToken, content, "customer_address");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<Address> UpdateAsync(long customerId, long addressId, Address address, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"customers/{customerId}/addresses/{addressId}.json");
            var addressBody = address.ToDictionary();

            var content = new JsonContent(new
            {
                address = addressBody
            });

            var response = await ExecuteRequestAsync<Address>(req, HttpMethod.Put, cancellationToken, content, "customer_address");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task DeleteAsync(long customerId, long addressId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"customers/{customerId}/addresses/{addressId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }

        /// <inheritdoc />
        public virtual async Task<Address> SetDefault(long customerId, long addressId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"customers/{customerId}/addresses/{addressId}/default.json");

            var response = await ExecuteRequestAsync<Address>(req, HttpMethod.Put, cancellationToken, rootElement: "customer_address");
            return response.Result;
        }
    }
}