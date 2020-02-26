using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class CollectListFilter : ListFilter<Collect>
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
        
        /// <summary>
        /// Retrieve only certain fields, specified by a comma-separated list of field names. 
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }

        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("collection_id")]
        public long? CollectionId { get; set; }

        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }
    }
}