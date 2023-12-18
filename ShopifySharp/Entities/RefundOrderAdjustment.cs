using Newtonsoft.Json;

namespace ShopifySharp
{
    public class RefundOrderAdjustment : ShopifyObject
    {
        /// <summary>
        /// The unique identifier of the order
        /// </summary>
        [JsonProperty("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// The unique identifier of the refund
        /// </summary>
        [JsonProperty("refund_id")]
        public long? RefundId { get; set; }

        /// <summary>
        /// The amount refunded (it is negative and does not include tax).
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The tax amount refunded (negative).
        /// </summary>
        [JsonProperty("tax_amount")]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// The type of adjustment. Values include "refund_discrepancy", "shipping_refund"
        /// </summary>
        [JsonProperty("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Reason for the refund
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// The amount of the order adjustment in shop and presentment currencies.
        /// </summary>
        [JsonProperty("amount_set")]
        public PriceSet AmountSet { get; set; }

        /// <summary>
        /// The tax amount of the order adjustment in shop and presentment currencies.
        /// </summary>
        [JsonProperty("tax_amount_set")]
        public PriceSet TaxAmountSet { get; set; }
    }
}
