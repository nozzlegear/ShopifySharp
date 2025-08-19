#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `inventoryTransferDuplicate` mutation.
/// </summary>
public record InventoryTransferDuplicatePayload : IGraphQLObject
{
    /// <summary>
    /// The duplicated inventory transfer.
    /// </summary>
    [JsonPropertyName("inventoryTransfer")]
    public InventoryTransfer? inventoryTransfer { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryTransferDuplicateUserError>? userErrors { get; set; } = null;
}