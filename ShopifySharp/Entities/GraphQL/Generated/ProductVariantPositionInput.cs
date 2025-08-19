#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields representing a product variant position.
/// </summary>
public record ProductVariantPositionInput : GraphQLInputObject<ProductVariantPositionInput>
{
    /// <summary>
    /// Specifies the ID of the product variant to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The order of the product variant in the list of product variants. The first position in the list is 1.
    /// </summary>
    [JsonPropertyName("position")]
    public int? position { get; set; } = null;
}