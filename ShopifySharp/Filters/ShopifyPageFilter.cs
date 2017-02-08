using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="ShopifyPageService.CountAsync(ShopifyPageFilter)"/> and 
    /// <see cref="ShopifyPageService.ListAsync(ShopifyPageFilter)"/> results.
    /// </summary>
    public class ShopifyPageFilter : ShopifyPublishableListFilter
    {
        /// <summary>
        /// Filter by page title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; } = null;

        /// <summary>
        /// Filter by page handle.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; } = null;
    }
}
