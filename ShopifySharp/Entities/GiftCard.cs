using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class GiftCard : ShopifyObject
    {
        /// <summary>
        /// Returns the amount of money remaining on the gift card.
        /// </summary>
        [JsonProperty("balance")]
        public decimal Balance { get; set; }

        /// <summary>
        /// The date and time when the gift card was created. 
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the gift card was updated. 
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// The three letter code (ISO 4217) for the currency used for the gift card.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the initial amount of money on the gift card.
        /// </summary>
        [JsonProperty("initial_value")]
        public decimal InitialValue { get; set; }

        /// <summary>
        /// The date and time when the gift card was disabled. 
        /// </summary>
        [JsonProperty("disabled_at")]
        public DateTimeOffset? DisabledAt { get; set; }

        /// <summary>
        /// The date and time when the gift card will expire. 
        /// </summary>
        [JsonProperty("expires_on")]
        public DateTimeOffset? ExpiresOn { get; set; }

        /// <summary>
        /// A unique numeric identifier of the line_item that caused the creation of this gift card (if it was created by an order).
        /// </summary>
        [JsonProperty("line_item_id")]
        public string LineItemId { get; set; }


        /// <summary>
        /// A unique numeric identifier of the application that issued the gift card (if it was issued by an application).
        /// </summary>
        [JsonProperty("api_client_id")]
        public long? ApiClientId { get; set; }


        /// <summary>
        /// A unique numeric identifier of the user that issued the gift card (if it was issued by a user).
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }


        /// <summary>
        /// The id of a customer who is associated with this gift card.
        /// </summary>
        [JsonProperty("customer_id")]
        public long? CustomerId { get; set; }


        /// <summary>
        /// The text of an optional note that a shop owner can attach to the gift card. Not visible to merchants.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// When specified, the gift card will be rendered using gift_card.SUFFIX.liquid instead of gift_card.liquid.
        /// </summary>
        [JsonProperty("template_suffix")]
        public string TemplateSuffix { get; set; }

        /// <summary>
        /// The last four characters of the gift card code. Because gift cards are alternate payment methods, the full code cannot be retrieved.
        /// </summary>
        [JsonProperty("last_characters")]
        public string LastCharacters { get; set; }

        /// <summary>
        /// A unique numeric identifier of the order that caused the creation of this gift card (if it was created by an order).
        /// </summary>
        [JsonProperty("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// Thethe gift card code. Only for Creation
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}
