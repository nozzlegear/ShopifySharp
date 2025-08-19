#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A filter in a search query represented by a key value pair.
/// </summary>
public record SearchFilter : IGraphQLObject
{
    /// <summary>
    /// The key of the search filter.
    /// </summary>
    [JsonPropertyName("key")]
    public string? key { get; set; } = null;

    /// <summary>
    /// The value of the search filter.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}