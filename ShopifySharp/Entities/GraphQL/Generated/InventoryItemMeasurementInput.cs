#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for an inventory item measurement.
/// </summary>
public record InventoryItemMeasurementInput : GraphQLInputObject<InventoryItemMeasurementInput>
{
    /// <summary>
    /// The weight of the inventory item.
    /// </summary>
    [JsonPropertyName("weight")]
    public WeightInput? weight { get; set; } = null;
}