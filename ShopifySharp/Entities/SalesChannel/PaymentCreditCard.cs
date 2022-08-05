using Newtonsoft.Json;

namespace ShopifySharp.Entities.SalesChannel
{
    public class PaymentCreditCard
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
}