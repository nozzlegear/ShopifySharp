using System;
using Newtonsoft.Json;
using ShopifySharp.Enums;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="OrderService.CountAsync(OrderFilter)"/> and
    /// <see cref="OrderService.ListAsync(OrderFilter)"/> results.
    /// </summary>
    public class OrderFilter : ListFilter
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
        /// Show orders imported after date.
        /// </summary>
        [JsonProperty("processed_at_min")]
        public DateTime? ProcessedAtMin { get; set; }

        /// <summary>
        /// Show orders imported before date.
        /// </summary>
        [JsonProperty("processed_at_max")]
        public DateTime? ProcessedAtMax { get; set; }

        /// <summary>
        /// Show orders attributed to a specific app. Valid values are the app ID to filter on (eg. 123) or a value of "current" to only show orders for the app currently consuming the API.
        /// </summary>
        [JsonProperty("attribution_app_id")]
        public string AttributionAppId { get; set; }
    }
}
