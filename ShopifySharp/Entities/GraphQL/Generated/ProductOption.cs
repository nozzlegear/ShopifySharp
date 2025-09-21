#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The product property names. For example, "Size", "Color", and "Material".
/// Variants are selected based on permutations of these options.
/// The limit for each product property name is 255 characters.
/// </summary>
public record ProductOption : IGraphQLObject, IHasPublishedTranslations, INode
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The metafield identifier linked to this option.
    /// </summary>
    [JsonPropertyName("linkedMetafield")]
    public LinkedMetafield? linkedMetafield { get; set; } = null;

    /// <summary>
    /// The product option’s name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Similar to values, option_values returns all the corresponding option value
    /// objects to the product option, including values not assigned to any variants.
    /// </summary>
    [JsonPropertyName("optionValues")]
    public ICollection<ProductOptionValue>? optionValues { get; set; } = null;

    /// <summary>
    /// The product option's position.
    /// </summary>
    [JsonPropertyName("position")]
    public int? position { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The corresponding value to the product option name.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<string>? values { get; set; } = null;
}