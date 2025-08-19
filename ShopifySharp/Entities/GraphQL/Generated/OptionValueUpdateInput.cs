#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for updating a product option value.
/// </summary>
public record OptionValueUpdateInput : GraphQLInputObject<OptionValueUpdateInput>
{
    /// <summary>
    /// Specifies the product option value.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// Metafield value associated with an option.
    /// </summary>
    [JsonPropertyName("linkedMetafieldValue")]
    public string? linkedMetafieldValue { get; set; } = null;

    /// <summary>
    /// Value associated with an option.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}