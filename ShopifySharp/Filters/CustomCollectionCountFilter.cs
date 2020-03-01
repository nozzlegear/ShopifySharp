using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class CustomCollectionCountFilter : Parameterizable
    {
        /// <summary>
        /// Restricts results to those with given title 
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Restricts results to those that includes given product
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }
        
        /// <summary>
        /// Restricts results to those last updated after date.
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }

        /// <summary>
        /// Restricts results to those last updated before date.
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