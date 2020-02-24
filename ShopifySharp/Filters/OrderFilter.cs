using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering lists of orders.
    /// </summary>
    public class OrderFilter : ListFilter<Order>
    {
        /// <summary>
        /// The status of orders to retrieve. Known values are "open", "closed", "cancelled" and "any".
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The financial status of orders to retrieve. Known values are "authorized", "paid", "pending", "partially_paid", "partially_refunded", "refunded" and "voided".
        /// </summary>
        [JsonProperty("financial_status")]
        public string FinancialStatus { get; set; }

        /// <summary>
        /// The fulfillment status of orders to retrieve. Leave this null to retrieve orders with any fulfillment status.
        /// </summary>
        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }
        
        /// <summary>
        /// Show orders created at or after date.
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTimeOffset? CreatedAtMin { get; set; }

        /// <summary>
        /// Show orders created at or after date.
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTimeOffset? CreatedAtMax { get; set; }
        
        /// <summary>
        /// Show orders created at or before date.
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }

        /// <summary>
        /// Show orders last updated at or before date.
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }
        
        /// <summary>
        /// Show orders imported after date.
        /// </summary>
        [JsonProperty("processed_at_min")]
        public DateTimeOffset? ProcessedAtMin { get; set; }

        /// <summary>
        /// Show orders imported before date.
        /// </summary>
        [JsonProperty("processed_at_max")]
        public DateTimeOffset? ProcessedAtMax { get; set; }

        /// <summary>
        /// Show orders attributed to a specific app. Valid values are the app ID to filter on (eg. 123) or a value of "current" to only show orders for the app currently consuming the API.
        /// </summary>
        [JsonProperty("attribution_app_id")]
        public string AttributionAppId { get; set; }
        
        /// <summary>
        /// Retrieve only certain fields, specified by a comma-separated list of field names. 
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }
        
        /// <summary>
        /// Retrieve only orders specified by a comma-separated list of order IDs.
        /// </summary>
        public IEnumerable<long> Ids { get; set; }
        
        /// <summary>
        /// Retrieve only orders specified by a comma-separated list of order IDs.
        /// </summary>
        public long? SinceId { get; set; }

        public override IEnumerable<KeyValuePair<string, object>> ToQueryParameters()
        {
            throw new NotImplementedException();
        }
    }
}
