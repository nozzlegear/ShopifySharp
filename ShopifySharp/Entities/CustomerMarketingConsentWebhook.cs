using Newtonsoft.Json;

namespace ShopifySharp;

/// <summary>
/// Payload for webhook customers_marketing_consent/update
/// https://shopify.dev/docs/api/admin-rest/2023-07/resources/webhook#event-topics-customers-marketing-consent-update
/// </summary>
public class CustomerMarketingConsentWebhook : ShopifyObject
{
    [JsonProperty("phone")]
    public string Phone { get; set; }

    [JsonProperty("sms_marketing_consent")]
    public CustomerSmsMarketingConsent SmsMarketingConsent { get; set; }
}