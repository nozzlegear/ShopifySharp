using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class FulfillmentListFilter : ListFilter
    {
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
        
        [JsonProperty("fields")]
        public string Fields { get; set; }
        
        [JsonProperty("created_at_min")]
        public DateTimeOffset? CreatedAtMin { get; set; }
        
        [JsonProperty("created_at_max")]
        public DateTimeOffset? CreatedAtMax { get; set; }
        
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }
        
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }
        
        public override IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new NotImplementedException();
        }
    }
}