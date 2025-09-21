#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields required to link a product option to a metafield.
/// </summary>
public record LinkedMetafieldCreateInput : GraphQLInputObject<LinkedMetafieldCreateInput>
{
    /// <summary>
    /// The key of the metafield this option is linked to.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The namespace of the metafield this option is linked to.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// Values associated with the option.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<string>? values { get; set; } = null;
}