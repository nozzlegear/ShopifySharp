using Newtonsoft.Json;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify order edit.
    /// </summary>
    public class OrderEdit : ShopifyObject
    {
        /// <summary>
        /// Unique identifier of the app who created the order edit.
        /// </summary>
        [JsonProperty("app_id")]
        public long? AppId { get; set; }

        /// <summary>
        /// The date and time when the order was edited in Shopify.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// A flag indicating whether the customer should be notified.
        /// </summary>
        [JsonProperty("notify_customer")]
        public bool? NotifyCustomer { get; set; }

        /// <summary>
        /// The unique numeric identifier for the order associated to this edit
        /// </summary>
        [JsonProperty("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// The text of an optional note that a shop owner can attach to the order.
        /// </summary>
        [JsonProperty("staff_note")]
        public string StaffNote { get; set; }

        /// <summary>
        /// The unique numerical identifier of the user that made this edit
        /// </summary>
        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        /// <summary>
        /// Changes to line items
        /// </summary>
        [JsonProperty("line_items")]
        public OrderEditLineItems LineItems { get; set; }
    }
}
