using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify payments dispute.
    /// </summary>
    public class ShopifyPaymentsDispute : ShopifyObject
    {
        [JsonProperty("order_id")]
        public long? OrderId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("network_reason_code")]
        public string NetworkReasonCode { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("evidence_due_by")]
        public DateTimeOffset? EvidenceDueBy { get; set; }

        [JsonProperty("initiated_at")]
        public DateTimeOffset? InitiatedAt { get; set; }

        [JsonProperty("evidence_sent_on")]
        public DateTimeOffset? EvidenceSentOn { get; set; }

        [JsonProperty("finalized_on")]
        public DateTimeOffset? FinalizedOn { get; set; }


    }
}
