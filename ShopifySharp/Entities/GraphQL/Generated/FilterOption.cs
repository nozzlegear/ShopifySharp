#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A filter option is one possible value in a search filter.
/// </summary>
public record FilterOption : IGraphQLObject
{
    /// <summary>
    /// The filter option's label for display purposes.
    /// </summary>
    [JsonPropertyName("label")]
    public string? label { get; set; } = null;

    /// <summary>
    /// The filter option's value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? @value { get; set; } = null;
}