using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ShopifySharp.Enums;

namespace ShopifySharp
{
    public class ShopifyMetaFieldFilterOptions : ShopifyFilterOptions
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; } = null;

        /// <summary>
        /// Show metafields created after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTime? CreatedAtMin { get; set; } = null;

        /// <summary>
        /// Show metafields created before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTime? CreateAtMax { get; set; } = null;

        /// <summary>
        /// Show metafields last updated after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTime? UpdateAtMin { get; set; } = null;

        /// <summary>
        /// Show metafields last updated before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTime? UpdateAtMax { get; set; } = null;

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
