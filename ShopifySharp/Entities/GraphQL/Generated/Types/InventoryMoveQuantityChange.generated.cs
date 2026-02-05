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
/// Represents the change to be made to an inventory item at a location.
/// The change can either involve the same quantity name between different locations,
/// or involve different quantity names between the same location.
/// </summary>
public record InventoryMoveQuantityChange : GraphQLInputObject<InventoryMoveQuantityChange>
{
    /// <summary>
    /// Details about where the move will be made from.
    /// </summary>
    [JsonPropertyName("from")]
    public InventoryMoveQuantityTerminalInput? @from { get; set; } = null;

    /// <summary>
    /// Specifies the inventory item to which the change will be applied.
    /// </summary>
    [JsonPropertyName("inventoryItemId")]
    public string? inventoryItemId { get; set; } = null;

    /// <summary>
    /// The amount by which the inventory quantity will be changed.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;

    /// <summary>
    /// Details about where the move will be made to.
    /// </summary>
    [JsonPropertyName("to")]
    public InventoryMoveQuantityTerminalInput? to { get; set; } = null;
}