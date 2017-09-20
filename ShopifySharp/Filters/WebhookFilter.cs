using Newtonsoft.Json;
using ShopifySharp.Enums;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="WebhookService.ListAsync(WebhookFilter)" /> results.
    /// </summary>
    public class WebhookFilter : ListFilter
    {
        /// <summary>
        /// An optional filter for the address property. When used, the method will only return webhooks with the given address.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// An optional filter for the topic property. When used, the method will only return webhooks with the given topic. A full list of topics can be found at https://help.shopify.com/api/reference/webhook.
        /// </summary>
        [JsonProperty("topic")]
        public string Topic { get; set; }
    }
}
