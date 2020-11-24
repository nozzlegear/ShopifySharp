using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ShopifySharp.Entities
{
    public class FulfillmentOrderLineItem
    {
        /// <summary>
        /// The ID of the fulfillment order line item.
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The ID of the shop associated with the fulfillment order line item.
        /// </summary>
        [JsonProperty("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// The ID of the fulfillment order associated with this line item.
        /// </summary>
        [JsonProperty("fulfillment_order_id")]
        public long FulfillmentOrderId { get; set; }

        /// <summary>
        /// The ID of the line item associated with this fulfillment order line item.
        /// </summary>
        [JsonProperty("line_item_id")]
        public long LineItemId { get; set; }

        /// <summary>
        /// The ID of the inventory item associated with this fulfillment order line item.
        /// </summary>
        [JsonProperty("inventory_item_id")]
        public long InventoryItemId { get; set; }

        /// <summary>
        /// The total number of units to be fulfilled.
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// The number of units remaining to be fulfilled.
        /// </summary>
        [JsonProperty("fulfillable_quantity")]
        public long FulfillableQuantity { get; set; }

        /// <summary>
        /// The ID of the variant associated with this fulfillment order line item.
        /// </summary>
        [JsonProperty("variant_id")]
        public long VariantId { get; set; }
    }
}
