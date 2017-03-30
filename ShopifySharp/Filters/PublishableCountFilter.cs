using Newtonsoft.Json;
using System;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Generic options for filtering the count of objects that can be published.
    /// </summary>
    public class PublishableCountFilter : CountFilter
    {
        /// <summary>
        /// Show objects published after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("published_at_min")]
        public DateTime? PublishedAtMin { get; set; } = null;

        /// <summary>
        /// Show objects published before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("published_at_max")]
        public DateTime? PublishedAtMax { get; set; } = null;
    }
}
