#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for the split applied to the fulfillment order.
/// </summary>
public record FulfillmentOrderSplitInput : GraphQLInputObject<FulfillmentOrderSplitInput>
{
    /// <summary>
    /// The ID of the fulfillment order to be split.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderId")]
    public string? fulfillmentOrderId { get; set; } = null;

    /// <summary>
    /// The fulfillment order line items to be split out.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderLineItems")]
    public ICollection<FulfillmentOrderLineItemInput>? fulfillmentOrderLineItems { get; set; } = null;
}