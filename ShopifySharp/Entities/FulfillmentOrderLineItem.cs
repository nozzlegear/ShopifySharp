using Newtonsoft.Json;

namespace ShopifySharp;

public class FulfillmentOrderLineItem : ShopifyObject
{
    /// <summary>
    /// The ID of the shop associated with the fulfillment order line item.
    /// </summary>
    [JsonProperty("shop_id")]
    public long? ShopId { get; set; }

    /// <summary>
    /// The ID of the fulfillment order associated with this line item.
    /// </summary>
    [JsonProperty("fulfillment_order_id")]
    public long? FulfillmentOrderId { get; set; }

    /// <summary>
    /// The ID of the line item associated with this fulfillment order line item.
    /// Note: this is **not** what should be used as the value for <see cref="FulfillmentRequestOrderLineItem.Id"/>;
    /// for that, you'll want to use <see cref="FulfillmentOrderLineItem.Id"/>.
    /// </summary>
    [JsonProperty("line_item_id")]
    public long? LineItemId { get; set; }

    /// <summary>
    /// The ID of the inventory item associated with this fulfillment order line item.
    /// </summary>
    [JsonProperty("inventory_item_id")]
    public long? InventoryItemId { get; set; }

    /// <summary>
    /// The total number of units to be fulfilled.
    /// </summary>
    [JsonProperty("quantity")]
    public long? Quantity { get; set; }

    /// <summary>
    /// The number of units remaining to be fulfilled.
    /// </summary>
    [JsonProperty("fulfillable_quantity")]
    public long? FulfillableQuantity { get; set; }

    /// <summary>
    /// The ID of the variant associated with this fulfillment order line item.
    /// </summary>
    [JsonProperty("variant_id")]
    public long? VariantId { get; set; }
}