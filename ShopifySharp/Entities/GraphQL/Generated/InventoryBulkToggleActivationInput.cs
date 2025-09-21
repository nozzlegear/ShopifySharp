#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to specify whether the inventory item should be activated or not at the specified location.
/// </summary>
public record InventoryBulkToggleActivationInput : GraphQLInputObject<InventoryBulkToggleActivationInput>
{
    /// <summary>
    /// Whether the inventory item can be stocked at the specified location. To
    /// deactivate, set the value to false which removes an inventory item's
    /// quantities from that location, and turns off inventory at that location.
    /// </summary>
    [JsonPropertyName("activate")]
    public bool? activate { get; set; } = null;

    /// <summary>
    /// The ID of the location to modify the inventory item's stocked status.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;
}