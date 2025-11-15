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
/// The input fields for an inventory level.
/// </summary>
public record InventoryLevelInput : GraphQLInputObject<InventoryLevelInput>
{
    /// <summary>
    /// The available quantity of an inventory item at a location.
    /// </summary>
    [JsonPropertyName("availableQuantity")]
    public int? availableQuantity { get; set; } = null;

    /// <summary>
    /// The ID of a location associated with the inventory level.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;
}