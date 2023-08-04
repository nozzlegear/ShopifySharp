using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// Payload for webhook customers_email_marketing_consent/update
    /// https://shopify.dev/docs/api/admin-rest/2023-07/resources/webhook#event-topics-customers-marketing-consent-update
    /// </summary>
    public class CustomerEmailMarketingConsentWebhook : ShopifyObject
    {
        [JsonProperty("customer_id")]
        public long? CustomerId { get; set; }

        [JsonProperty("email_address")]
        public string EmailAddress { get; set; }

        [JsonProperty("email_marketing_consent")]
        public CustomerEmailMarketingConsent EmailMarketingConsent { get; set; }
    }
}
