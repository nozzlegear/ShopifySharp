#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Properties used by customers to select a product variant.
/// Products can have multiple options, like different sizes or colors.
/// </summary>
public record SelectedOption : IGraphQLObject
{
    /// <summary>
    /// The product option’s name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The product option’s value object.
    /// </summary>
    [JsonPropertyName("optionValue")]
    public ProductOptionValue? optionValue { get; set; } = null;

    /// <summary>
    /// The product option’s value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}