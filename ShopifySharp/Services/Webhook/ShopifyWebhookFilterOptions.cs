using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// Options for filtering results from certain <see cref="ShopifyWebhookService"/> methods.
    /// </summary>
    public class ShopifyWebhookFilterOptions : ShopifyFilterOptions
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
