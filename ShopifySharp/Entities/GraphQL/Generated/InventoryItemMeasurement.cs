#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the packaged dimension for an inventory item.
/// </summary>
public record InventoryItemMeasurement : IGraphQLObject, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The weight of the inventory item.
    /// </summary>
    [JsonPropertyName("weight")]
    public Weight? weight { get; set; } = null;
}