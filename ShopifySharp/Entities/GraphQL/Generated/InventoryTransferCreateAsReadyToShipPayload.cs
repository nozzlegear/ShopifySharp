#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `inventoryTransferCreateAsReadyToShip` mutation.
/// </summary>
public record InventoryTransferCreateAsReadyToShipPayload : IGraphQLObject
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
    public ICollection<InventoryTransferCreateAsReadyToShipUserError>? userErrors { get; set; } = null;
}