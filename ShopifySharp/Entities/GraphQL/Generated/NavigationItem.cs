#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A navigation item, holding basic link attributes.
/// </summary>
public record NavigationItem : IGraphQLObject
{
    /// <summary>
    /// The unique identifier of the navigation item.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the navigation item.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The URL of the page that the navigation item links to.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}