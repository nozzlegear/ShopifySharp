#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `inventoryMoveQuantities` mutation.
/// </summary>
public record InventoryMoveQuantitiesPayload : IGraphQLObject
{
    /// <summary>
    /// The group of changes made by the operation.
    /// </summary>
    [JsonPropertyName("inventoryAdjustmentGroup")]
    public InventoryAdjustmentGroup? inventoryAdjustmentGroup { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryMoveQuantitiesUserError>? userErrors { get; set; } = null;
}