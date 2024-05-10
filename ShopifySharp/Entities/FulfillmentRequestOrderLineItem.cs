using Newtonsoft.Json;

namespace ShopifySharp;

/// <summary>
/// An object representing a Shopify fulfillment request order line items.
/// </summary>
public class FulfillmentRequestOrderLineItem : ShopifyObject
{
    /// <summary>
    /// The id of the fulfillment order line item being fulfilled. This is **not** the same as <see cref="FulfillmentOrderLineItem.LineItemId"/>;
    /// instead, Shopify expects the value of <see cref="FulfillmentOrderLineItem.Id"/>.
    /// </summary>
    [JsonProperty("id")]
    public new long? Id { get; set; }

    /// <summary>
    /// The total number of units to be fulfilled.
    /// </summary>
    [JsonProperty("quantity")]
    public long? Quantity { get; set; }

}