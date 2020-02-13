using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering gift cards. 
    /// </summary>
    public class GiftCardFilter : ListFilter
    {
        /// <summary>
        /// The status of gift card to retrieve. Known values are "enabled", "disabled".
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        
        [JsonProperty("since_id")]
        public long SinceId { get; set; }
        
        [JsonProperty("fields")]
        public string Fields { get; set; }

        public override IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new NotImplementedException();
        }
    }
}
