using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopService: ShopifyService, IShopService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopService(string myShopifyUrl, string shopAccessToken): base(myShopifyUrl, shopAccessToken) { }
        
        /// <inheritdoc />
        public virtual async Task<Shop> GetAsync(CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<Shop>("shop.json", "shop", cancellationToken: cancellationToken);

        /// <inheritdoc />
        public virtual async Task UninstallAppAsync(CancellationToken cancellationToken = default)
        {
            var request = PrepareRequest("api_permissions/current.json");

            await ExecuteRequestAsync(request, HttpMethod.Delete, cancellationToken: cancellationToken);
        }
    }
}