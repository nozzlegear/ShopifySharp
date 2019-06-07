using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering the results of <see cref="ArticleService.ListAsync(long, ArticleFilter)"/>.
    /// </summary>
    public class ArticleFilter : Parameterizable
    {
        /// <summary>
        /// Filter the results to this article handle.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

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
        /// Restrict results to after the specified ID. Note: this field may not have an effect on certain resources.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// An optional array of order ids to retrieve.
        /// </summary>
        [JsonProperty("ids")]
        public IEnumerable<long> Ids { get; set; }

        /// <summary>
        /// Limit the amount of results. Default is 50, max is 250.
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Page of results to be returned. Default is 1.
        /// </summary>
        [JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// An optional, comma-separated list of fields to include in the response.
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }

        /// <summary>
        /// An optional field name to order by, followed by either ' asc' or ' desc'.
        /// For example, 'created_at asc'
        /// Not all fields are supported...
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }

        /// <summary>
        /// Show objects published after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("published_at_min")]
        public DateTimeOffset? PublishedAtMin { get; set; } = null;

        /// <summary>
        /// Show objects published before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("published_at_max")]
        public DateTimeOffset? PublishedAtMax { get; set; } = null;

        /// <summary>
        /// Published Status.
        /// published - Show only published objects, unpublished - Show only unpublished objects, any - Show all objects(default)
        /// </summary>
        [JsonProperty("published_status")]
        public string PublishedStatus { get; set; } = null;
    }
}
