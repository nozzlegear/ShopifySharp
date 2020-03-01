using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering custom collection lists.
    /// </summary>
    public class CustomCollectionListFilter : ListFilter<CustomCollection>
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
        
        /// <summary>
        /// Show smart collections with given title 
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Show smart collections that includes given product
        /// </summary>
        [JsonProperty("product_id")]
        public long? ProductId { get; set; }
        
        /// <summary>
        /// Filter by smart collection handle
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("ids")]
        public IEnumerable<long> Ids { get; set; }
        
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }
        
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMax { get; set; }
        
        [JsonProperty("published_at_min")]
        public DateTimeOffset? PublishedAtMin { get; set; }
        
        [JsonProperty("published_at_min")]
        public DateTimeOffset? PublishedAtMax { get; set; }
        
        [JsonProperty("published_status")]
        public string PublishedStatus { get; set; }
    }
}
