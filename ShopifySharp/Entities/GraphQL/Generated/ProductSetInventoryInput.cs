#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to set inventory quantities using `productSet` mutation.
/// </summary>
public record ProductSetInventoryInput : GraphQLInputObject<ProductSetInventoryInput>
{
    /// <summary>
    /// The ID of the location of the inventory quantity being set.
    /// </summary>
    [JsonPropertyName("locationId")]
    public string? locationId { get; set; } = null;

    /// <summary>
    /// The name of the inventory quantity being set. Must be one of `available` or `on_hand`.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The values to which each quantities will be set.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}