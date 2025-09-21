#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for identifying a product.
/// </summary>
public record ProductIdentifierInput : GraphQLInputObject<ProductIdentifierInput>
{
    /// <summary>
    /// The [custom ID](https://shopify.dev/docs/apps/build/custom-data/metafields/working-with-custom-ids) of the product.
    /// </summary>
    [JsonPropertyName("customId")]
    public UniqueMetafieldValueInput? customId { get; set; } = null;

    /// <summary>
    /// The handle of the product.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// The ID of the product.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}