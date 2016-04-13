using Newtonsoft.Json;
using ShopifySharp.Enums;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="ShopifyWebhookService.ListAsync(ShopifyWebhookFilter)" /> results.
    /// </summary>
    public class ShopifyWebhookFilter : ShopifyListFilter
    {
        /// <summary>
        /// An optional filter for the address property. When used, the method will only return webhooks with the given address.
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// An optional filter for the topic property. When used, the method will only return webhooks with the given topic.
        /// </summary>
        [JsonProperty("topic")]
        public ShopifyWebhookTopic? Topic { get; set; }
    }
}
