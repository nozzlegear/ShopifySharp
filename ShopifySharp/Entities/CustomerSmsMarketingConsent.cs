using System;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class CustomerSmsMarketingConsent 
    {
        /// <summary>
        /// The current SMS marketing state for the customer.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The marketing subscription opt-in level, as described by the M3AAWG best practices guidelines, that the customer gave when they consented to receive marketing material by SMS.
        /// </summary>
        [JsonProperty("opt_in_level")]
        public string OptInLevel { get; set; }

        /// <summary>
        /// The date and time at which the customer consented to receive marketing material by SMS.
        /// </summary>
        [JsonProperty("consent_updated_at")]
        public DateTimeOffset? ConsentUpdatedAt { get; set; }

        /// <summary>
        /// The source for whether the customer has consented to receive marketing material by SMS.
        /// </summary>
        [JsonProperty("consent_collected_from")]
        public string ConsentCollectedFrom { get; set; }
    }
}
