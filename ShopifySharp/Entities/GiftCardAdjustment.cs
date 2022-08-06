using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    public class GiftCardAdjustment : ShopifyObject
    {
        /// <summary>
        /// A unique numeric identifier for gift card the adjustment is applied onto.
        /// </summary>
        [JsonProperty("gift_card_id")]
        public long? GiftCardId { get; set; }

        /// <summary>
        /// A numeric sequence number for this adjustment with respect to the gift card.
        /// </summary>
        [JsonProperty("number")]
        public int? Number { get; set; }

        /// <summary>
        /// A number (signed) representing the value of the adjustment.
        /// </summary>
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// The text of an optional note that can be attached to the adjustment. 
        /// This value is not visible to customers.
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// The text of an optional reference note that can be attached to the adjustment. 
        /// This value is not visible to customers.
        /// </summary>
        [JsonProperty("remote_transaction_ref")]
        public string RemoteTransactionRef { get; set; }

        /// <summary>
        /// An optional reference URL that can be attached to the adjustment. 
        /// This value is not visible to customers.
        /// </summary>
        [JsonProperty("remote_transaction_url")]
        public string RemoteTransactionUrl { get; set; }

        /// <summary>
        /// A unique numeric identifier of the application that issued the adjustment (if it was issued by an application).
        /// </summary>
        [JsonProperty("api_client_id")]
        public int? ApiClientId { get; set; }

        /// <summary>
        /// A unique numeric identifier of the user that issued the adjustment (if it was issued by a user).
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// A unique numeric identifier of the order transaction that issued the adjustment 
        /// (if it was caused by an application of a gift card to an order).
        /// </summary>
        [JsonProperty("order_transaction_id")]
        public long? OrderTransactionId { get; set; }

        /// <summary>
        /// The date and time when the adjustment was created. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the gift card adjustment was updated in ISO 8601 format.
        /// </summary>
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The date and time when the adjustment was imported, in ISO 8601 format. 
        /// This value can be set to dates in the past when importing from other systems. 
        /// If no value is provided, it will be auto-generated.
        /// </summary>
        [JsonProperty("processed_at")]
        public DateTime? ProcessedAt { get; set; }

    }
}
