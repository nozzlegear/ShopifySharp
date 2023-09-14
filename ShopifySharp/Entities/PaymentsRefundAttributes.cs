using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PaymentsRefundAttributes
    {
        /// <summary>
        /// The current status of the refund. Valid values: pending, failure, success, and error.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// A unique number associated with the transaction that can be used to track the refund.
        /// This property has a value only for transactions completed with Visa or Mastercard.
        /// </summary>
        [JsonProperty("acquirer_reference_number")]
        public string AcquirerReferenceNumber { get; set; }
    }
}
