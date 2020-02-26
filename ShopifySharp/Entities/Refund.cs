using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class Refund : ShopifyObject
    {
        /// <summary>
        /// The date and time when the refund was created. 
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        ///<summary>
        /// Whether to send a refund notification to the customer
        /// </summary>
        [JsonProperty("notify")]
        public bool? Notify { get; set; }

        /// <summary>
        /// Specify how much shipping to refund.
        /// </summary>
        [JsonProperty("shipping")]
        public Shipping Shipping { get; set; }

        /// <summary>
        /// The three-letter code (ISO 4217 format) for the currency used for the refund. Note: Required whenever the shipping amount property is provided.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The list of <see cref="RefundOrderAdjustment"/> objects
        /// </summary>
        [JsonProperty("order_adjustments")]
        public IEnumerable<RefundOrderAdjustment> OrderAdjustments { get; set; }

        /// <summary>
        /// The date and time when the refund was imported.
        /// </summary>
        /// <remarks>
        /// This value can be set to dates in the past when importing from other systems. If no value is provided, it will be auto-generated.
        /// </remarks>
        [JsonProperty("processed_at")]
        public DateTimeOffset? ProcessedAt { get; set; }

        /// <summary>
        /// The optional note attached to a refund.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The list of <see cref="RefundLineItem"/> objects
        /// </summary>
        [JsonProperty("refund_line_items")]
        public IEnumerable<RefundLineItem> RefundLineItems { get; set; }

        /// <summary>
        /// Whether or not the line items were added back to the store inventory.
        /// </summary>
        [JsonIgnore]
        [Obsolete("The Restock property is now obsolete and will be removed in a future release. Attempting to use this property when creating or updating a Refund will result in the Shopify API returning an error. You must use the RestockType property instead.")]
        public bool? Restock { get; set; }

        /// <summary>
        /// The list of <see cref="Transaction"/> objects
        /// </summary>
        [JsonProperty("transactions")]
        public IEnumerable<Transaction> Transactions { get; set; }

        /// <summary>
        /// The unique identifier of the user who performed the refund.
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }
    }

    public class Shipping
    {
        /// <summary>
        /// Whether to refund all remaining shipping.
        /// </summary>
        [JsonProperty("full_refund")]
        public bool? FullRefund { get; set; }

        /// <summary>
        /// Set a specific amount to refund for shipping. Takes precedence over full_refund.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }
    }
}
