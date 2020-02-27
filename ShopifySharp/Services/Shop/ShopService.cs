using System.Net.Http;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopService: ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopService(string myShopifyUrl, string shopAccessToken): base(myShopifyUrl, shopAccessToken) { }
        
        /// <summary>
        /// Gets the shop's data.
        /// </summary>
        public virtual async Task<Shop> GetAsync()
        {
            return await ExecuteGetAsync<Shop>("shop.json", "shop");
        }

        /// <summary>
        /// Forces the shop to uninstall your Shopify app. Uninstalling an application is an irreversible operation. Be entirely sure that you no longer need to make API calls for the shop in which the application has been installed.
        /// </summary>
        public virtual async Task UninstallAppAsync()
        {
            var request = PrepareRequest("api_permissions/current.json");

            await ExecuteRequestAsync(request, HttpMethod.Delete);
        }
    }
}
