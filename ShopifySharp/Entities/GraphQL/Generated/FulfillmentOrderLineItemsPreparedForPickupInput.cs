#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for marking fulfillment order line items as ready for pickup.
/// </summary>
public record FulfillmentOrderLineItemsPreparedForPickupInput : GraphQLInputObject<FulfillmentOrderLineItemsPreparedForPickupInput>
{
    /// <summary>
    /// The fulfillment orders associated with the line items which are ready to be picked up by a customer.
    /// </summary>
    [JsonPropertyName("lineItemsByFulfillmentOrder")]
    public ICollection<PreparedFulfillmentOrderLineItemsInput>? lineItemsByFulfillmentOrder { get; set; } = null;
}