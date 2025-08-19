#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents an individual result returned from a search.
/// </summary>
public record SearchResult : IGraphQLObject
{
    /// <summary>
    /// Returns the search result description text.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// Returns the Image resource presented to accompany a search result.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// Returns the ID of the resource returned in the search result.
    /// </summary>
    [JsonPropertyName("reference")]
    public INode? reference { get; set; } = null;

    /// <summary>
    /// Returns the resource title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// Returns the absolute URL to the resource in the search result.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}