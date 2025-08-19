#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `inventoryShipmentCreate` mutation.
/// </summary>
public record InventoryShipmentCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created inventory shipment.
    /// </summary>
    [JsonPropertyName("inventoryShipment")]
    public InventoryShipment? inventoryShipment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryShipmentCreateUserError>? userErrors { get; set; } = null;
}