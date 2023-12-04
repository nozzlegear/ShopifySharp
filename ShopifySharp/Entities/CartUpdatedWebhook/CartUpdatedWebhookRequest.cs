using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Entities.CartUpdatedWebhook
{
    public class CartUpdatedWebhookRequest : ShopifyObject
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("line_items")]
        public IEnumerable<CartUpdatedWebhookLineItem> LineItems { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
    }
}
