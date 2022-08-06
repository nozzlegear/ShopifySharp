using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    public class PaymentSchedule
    {
        /// <summary>
        /// The amount that is owed according to the payment terms.
        /// </summary>
        [JsonProperty("amount")]
        public decimal? amount { get; set; }

        /// <summary>
        /// The presentment currency for the payment
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The date and time when the payment terms were initiated
        /// </summary>
        [JsonProperty("issued_at")]
        public DateTimeOffset? IssuedAt { get; set; }

        /// <summary>
        /// The date and time when the payment is due. Calculated based on issued_at and due_in_days or a customized fixed date if the type is fixed.
        /// </summary>
        [JsonProperty("due_at")]
        public DateTimeOffset? DueAt { get; set; }

        /// <summary>
        /// The date and time when the purchase is completed. Returns null initially and updates when the payment is captured
        /// </summary>
        [JsonProperty("completed_at")]
        public DateTimeOffset? CompletedAt { get; set; }

        /// <summary>
        /// The name of the payment method gateway.
        /// </summary>
        [JsonProperty("expected_payment_method")]
        public string ExpectedPaymentMethod { get; set; }
    }
}
