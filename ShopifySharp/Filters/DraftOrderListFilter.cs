using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters 
{
    public class DraftOrderListFilter : ListFilter 
    {
        /// <summary>
        /// Only return orders with the given status. Known values are "open" (default), "invoice_sent", and "completed".
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        
        [JsonProperty("fields")]
        public string Fields { get; set; }
        
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
        
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }
        
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }
        
        [JsonProperty("fields")]
        public IEnumerable<long> Ids { get; set; }

        public override IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new NotImplementedException();
        }
    }
}