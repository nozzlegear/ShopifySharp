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
/// Return type for `inventoryBulkToggleActivation` mutation.
/// </summary>
public record InventoryBulkToggleActivationPayload : IGraphQLObject
{
    /// <summary>
    /// The inventory item that was updated.
    /// </summary>
    [JsonPropertyName("inventoryItem")]
    public InventoryItem? inventoryItem { get; set; } = null;

    /// <summary>
    /// The activated inventory levels.
    /// </summary>
    [JsonPropertyName("inventoryLevels")]
    public ICollection<InventoryLevel>? inventoryLevels { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryBulkToggleActivationUserError>? userErrors { get; set; } = null;
}