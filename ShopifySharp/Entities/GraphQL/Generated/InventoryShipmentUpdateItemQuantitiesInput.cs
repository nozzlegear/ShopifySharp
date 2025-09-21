#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for a line item on an inventory shipment.
/// </summary>
public record InventoryShipmentUpdateItemQuantitiesInput : GraphQLInputObject<InventoryShipmentUpdateItemQuantitiesInput>
{
    /// <summary>
    /// The quantity for the shipment line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The ID for the inventory shipment line item.
    /// </summary>
    [JsonPropertyName("shipmentLineItemId")]
    public string? shipmentLineItemId { get; set; } = null;
}