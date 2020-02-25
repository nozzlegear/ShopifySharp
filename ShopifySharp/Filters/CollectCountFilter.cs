using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering a count of Collects. 
    /// </summary>
    public class CollectCountFilter : CountFilter
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
