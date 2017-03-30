using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing Shopify's ApplicationCredit object, which can be used to offer credits for payments made via the Application Charge, Recurring Application Charge, and Usage Charge APIs.
    /// </summary>
    public class ApplicationCredit: ShopifyObject
    {
        /// <summary>
        /// The description of the application credit.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The amount refunded by the application credit.
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// States whether or not the application credit is a test transaction. Valid values are true or null.
        /// </summary>
        [JsonProperty("test")]
        public bool? Test { get; set; }
    }
}
