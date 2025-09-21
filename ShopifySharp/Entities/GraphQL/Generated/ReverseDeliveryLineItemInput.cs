#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a reverse delivery line item.
/// </summary>
public record ReverseDeliveryLineItemInput : GraphQLInputObject<ReverseDeliveryLineItemInput>
{
    /// <summary>
    /// The quantity of the item to be included in the delivery.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The ID of the related reverse fulfillment order line item.
    /// </summary>
    [JsonPropertyName("reverseFulfillmentOrderLineItemId")]
    public string? reverseFulfillmentOrderLineItemId { get; set; } = null;
}