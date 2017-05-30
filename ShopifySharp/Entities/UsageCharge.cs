using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// Represents a variable monthly fee for an app or a service.
    /// </summary>
    public class UsageCharge : ShopifyObject
    {
        /// <summary>
        /// The date and time when the usage charge was created. 
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The name of the usage charge.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The price of the usage charge.
        /// </summary>
        [JsonProperty("price")]
        public decimal Price { get; set; }

        /// <summary>
        /// The recurring application charge the usage charge belongs to.
        /// </summary>
        [JsonProperty("recurring_application_charge_id")]
        public long? RecurringApplicationChargeId { get; set; }

        /// <summary>
        /// The date and time when the usage charge was last updated.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
