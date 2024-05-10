using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp;

public interface IInventoryItemService : IShopifyService
{
    /// <summary>
    /// Gets a list of inventory items.
    /// </summary>
    /// <param name="filter">Options for filtering the result.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ListResult<InventoryItem>> ListAsync(ListFilter<InventoryItem> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of inventory items.
    /// </summary>
    /// <param name="filter">Options for filtering the result.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ListResult<InventoryItem>> ListAsync(InventoryItemListFilter filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the <see cref="InventoryItem"/> with the given id.
    /// </summary>
    /// <param name="inventoryItemId">The id of the inventory item to retrieve.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<InventoryItem> GetAsync(long inventoryItemId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates an existing <see cref="InventoryItem"/>.
    /// </summary>
    /// <param name="inventoryItemId">The id of the inventory item to retrieve.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<InventoryItem> UpdateAsync( long inventoryItemId, InventoryItem inventoryItem, CancellationToken cancellationToken = default);
}