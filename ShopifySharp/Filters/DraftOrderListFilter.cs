using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters 
{
    public class DraftOrderListFilter : ListFilter 
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
        /// Retrieve only those specified by a comma-separated list of order IDs.
        /// </summary>
        [JsonProperty("ids")]
        public IEnumerable<long> Ids { get; set; }
        
        /// <summary>
        /// Only return orders with the given status. Known values are "open" (default), "invoice_sent", and "completed".
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
        
        /// <summary>
        /// Restricts results to those last updated after date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }

        /// <summary>
        /// Restricts results to those last updated before date (format: 2008-12-31 03:00).
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }
    }
}