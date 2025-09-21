#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields for creating or updating a product option value.
/// </summary>
public record OptionValueSetInput : GraphQLInputObject<OptionValueSetInput>
{
    /// <summary>
    /// Specifies the product option value.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Value associated with an option.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}