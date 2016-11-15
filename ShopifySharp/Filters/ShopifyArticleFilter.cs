using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering the results of <see cref="ShopifyArticleService.ListAsync(long, ShopifyArticleFilter)"/>.
    /// </summary>
    public class ShopifyArticleFilter : ShopifyPublishableListFilter
    {
        /// <summary>
        /// Filter the results to this article handle.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }
    }
}
