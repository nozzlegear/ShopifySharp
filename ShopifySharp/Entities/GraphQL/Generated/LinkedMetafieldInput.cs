#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The input fields for linking a combined listing option to a metafield.
/// </summary>
public record LinkedMetafieldInput : GraphQLInputObject<LinkedMetafieldInput>
{
    /// <summary>
    /// The key of the linked metafield.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The namespace of the linked metafield.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// The values of the linked metafield.
    /// </summary>
    [JsonPropertyName("values")]
    public ICollection<string>? values { get; set; } = null;
}