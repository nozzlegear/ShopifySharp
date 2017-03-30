using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="ShopifyCollectService.ListAsync(CollectFilter)"/> results.
    /// </summary>
    public class CollectFilter : ListFilter
    {
        /// <summary>
        /// An optional product id to retrieve. 
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// An optional collection id to retrieve. 
        /// </summary>
        [JsonProperty("collection_id")]
        public long? CollectionId { get; set; }
    }
}
