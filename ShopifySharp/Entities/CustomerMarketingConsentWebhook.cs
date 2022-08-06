using Newtonsoft.Json;

namespace ShopifySharp
{
    public class CustomerMarketingConsentWebhook : ShopifyObject
    {
        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("sms_marketing_consent")]
        public CustomerSmsMarketingConsent SmsMarketingConsent { get; set; }
    }
}
