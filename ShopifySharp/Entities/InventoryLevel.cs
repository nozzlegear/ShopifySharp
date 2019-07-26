using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using ShopifySharp.Enums;
using ShopifySharp.Converters;

namespace ShopifySharp
{
    public class InventoryLevel
    {
        /// <summary>
        /// The unique identifier of the inventory item that the inventory level belongs to.
        /// </summary>
        [JsonProperty("inventory_item_id")]
        public long? InventoryItemId { get; set; }

        /// <summary>
        /// The unique identifier of the location that the inventory level belongs to.
        /// </summary>
        [JsonProperty("location_id")]
        public long? LocationId { get; set; }

        /// <summary>
        /// The quantity of inventory items available for sale. Returns null if the inventory item is not tracked.
        /// </summary>
        [JsonProperty("available")]
        public int? Available { get; set; }

        /// <summary>
        /// The date and time when the inventory level was last modified.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
