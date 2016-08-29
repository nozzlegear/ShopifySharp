using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's Location API.
    /// </summary>
    public class ShopifyLocationService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyLocationService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyLocationService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Retrieves the <see cref="ShopifyLocation"/> with the given id.
        /// </summary>
        /// <param name="id">The id of the charge to retrieve.</param>
        /// <returns>The <see cref="ShopifyLocation"/>.</returns>
        public async Task<ShopifyLocation> GetAsync(long id)
        {
            var req = RequestEngine.CreateRequest($"locations/{id}.json", Method.GET, "location");           

            return await RequestEngine.ExecuteRequestAsync<ShopifyLocation>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves a list of all <see cref="ShopifyLocation"/> objects.
        /// </summary>
        /// <returns>The list of <see cref="ShopifyLocation"/> objects.</returns>
        public async Task<IEnumerable<ShopifyLocation>> ListAsync()
        {
            var req = RequestEngine.CreateRequest($"locations.json", Method.GET, "locations");

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyLocation>>(_RestClient, req);
        }

        #endregion
    }
}
