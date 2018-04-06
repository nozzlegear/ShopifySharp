using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="MetafieldService.CountAsync(long?, string, MetafieldFilter)"/> and 
    /// <see cref="MetafieldService.ListAsync(long?, string, MetafieldFilter)"/> results.
    /// </summary>
    public class MetafieldFilter : ListFilter
    {
        /// <summary>
        /// Filter by namespace.
        /// </summary>
        [JsonProperty("namespace")]
        public string Namespace { get; set; } = null;

        /// <summary>
        /// Filter by key value.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; } = null;

        /// <summary>
        /// Filter by value_type.
        /// </summary>
        [JsonProperty("value_type")]
        public string ValueType { get; set; } = null;
    }
}
