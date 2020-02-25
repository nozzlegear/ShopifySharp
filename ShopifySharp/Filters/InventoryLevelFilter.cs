using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// You **must** include InventoryItemIds, LocationIds, or both as filter parameters.
    /// </summary>
    public class InventoryLevelFilter : ListFilter<InventoryLevel>, IInventoryLevelFilter
    {
        [JsonProperty("inventory_item_ids")]
        public IEnumerable<long> InventoryItemIds { get; set; }

        [JsonProperty("location_ids")]
        public IEnumerable<long> LocationIds { get; set; }
        
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }
    }
}
