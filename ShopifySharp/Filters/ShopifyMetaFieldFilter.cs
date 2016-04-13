using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="ShopifyMetaFieldService.CountAsync(long?, string, ShopifyMetaFieldFilter)"/> and 
    /// <see cref="ShopifyMetaFieldService.ListAsync(long?, string, ShopifyMetaFieldFilter)"/> results.
    /// </summary>
    public class ShopifyMetaFieldFilter : ShopifyListFilter
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
