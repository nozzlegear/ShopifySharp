#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The type and name for the optional validation configuration of a metafield.
/// For example, a supported validation might consist of a `max` name and a `number_integer` type.
/// This validation can then be used to enforce a maximum character length for a `single_line_text_field` metafield.
/// </summary>
public record MetafieldDefinitionSupportedValidation : IGraphQLObject
{
    /// <summary>
    /// The name of the metafield definition validation.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The type of input for the validation.
    /// </summary>
    [JsonPropertyName("type")]
    public string? type { get; set; } = null;
}