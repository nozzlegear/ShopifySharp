using Newtonsoft.Json;
using System;

namespace ShopifySharp;

public class CustomerEmailMarketingConsent
{
    /// <summary>
    /// The current email marketing state for the customer.
    /// </summary>
    [JsonProperty("state")]
    public string State { get; set; }

    /// <summary>
    /// The marketing subscription opt-in level, as described in the M3AAWG Sender Best Common Practices, that the customer gave when they consented to receive marketing material by email.
    /// </summary>
    [JsonProperty("opt_in_level")]
    public string OptInLevel { get; set; }

    /// <summary>
    /// The date and time when the customer consented to receive marketing material by email. If no date is provided, then the date and time when the consent information was sent is used.
    /// </summary>
    [JsonProperty("consent_updated_at")]
    public DateTimeOffset? ConsentUpdatedAt { get; set; }
}