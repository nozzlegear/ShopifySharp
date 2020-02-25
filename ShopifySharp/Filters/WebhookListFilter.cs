using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering lists of Webhooks. 
    /// </summary>
    public class WebhookListFilter : ListFilter
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
        
        /// <summary>
        /// Retrieve only certain fields, specified by a comma-separated list of field names. 
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }
        
        /// <summary>
        /// Restricts results to those with the given address. 
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Restricts results to those with the given topic. 
        /// </summary>
        [JsonProperty("topic")]
        public string Topic { get; set; }
        
        /// <summary>
        /// Show those created at or after date.
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTimeOffset? CreatedAtMin { get; set; }

        /// <summary>
        /// Show those created at or after date.
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTimeOffset? CreatedAtMax { get; set; }
        
        /// <summary>
        /// Show those updated at or before date.
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }

        /// <summary>
        /// Show those last updated at or before date.
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }
    }
}
