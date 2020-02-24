using System;
using System.Collections.Generic;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// You **must** include InventoryItemIds, LocationIds, or both as filter parameters.
    /// </summary>
    public interface IInventoryLevelFilter : IListFilter<InventoryLevel>
    {
        /// <summary>
        /// Ids of inventory items to retrieve
        /// </summary>
        IEnumerable<long> InventoryItemIds { get; set; }

        /// <summary>
        /// Ids of locations to search
        /// </summary>
        IEnumerable<long> LocationIds { get; set; }
        
        /// <summary>
        /// Show inventory levels updated at or after date.
        /// </summary>
        DateTimeOffset? UpdatedAtMin { get; set; }
    }
}