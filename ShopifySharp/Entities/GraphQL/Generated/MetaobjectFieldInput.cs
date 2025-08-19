#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for a metaobject field value.
/// </summary>
public record MetaobjectFieldInput : GraphQLInputObject<MetaobjectFieldInput>
{
    /// <summary>
    /// The key of the field.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The value of the field.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}