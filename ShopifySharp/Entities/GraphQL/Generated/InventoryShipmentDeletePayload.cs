#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `inventoryShipmentDelete` mutation.
/// </summary>
public record InventoryShipmentDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the inventory shipment that was deleted.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryShipmentDeleteUserError>? userErrors { get; set; } = null;
}