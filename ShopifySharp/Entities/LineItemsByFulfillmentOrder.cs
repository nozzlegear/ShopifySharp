using Newtonsoft.Json;
using System.Collections.Generic;

namespace ShopifySharp
{
    public class LineItemsByFulfillmentOrder
    {
        /// <summary>
        /// The ID of the fulfillment order associated with this line item.
        /// </summary>
        [JsonProperty("fulfillment_order_id")]
        public long? FulfillmentOrderId { get; set; }

        /// <summary>
        /// The fulfillment order line items to be requested for fulfillment. If left blank, all line items of the fulfillment order are requested for fulfillment.
        /// </summary>
        [JsonProperty("fulfillment_order_line_items")]
        public ICollection<FulfillmentRequestOrderLineItems> FulfillmentRequestOrderLineItems { get; set; }
    }
}
