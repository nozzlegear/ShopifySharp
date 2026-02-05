#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `inventorySetQuantities` mutation.
/// </summary>
public record InventorySetQuantitiesPayload : IGraphQLObject
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
    public ICollection<InventorySetQuantitiesUserError>? userErrors { get; set; } = null;
}