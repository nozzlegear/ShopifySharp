#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to receive an item on an inventory shipment.
/// </summary>
public record InventoryShipmentReceiveItemInput : GraphQLInputObject<InventoryShipmentReceiveItemInput>
{
    /// <summary>
    /// The quantity for the item to be received.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// The reason for received item.
    /// </summary>
    [JsonPropertyName("reason")]
    public InventoryShipmentReceiveLineItemReason? reason { get; set; } = null;

    /// <summary>
    /// The shipment line item ID to be received.
    /// </summary>
    [JsonPropertyName("shipmentLineItemId")]
    public string? shipmentLineItemId { get; set; } = null;
}