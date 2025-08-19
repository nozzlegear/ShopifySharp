#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A product feed.
/// </summary>
public record ProductFeed : IGraphQLObject, INode
{
    /// <summary>
    /// The country of the product feed.
    /// </summary>
    [JsonPropertyName("country")]
    public CountryCode? country { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The language of the product feed.
    /// </summary>
    [JsonPropertyName("language")]
    public LanguageCode? language { get; set; } = null;

    /// <summary>
    /// The status of the product feed.
    /// </summary>
    [JsonPropertyName("status")]
    public ProductFeedStatus? status { get; set; } = null;
}