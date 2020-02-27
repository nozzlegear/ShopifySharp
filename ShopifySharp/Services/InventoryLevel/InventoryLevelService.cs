using System;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

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
        /// Gets a list of inventory items. 
        /// </summary>
        public virtual async Task<ListResult<InventoryLevel>> ListAsync(ListFilter<InventoryLevel> filter)
        {
            return await ExecuteGetListAsync($"inventory_levels.json", "inventory_levels", filter);
        }
        
        /// <summary>
        /// Gets a list of inventory items
        /// </summary>
        public virtual async Task<ListResult<InventoryLevel>> ListAsync(InventoryLevelListFilter filter)
        {
            return await ListAsync(filter.AsListFilter());
        }

        /// <summary>
        /// Deletes inventory for an item at specified location.  All items must keep inventory at at least one location.
        /// </summary>
        /// <param name="inventoryItemId">The ID of the inventory item.</param>
        /// <param name="locationId">The ID of the location that the inventory level belongs to.</param>
        public virtual async Task DeleteAsync(long inventoryItemId, long locationId)
        {
            await ExecuteRequestAsync(PrepareRequest($"inventory_levels.json?inventory_item_id={inventoryItemId}&location_id={locationId}"), HttpMethod.Delete);
        }

        /// <summary>
        /// Updates the given <see cref="InventoryLevel"/>.
        /// </summary>
        /// <param name="updatedInventoryLevel">The updated <see cref="InventoryLevel"/></param>
        /// <param name="disconnectIfNecessary">Whether inventory for any previously connected locations will be set to 0 and the locations disconnected. This property is ignored when no fulfillment service is involved.</param>
        /// <returns>The updated <see cref="InventoryLevel"/></returns>
        public virtual async Task<InventoryLevel> SetAsync(InventoryLevel updatedInventoryLevel, bool disconnectIfNecessary = false)
        {
            var req = PrepareRequest($"inventory_levels/set.json");
            var body = updatedInventoryLevel.ToDictionary();
            
            body.Add("disconnect_if_necessary", disconnectIfNecessary);
            
            var content = new JsonContent(body);
            var response = await ExecuteRequestAsync<InventoryLevel>(req, HttpMethod.Post, content, "inventory_level");
            
            return response.Result;
        }

        /// <summary>
        /// Adjusts the given <see cref="InventoryLevel"/>.
        /// </summary>
        /// <param name="updatedInventoryLevel">The updated <see cref="InventoryLevel"/></param>
        /// <returns>The updated <see cref="InventoryLevel"/></returns>
        public virtual async Task<InventoryLevel> AdjustAsync(InventoryLevelAdjust adjustInventoryLevel)
        {
            var req = PrepareRequest($"inventory_levels/adjust.json");
            var body = adjustInventoryLevel.ToDictionary();
            var content = new JsonContent(body);
            var response = await ExecuteRequestAsync<InventoryLevel>(req, HttpMethod.Post, content, "inventory_level");
            
            return response.Result;
        }

        /// <summary>
        /// Connect an inventory item to a location
        /// </summary>
        /// <param name="inventoryItemId">The ID of the inventory item</param>
        /// <param name="locationId">The ID of the location that the inventory level belongs to</param>
        /// <param name="relocateIfNecessary">Whether inventory for any previously connected locations will be relocated. This property is ignored when no fulfillment service location is involved</param>
        /// <returns>The new <see cref="InventoryLevel"/>.</returns>
        public virtual async Task<InventoryLevel> ConnectAsync(long inventoryItemId, long locationId, bool relocateIfNecessary = false)
        {
            var req = PrepareRequest($"inventory_levels/connect.json");
            var content = new JsonContent(new
            {
                location_id = locationId,
                inventory_item_id = inventoryItemId,
                relocate_if_necessary = relocateIfNecessary
            });
            var response = await ExecuteRequestAsync<InventoryLevel>(req, HttpMethod.Post, content, "inventory_level");
            
            return response.Result;
        }
    }
}
