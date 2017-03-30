using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="ShopifyCustomCollectionService"/> requests.
    /// </summary>
    public class CustomCollectionFilter : PublishableListFilter
    {
        /// <summary>
        /// Show smart collections with given title 
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Show smart collections that includes given product
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }
        
        /// <summary>
        /// Filter by smart collection handle
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }
    }
}
