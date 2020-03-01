using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class ArticleCountFilter : Parameterizable
    {
        /// <summary>
        /// Restricts results to those created after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTimeOffset? CreatedAtMin { get; set; }

        /// <summary>
        /// Restricts results to those created before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTimeOffset? CreatedAtMax { get; set; }

        /// <summary>
        /// Restricts results to those last updated after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }

        /// <summary>
        /// Restricts results to those last updated before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }
        
        /// <summary>
        /// Restricts results to those published after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("published_at_min")]
        public DateTimeOffset? PublishedAtMin { get; set; }

        /// <summary>
        /// Restricts results to those published before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("published_at_max")]
        public DateTimeOffset? PublishedAtMax { get; set; }
        
        /// <summary>
        /// Published Status.
        /// published - Show only published objects, unpublished - Show only unpublished objects, any - Show all objects(default)
        /// </summary>
        [JsonProperty("published_status")]
        public string PublishedStatus { get; set; }
    }
}