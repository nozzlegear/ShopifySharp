#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `inventoryItemUpdate` mutation.
/// </summary>
public record InventoryItemUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The inventory item that was updated.
    /// </summary>
    [JsonPropertyName("inventoryItem")]
    public InventoryItem? inventoryItem { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}