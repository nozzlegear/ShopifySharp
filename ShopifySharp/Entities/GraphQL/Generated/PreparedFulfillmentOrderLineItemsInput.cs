#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields used to include the line items of a specified fulfillment order
/// that should be marked as prepared for pickup by a customer.
/// </summary>
public record PreparedFulfillmentOrderLineItemsInput : GraphQLInputObject<PreparedFulfillmentOrderLineItemsInput>
{
    /// <summary>
    /// The ID of the fulfillment order.
    /// </summary>
    [JsonPropertyName("fulfillmentOrderId")]
    public string? fulfillmentOrderId { get; set; } = null;
}