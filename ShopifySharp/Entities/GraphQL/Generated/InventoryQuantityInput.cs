#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the quantity to be set for an inventory item at a location.
/// </summary>
public record InventoryQuantityInput : GraphQLInputObject<InventoryQuantityInput>
{
    /// <summary>
    /// The current quantity to be compared against the persisted quantity.
    /// </summary>
    [JsonPropertyName("compareQuantity")]
    public int? compareQuantity { get; set; } = null;

    /// <summary>
    /// Specifies the inventory item to which the quantity will be set.
    /// </summary>
    [JsonPropertyName("inventoryItemId")]
    public string? inventoryItemId { get; set; } = null;

    /// <summary>
    /// Specifies the location at which the quantity will be set.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// The quantity to which the inventory quantity will be set.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}