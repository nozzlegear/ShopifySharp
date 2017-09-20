using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="ScriptTagService.ListAsync(ScriptTagFilter)"/> results.
    /// </summary>
    public class ScriptTagFilter : ListFilter
    {
        /// <summary>
        /// Returns only those <see cref="ScriptTag"/>s with the given <see cref="ScriptTag.Src"/> value.
        /// </summary>
        [JsonProperty("src")]
        public string Src { get; set; }
    }
}
