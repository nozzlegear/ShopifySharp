using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp.Filters
{
    public class InventoryItemListFilter : ListFilter<InventoryItem>
    {
        /// <summary>
        /// Show only inventory items specified by a comma-separated list of IDs.
        /// </summary>
        [JsonProperty("ids")]
        public IEnumerable<long> Ids { get; set; }
    }
}
