using System;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class OrderCountFilter : Parameterizable
    {
        /// <summary>
        /// Restrict results to after the specified ID. 
        /// </summary>
        [JsonProperty("since_id")]
        public long? SinceId { get; set; }

        /// <summary>
        /// Restricts results to those with the given status. Known values are "open", "closed", "cancelled" and "any".
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Restricts results to those with the given financial status. Known values are "authorized", "paid", "pending", "partially_paid", "partially_refunded", "refunded" and "voided".
        /// </summary>
        [JsonProperty("financial_status")]
        public string FinancialStatus { get; set; }

        /// <summary>
        /// Restricts results to those with the given fulfillment status. Known values are "shipped", "partial", "unshipped", "any" and "unfulfilled". Default: any. 
        /// </summary>
        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }
        
        /// <summary>
        /// Restrict results to those created at or after date.
        /// </summary>
        [JsonProperty("created_at_min")]
        public DateTimeOffset? CreatedAtMin { get; set; }

        /// <summary>
        /// Restrict results to those created at or after date.
        /// </summary>
        [JsonProperty("created_at_max")]
        public DateTimeOffset? CreatedAtMax { get; set; }
        
        /// <summary>
        /// Restrict results to those created at or before date.
        /// </summary>
        [JsonProperty("updated_at_min")]
        public DateTimeOffset? UpdatedAtMin { get; set; }

        /// <summary>
        /// Restrict results to those last updated at or before date.
        /// </summary>
        [JsonProperty("updated_at_max")]
        public DateTimeOffset? UpdatedAtMax { get; set; }

        /// <summary>
        /// Restrict results to those processed at or before date.
        /// </summary>
        [JsonProperty("processed_at_min")]
        public DateTimeOffset? ProcessedAtMin { get; set; }

        /// <summary>
        /// Restrict results to those last processed at or before date.
        /// </summary>
        [JsonProperty("processed_at_max")]
        public DateTimeOffset? ProcessedAtMax { get; set; }
    }
}