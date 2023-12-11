#nullable enable
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Entities.CartUpdatedWebhook
{
    public class CartUpdatedWebhookRequest
    {
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; } = "";

        [JsonProperty("line_items")]
        public ICollection<CartUpdatedWebhookLineItem> LineItems { get; set; } = new List<CartUpdatedWebhookLineItem>();

        [JsonProperty("note")]
        public string Note { get; set; } = "";

        [JsonProperty("token")]
        public string Token { get; set; } = "";

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
