using Newtonsoft.Json;
using System;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// A generic class for filtering the results of a .CountAsync command.
    /// </summary>
    public class CountFilter : Parameterizable
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

        /// <summary>
        /// Restrict results to after the specified ID. Note: this field may not have an effect on certain resources.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
    }
}
