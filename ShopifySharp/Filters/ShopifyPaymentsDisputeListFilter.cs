using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ShopifySharp.Filters 
{
    public class ShopifyPaymentsDisputeListFilter : ListFilter
    {
        /// <summary>
        /// Return only disputes before the specified ID.
        /// </summary>
        [JsonProperty("last_id")]
        public long? LastId { get; set; }

        /// <summary>
        /// Return only disputes with the specified status.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Return only disputes with the specified initiated_at date.
        /// </summary>
        [JsonProperty("initiated_at ")]
        public DateTimeOffset? InitiatedAt { get; set; }

        public override IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new NotImplementedException();
        }
    }
}