#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `inventoryTransferCreate` mutation.
/// </summary>
public record InventoryTransferCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The created inventory transfer.
    /// </summary>
    [JsonPropertyName("inventoryTransfer")]
    public InventoryTransfer? inventoryTransfer { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryTransferCreateUserError>? userErrors { get; set; } = null;
}