#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to create a fulfillment from fulfillment orders.
/// </summary>
public record FulfillmentInput : GraphQLInputObject<FulfillmentInput>
{
    /// <summary>
    /// Pairs of `fulfillment_order_id` and `fulfillment_order_line_items` that represent the fulfillment
    /// order line items that have to be fulfilled for each fulfillment order.  For any given pair, if the
    /// fulfillment order line items are left blank then all the fulfillment order line items of the
    /// associated fulfillment order ID will be fulfilled.
    /// </summary>
    [JsonPropertyName("lineItemsByFulfillmentOrder")]
    public ICollection<FulfillmentOrderLineItemsInput>? lineItemsByFulfillmentOrder { get; set; } = null;

    /// <summary>
    /// Whether the customer is notified.
    /// If `true`, then a notification is sent when the fulfillment is created. The default value is `false`.
    /// </summary>
    [JsonPropertyName("notifyCustomer")]
    public bool? notifyCustomer { get; set; } = null;

    /// <summary>
    /// Address information about the location from which the order was fulfilled.
    /// </summary>
    [JsonPropertyName("originAddress")]
    public FulfillmentOriginAddressInput? originAddress { get; set; } = null;

    /// <summary>
    /// The fulfillment's tracking information, including a tracking URL, a tracking number,
    /// and the company associated with the fulfillment.
    /// </summary>
    [JsonPropertyName("trackingInfo")]
    public FulfillmentTrackingInput? trackingInfo { get; set; } = null;
}