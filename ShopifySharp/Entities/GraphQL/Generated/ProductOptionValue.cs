#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The product option value names. For example, "Red", "Blue", and "Green" for a "Color" option.
/// </summary>
public record ProductOptionValue : IGraphQLObject, IHasPublishedTranslations, INode
{
    /// <summary>
    /// Whether the product option value has any linked variants.
    /// </summary>
    [JsonPropertyName("hasVariants")]
    public bool? hasVariants { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The value of the linked metafield.
    /// </summary>
    [JsonPropertyName("linkedMetafieldValue")]
    public string? linkedMetafieldValue { get; set; } = null;

    /// <summary>
    /// The name of the product option value.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The swatch associated with the product option value.
    /// </summary>
    [JsonPropertyName("swatch")]
    public ProductOptionValueSwatch? swatch { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;
}