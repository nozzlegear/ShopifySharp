using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="ShopifyScriptTagService.ListAsync(ShopifyScriptTagFilter)"/> results.
    /// </summary>
    public class ShopifyScriptTagFilter : ShopifyListFilter
    {
        /// <summary>
        /// Returns only those <see cref="ScriptTag"/>s with the given <see cref="ScriptTag.Src"/> value.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }
    }
}
