using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class DraftOrderCountFilter : CountFilter
    {
        /// <summary>
        /// Restrict results to after the specified ID.
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
        
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
        /// Only return orders with the given status. Known values are "open" (default), "invoice_sent", and "completed".
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}