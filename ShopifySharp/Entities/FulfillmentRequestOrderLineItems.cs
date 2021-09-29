using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify fulfillment request order line items.
    /// </summary>
    public class FulfillmentRequestOrderLineItems
    {
        /// <summary>
        /// The ID of the fulfillment order line item.
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The total number of units to be fulfilled.
        /// </summary>
        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

    }
}