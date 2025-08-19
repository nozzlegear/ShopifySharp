#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a LocalizedFieldInput.
/// </summary>
public record LocalizedFieldInput : GraphQLInputObject<LocalizedFieldInput>
{
    /// <summary>
    /// The key for the localized field.
    /// </summary>
    [JsonPropertyName("key")]
    public LocalizedFieldKey? key { get; set; } = null;

    /// <summary>
    /// The localized field value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}