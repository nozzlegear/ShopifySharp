using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// Sent via the shop/redacted GDPR webhook, indicating that you should purge the shop's data from your systems.
    /// </summary>
    public class ShopRedactedWebhook
    {
        /// <summary>
        /// The shop's id.
        /// </summary>
        [JsonProperty("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// The shop's *.myshopify.com domain.
        /// </summary>
        [JsonProperty("shop_domain")]
        public string ShopDomain { get; set; }
    }
}