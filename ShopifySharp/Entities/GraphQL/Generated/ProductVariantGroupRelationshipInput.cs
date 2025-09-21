#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for the bundle components for core.
/// </summary>
public record ProductVariantGroupRelationshipInput : GraphQLInputObject<ProductVariantGroupRelationshipInput>
{
    /// <summary>
    /// The ID of the product variant that's a component of the bundle.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The number of units of the product variant required to construct one unit of the bundle.
    /// </summary>
    [JsonPropertyName("quantity")]
    public int? quantity { get; set; } = null;
}