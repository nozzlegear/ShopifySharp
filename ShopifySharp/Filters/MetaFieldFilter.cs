using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="MetaFieldService.CountAsync(long?, string, MetaFieldFilter)"/> and 
    /// <see cref="MetaFieldService.ListAsync(long?, string, MetaFieldFilter)"/> results.
    /// </summary>
    public class MetaFieldFilter : ListFilter
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
