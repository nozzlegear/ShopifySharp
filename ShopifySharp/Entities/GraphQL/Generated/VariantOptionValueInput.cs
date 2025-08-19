#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields required to create or modify a product variant's option value.
/// </summary>
public record VariantOptionValueInput : GraphQLInputObject<VariantOptionValueInput>
{
    /// <summary>
    /// Specifies the product option value by ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Metafield value associated with an option.
    /// </summary>
    [JsonPropertyName("linkedMetafieldValue")]
    public string? linkedMetafieldValue { get; set; } = null;

    /// <summary>
    /// Specifies the product option value by name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// Specifies the product option by ID.
    /// </summary>
    [JsonPropertyName("optionId")]
    public string? optionId { get; set; } = null;

    /// <summary>
    /// Specifies the product option by name.
    /// </summary>
    [JsonPropertyName("optionName")]
    public string? optionName { get; set; } = null;
}