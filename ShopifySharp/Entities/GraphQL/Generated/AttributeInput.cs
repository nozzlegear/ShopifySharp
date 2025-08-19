#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for an attribute.
/// </summary>
public record AttributeInput : GraphQLInputObject<AttributeInput>
{
    /// <summary>
    /// Key or name of the attribute.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// Value of the attribute.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}