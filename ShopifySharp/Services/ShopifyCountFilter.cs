using Newtonsoft.Json;
using System;
using RestSharp;
using System.Reflection;
using Newtonsoft.Json.Converters;

namespace ShopifySharp
{
    /// <summary>
    /// A generic class for filtering the results of a .CountAsync command.
    /// </summary>
    public class ShopifyCountFilter : Parameterizable
    {
        /// <summary>
        /// Restricts results to those created after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTime? CreatedAtMin { get; set; }

        /// <summary>
        /// Restricts results to those created before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTime? CreatedAtMax { get; set; }

        /// <summary>
        /// Restricts results to those last updated after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTime? UpdatedAtMin { get; set; }

        /// <summary>
        /// Restricts results to those last updated before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTime? UpdatedAtMax { get; set; }
    }
}
