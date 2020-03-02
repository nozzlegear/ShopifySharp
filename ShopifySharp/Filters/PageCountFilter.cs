using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class PageCountFilter : Parameterizable
    {
        /// <summary>
        /// Filter by page title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        
        /// <summary>
        /// Restrict results to those created at or after date.
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTimeOffset? CreatedAtMin { get; set; }

        /// <summary>
        /// Restrict results to those created at or after date.
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTimeOffset? CreatedAtMax { get; set; }
        
        /// <summary>
        /// Restrict results to those created at or before date.
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }

        /// <summary>
        /// Restrict results to those last updated at or before date.
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }
        
        /// <summary>
        /// Restricts results to those published after date.
        /// </summary>
        [JsonProperty("published_at_min")]
        public DateTimeOffset? PublishedAtMin { get; set; }

        /// <summary>
        /// Restricts results to those published before date.
        /// </summary>
        [JsonProperty("published_at_max")]
        public DateTimeOffset? PublishedAtMax { get; set; }

        /// <summary>
        /// Restricts results to those with the given published status. Known values: published, unpublished, any. Default: any.
        /// </summary>
        [JsonProperty("published_status")]
        public string PublishedStatus { get; set; }
    }
}