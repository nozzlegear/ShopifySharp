using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShopifySharp.Entities.SalesChannel
{
    public class PaymentSalesChannel
    {
        [JsonProperty("id")]
        public long Id { get; set; }

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
        public CreditCard CreditCard { get; set; }

        [JsonProperty("checkout")]
        public CheckoutSalesChannel Checkout { get; set; }
    }

    public class CreditCard
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("first_digits")]
        public long FirstDigits { get; set; }

        [JsonProperty("last_digits")]
        public long LastDigits { get; set; }

        [JsonProperty("brand")]
        public string Brand { get; set; }

        [JsonProperty("expiry_month")]
        public long ExpiryMonth { get; set; }

        [JsonProperty("expiry_year")]
        public long ExpiryYear { get; set; }

        [JsonProperty("customer_id")]
        public long CustomerId { get; set; }
    }

    public class NextAction
    {
        [JsonProperty("redirect_url")]
        public Uri RedirectUrl { get; set; }
    }
}
