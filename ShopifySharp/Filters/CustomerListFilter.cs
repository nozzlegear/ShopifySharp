using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class CustomerListFilter : ListFilter
    {
        [JsonProperty("ids")]
        public IEnumerable<long> Ids { get; set; }
        
        [JsonProperty("ids")]
        public long? SinceId { get; set; }
        
        [JsonProperty("created_at_min")]
        public DateTimeOffset? CreatedAtMin { get; set; }
        
        [JsonProperty("created_at_max")]
        public DateTimeOffset? CreatedAtMax { get; set; }
        
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }
        
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }
        
        [JsonProperty("fields")]
        public string Fields { get; set; }
        
        public override IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new NotImplementedException();
        }
    }
}