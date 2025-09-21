#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `inventoryTransferDelete` mutation.
/// </summary>
public record InventoryTransferDeletePayload : IGraphQLObject
{
    /// <summary>
    /// The ID of the deleted inventory transfer.
    /// </summary>
    [JsonPropertyName("deletedId")]
    public string? deletedId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryTransferDeleteUserError>? userErrors { get; set; } = null;
}