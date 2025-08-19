#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a line item on an inventory shipment.
/// </summary>
public record InventoryShipmentLineItemInput : GraphQLInputObject<InventoryShipmentLineItemInput>
{
    /// <summary>
    /// The inventory item ID for the shipment line item.
    /// </summary>
    [JsonPropertyName("inventoryItemId")]
    public string? inventoryItemId { get; set; } = null;

    /// <summary>
    /// The quantity for the shipment line item.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}