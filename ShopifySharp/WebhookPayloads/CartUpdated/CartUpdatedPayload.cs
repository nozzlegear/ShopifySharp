#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.WebhookPayloads.CartUpdated
{
    /// <summary>
    /// The object sent by Shopify's <c>carts/update</c> webhook.
    /// </summary>
    public class CartUpdatedPayload
    {
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("line_items")]
        public ICollection<CartUpdatedLineItem> LineItems { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
