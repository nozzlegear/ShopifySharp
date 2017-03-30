using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's Location API.
    /// </summary>
    public class LocationService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="LocationService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public LocationService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Retrieves the <see cref="Location"/> with the given id.
        /// </summary>
        /// <param name="id">The id of the charge to retrieve.</param>
        /// <returns>The <see cref="Location"/>.</returns>
        public virtual async Task<Location> GetAsync(long id)
        {
            var req = RequestEngine.CreateRequest($"locations/{id}.json", Method.GET, "location");           

            return await RequestEngine.ExecuteRequestAsync<Location>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves a list of all <see cref="Location"/> objects.
        /// </summary>
        /// <returns>The list of <see cref="Location"/> objects.</returns>
        public virtual async Task<IEnumerable<Location>> ListAsync()
        {
            var req = RequestEngine.CreateRequest($"locations.json", Method.GET, "locations");

            return await RequestEngine.ExecuteRequestAsync<List<Location>>(_RestClient, req);
        }

        #endregion
    }
}
