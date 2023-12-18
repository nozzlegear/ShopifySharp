using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    public class PolicyService : ShopifyService, IPolicyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="PolicyService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public PolicyService(string myShopifyUrl, string shopAccessToken): base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<Policy>> ListAsync(CancellationToken cancellationToken = default)
        {
            var request = BuildRequestUri("policies.json");
            var response = await ExecuteRequestAsync<List<Policy>>(request, HttpMethod.Get, cancellationToken, rootElement: "policies");

            return response.Result;
        }
    }
}