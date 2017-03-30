using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="ShopifyPageService.CountAsync(PageFilter)"/> and 
    /// <see cref="ShopifyPageService.ListAsync(PageFilter)"/> results.
    /// </summary>
    public class PageFilter : PublishableListFilter
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
