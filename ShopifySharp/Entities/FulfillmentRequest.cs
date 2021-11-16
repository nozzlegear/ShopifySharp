using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// An object representing a Shopify fulfillment request.
    /// </summary>
    public class FulfillmentRequest
    {
        /// <summary>
        /// An optional message for the fulfillment request.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// The fulfillment order line items to be requested for fulfillment. If left blank, all line items of the fulfillment order are requested for fulfillment.
        /// </summary>
        [JsonProperty("fulfillment_order_line_items")]
        public IEnumerable<FulfillmentRequestOrderLineItem> FulfillmentRequestOrderLineItems { get; set; }
    }
}