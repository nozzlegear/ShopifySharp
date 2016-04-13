using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="ShopifyProductService.CountAsync(ShopifyProductFilter)"/> and 
    /// <see cref="ShopifyProductService.ListAsync(ShopifyProductFilter)"/> results.
    /// </summary>
    public class ShopifyProductFilter : ShopifyPublishableListFilter
    {
        /// <summary>
        /// Filter by product title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = null;

        /// <summary>
        /// Filter by product vendor.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; } = null;

        /// <summary>
        /// Filter by product handle.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; } = null;

        /// <summary>
        /// Filter by product type.
        /// </summary>
        [JsonProperty("product_type")]
        public string ProductType { get; set; } = null;

        /// <summary>
        /// Filter by collection id.
        /// </summary>
        [JsonProperty("collection_id")]
        public long? CollectionId { get; set; } = null;
    }
}
