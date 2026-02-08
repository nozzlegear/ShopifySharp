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
/// Represents an update to a single transfer line item.
/// </summary>
public record InventoryTransferLineItemUpdate : IGraphQLObject
{
    /// <summary>
    /// The delta quantity for the transfer line item.
    /// </summary>
    [JsonPropertyName("deltaQuantity")]
    public int? deltaQuantity { get; set; } = null;

    /// <summary>
    /// The inventory item ID for the transfer line item.
    /// </summary>
    [JsonPropertyName("inventoryItemId")]
    public string? inventoryItemId { get; set; } = null;

    /// <summary>
    /// The new quantity for the transfer line item.
    /// </summary>
    [JsonPropertyName("newQuantity")]
    public int? newQuantity { get; set; } = null;
}