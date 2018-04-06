using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating a Shopify inventory items.
    /// </summary>
    public class InventoryLevelService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="InventoryLevelService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public InventoryLevelService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of inventory items
        /// </summary>
        /// <param name="filterOptions">Options for filtering the result. InventoryItemIds and/or LocationIds must be populated.</param>
        public virtual async Task<IEnumerable<InventoryLevel>> ListAsync(InventoryLevelFilter filterOptions)
        {
            var req = PrepareRequest($"inventory_levels.json");

            if (filterOptions != null)
            {
                req.QueryParams.AddRange(filterOptions.ToParameters());
            }

            return await ExecuteRequestAsync<List<InventoryLevel>>(req, HttpMethod.Get, rootElement: "inventory_levels");
        }
    }
}
