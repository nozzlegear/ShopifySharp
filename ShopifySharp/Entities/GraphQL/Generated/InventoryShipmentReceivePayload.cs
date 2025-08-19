#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `inventoryShipmentReceive` mutation.
/// </summary>
public record InventoryShipmentReceivePayload : IGraphQLObject
{
    /// <summary>
    /// The inventory shipment with received items.
    /// </summary>
    [JsonPropertyName("inventoryShipment")]
    public InventoryShipment? inventoryShipment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryShipmentReceiveUserError>? userErrors { get; set; } = null;
}