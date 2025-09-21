#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `inventoryAdjustQuantities` mutation.
/// </summary>
public record InventoryAdjustQuantitiesPayload : IGraphQLObject
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
    public ICollection<InventoryAdjustQuantitiesUserError>? userErrors { get; set; } = null;
}