#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `inventoryTransferMarkAsReadyToShip` mutation.
/// </summary>
public record InventoryTransferMarkAsReadyToShipPayload : IGraphQLObject
{
    /// <summary>
    /// The ready to ship inventory transfer.
    /// </summary>
    [JsonPropertyName("inventoryTransfer")]
    public InventoryTransfer? inventoryTransfer { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<InventoryTransferMarkAsReadyToShipUserError>? userErrors { get; set; } = null;
}