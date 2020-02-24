using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class CustomerSavedSearchListFilter : ListFilter<CustomerSavedSearch>
    {
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }
        
        [JsonProperty("fields")]
        public string Fields { get; set; }
        
        public override IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new NotImplementedException();
        }
    }
}