using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class FulfillmentListFilter : ListFilter<Fulfillment>
    {
        /// <summary>
        /// Restrict results to after the specified ID
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
        
        [JsonProperty("created_at_min")]
        public DateTimeOffset? CreatedAtMin { get; set; }
        
        [JsonProperty("created_at_max")]
        public DateTimeOffset? CreatedAtMax { get; set; }
        
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }
        
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }
    }
}