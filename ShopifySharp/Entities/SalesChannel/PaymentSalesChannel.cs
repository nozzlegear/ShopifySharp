using System;
using Newtonsoft.Json;

namespace ShopifySharp.Entities.SalesChannel
{
    public class PaymentSalesChannel: ShopifyObject
    {
        [JsonProperty("unique_token")]
        public string UniqueToken { get; set; }

        [JsonProperty("payment_processing_error_message")]
        public object PaymentProcessingErrorMessage { get; set; }

        [JsonProperty("next_action")]
        public NextAction NextAction { get; set; }

        [JsonProperty("fraudulent")]
        public bool Fraudulent { get; set; }

        [JsonProperty("transaction")]
        public Transaction Transaction { get; set; }

        [JsonProperty("credit_card")]
        public PaymentCreditCard CreditCard { get; set; }

        [JsonProperty("checkout")]
        public CheckoutSalesChannel Checkout { get; set; }
    }

    public class NextAction
    {
        [JsonProperty("redirect_url")]
        public Uri RedirectUrl { get; set; }
    }
}
