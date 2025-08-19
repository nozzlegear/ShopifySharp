#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Identifies a metafield by its owner resource, namespace, and key.
/// </summary>
public record MetafieldIdentifier : IGraphQLObject
{
    /// <summary>
    /// The key of the metafield.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The namespace of the metafield.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? @namespace { get; set; } = null;

    /// <summary>
    /// GID of the owner resource that the metafield belongs to.
    /// </summary>
    [JsonPropertyName("ownerId")]
    public string? ownerId { get; set; } = null;
}