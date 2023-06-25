using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating a Shopify inventory items.
    /// </summary>
    public class InventoryLevelService : ShopifyService, IInventoryLevelService
    {
        /// <summary>
        /// Creates a new instance of <see cref="InventoryLevelService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public InventoryLevelService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

		/// <inheritdoc />
        public virtual async Task<ListResult<InventoryLevel>> ListAsync(ListFilter<InventoryLevel> filter, CancellationToken cancellationToken = default) =>
			await ExecuteGetListAsync($"inventory_levels.json", "inventory_levels", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<InventoryLevel>> ListAsync(InventoryLevelListFilter filter, CancellationToken cancellationToken = default) =>
			await ListAsync(filter?.AsListFilter(), cancellationToken);

        /// <inheritdoc />
        public virtual async Task DeleteAsync(long inventoryItemId, long locationId, CancellationToken cancellationToken = default) =>
			await ExecuteRequestAsync(PrepareRequest($"inventory_levels.json?inventory_item_id={inventoryItemId}&location_id={locationId}"), HttpMethod.Delete, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<InventoryLevel> SetAsync(InventoryLevel updatedInventoryLevel, bool disconnectIfNecessary = false, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"inventory_levels/set.json");
            var body = updatedInventoryLevel.ToDictionary();
            
            body.Add("disconnect_if_necessary", disconnectIfNecessary);
            
            var content = new JsonContent(body);
            var response = await ExecuteRequestAsync<InventoryLevel>(req, HttpMethod.Post, cancellationToken, content, "inventory_level");
            
            return response.Result;
        }

		/// <inheritdoc />
        public virtual async Task<InventoryLevel> AdjustAsync(InventoryLevelAdjust updatedInventoryLevel, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"inventory_levels/adjust.json");
            var body = updatedInventoryLevel.ToDictionary();
            var content = new JsonContent(body);
            var response = await ExecuteRequestAsync<InventoryLevel>(req, HttpMethod.Post, cancellationToken, content, "inventory_level");
            
            return response.Result;
        }

		/// <inheritdoc />
        public virtual async Task<InventoryLevel> ConnectAsync(long inventoryItemId, long locationId, bool relocateIfNecessary = false, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"inventory_levels/connect.json");
            var content = new JsonContent(new
            {
                location_id = locationId,
                inventory_item_id = inventoryItemId,
                relocate_if_necessary = relocateIfNecessary
            });
            var response = await ExecuteRequestAsync<InventoryLevel>(req, HttpMethod.Post, cancellationToken, content, "inventory_level");
            
            return response.Result;
        }
    }
}