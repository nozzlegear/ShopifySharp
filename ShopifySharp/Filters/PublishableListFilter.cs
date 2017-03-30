using Newtonsoft.Json;
using System;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Generic options for filtering objects that can be published (e.g. those with a PublishedAt, Published status).
    /// </summary>
    public class PublishableListFilter : ListFilter
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

        /// <summary>
        /// Published Status.
        /// published - Show only published objects, unpublished - Show only unpublished objects, any - Show all objects(default)
        /// </summary>
        [JsonProperty("published_status")]
        public string PublishedStatus { get; set; } = null;
    }
}
