#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `inventoryShipmentRemoveItems` mutation.
/// </summary>
public record InventoryShipmentRemoveItemsPayload : IGraphQLObject
{
    /// <summary>
    /// The inventory shipment with items removed.
    /// </summary>
    [JsonPropertyName("inventoryShipment")]
    public InventoryShipment? inventoryShipment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryShipmentRemoveItemsUserError>? userErrors { get; set; } = null;
}