using System.Net.Http;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's Location API.
    /// </summary>
    public class LocationService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="LocationService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public LocationService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken)
        {
        }

        /// <summary>
        /// Retrieves the <see cref="Location"/> with the given id.
        /// </summary>
        /// <param name="id">The id of the charge to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Location"/>.</returns>
        public virtual async Task<Location> GetAsync(long id, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<Location>($"locations/{id}.json", "location", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the locations.
        /// </summary>
        public virtual async Task<ListResult<Location>> ListAsync(ListFilter<Location> filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("locations.json", "locations", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the locations.
        /// </summary>
        public virtual async Task<ListResult<Location>> ListAsync(LocationListFilter filter, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }
    }
}
