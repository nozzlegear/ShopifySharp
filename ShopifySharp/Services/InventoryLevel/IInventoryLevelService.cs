using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IInventoryLevelService : IShopifyService
    {
        /// <summary>
        /// Gets a list of inventory items. 
        /// </summary>
        Task<ListResult<InventoryLevel>> ListAsync(ListFilter<InventoryLevel> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of inventory items
        /// </summary>
        Task<ListResult<InventoryLevel>> ListAsync(InventoryLevelListFilter filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes inventory for an item at specified location.  All items must keep inventory at at least one location.
        /// </summary>
        /// <param name="inventoryItemId">The ID of the inventory item.</param>
        /// <param name="locationId">The ID of the location that the inventory level belongs to.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long inventoryItemId, long locationId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the given <see cref="InventoryLevel"/>.
        /// </summary>
        /// <param name="updatedInventoryLevel">The updated <see cref="InventoryLevel"/></param>
        /// <param name="disconnectIfNecessary">Whether inventory for any previously connected locations will be set to 0 and the locations disconnected. This property is ignored when no fulfillment service is involved.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="InventoryLevel"/></returns>
        Task<InventoryLevel> SetAsync(InventoryLevel updatedInventoryLevel, bool disconnectIfNecessary = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adjusts the given <see cref="InventoryLevel"/>.
        /// </summary>
        /// <param name="updatedInventoryLevel">The updated <see cref="InventoryLevel"/></param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="InventoryLevel"/></returns>
        Task<InventoryLevel> AdjustAsync(InventoryLevelAdjust updatedInventoryLevel, CancellationToken cancellationToken = default);

        /// <summary>
        /// Connect an inventory item to a location
        /// </summary>
        /// <param name="inventoryItemId">The ID of the inventory item</param>
        /// <param name="locationId">The ID of the location that the inventory level belongs to</param>
        /// <param name="relocateIfNecessary">Whether inventory for any previously connected locations will be relocated. This property is ignored when no fulfillment service location is involved</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="InventoryLevel"/>.</returns>
        Task<InventoryLevel> ConnectAsync(long inventoryItemId, long locationId, bool relocateIfNecessary = false, CancellationToken cancellationToken = default);
    }
}