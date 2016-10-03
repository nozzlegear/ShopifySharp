using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify order risk.
    /// </summary>
    public class ShopifyOrderRisk : ShopifyObject
    {
        /// <summary>
        /// Use this flag when a fraud check is accompanied with a call to the Orders API to cancel the order. This will indicate to the merchant that this risk was severe enough to force cancellation of the order.
        /// Note: Setting this parameter does not cancel the order. This must be done by the Orders API.
        /// </summary>
        [JsonProperty("cause_cancel")]
        public bool CauseCancel { get; set; }

        /// <summary>
        /// WARNING: This is an undocumented value returned by the Shopify API. Use at your own risk.
        /// </summary>
        [JsonProperty("checkout_id"), Obsolete("This is an undocumented value returned by the Shopify API. Use at your own risk.")]
        public long? CheckoutId { get; set; }

        /// <summary>
        /// States whether or not the risk is displayed. Valid values are "true" or "false".
        /// </summary>
        [JsonProperty("display")]
        public bool Display { get; set; }

        /// <summary>
        /// The id of the order the order risk belongs to
        /// </summary>
        [JsonProperty("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// A message that should be displayed to the merchant to indicate the results of the fraud check.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// WARNING: This is an undocumented field returned by the Shopify API. Use at your own risk.
        /// </summary>
        [JsonProperty("merchant_message"), Obsolete("This is an undocumented field returned by the Shopify API. Use at your own risk.")]
        public string MerchantMessage { get; set; }

        /// <summary>
        /// The recommended action given to the merchant. Known values are 'cancel', 'investigate' and 'accept'.
        /// </summary>
        [JsonProperty("recommendation")]
        public string Recommendation { get; set; }

        /// <summary>
        /// A number between 0 and 1 indicating percentage likelihood of being fraud.
        /// </summary>
        [JsonProperty("score")]
        public decimal Score { get; set; }

        /// <summary>
        /// This indicates the source of the risk assessment. Only known value is 'External'.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
