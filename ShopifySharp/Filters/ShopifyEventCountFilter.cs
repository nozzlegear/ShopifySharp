using Newtonsoft.Json;
using System;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// A generic class for filtering the results of a .CountAsync command.
    /// </summary>
    public class ShopifyEventCountFilter : Parameterizable
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
    }
}
