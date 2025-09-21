#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// FeedBurner provider details. Any blogs that aren't already integrated with FeedBurner can't use the service.
/// </summary>
public record BlogFeed : IGraphQLObject
{
    /// <summary>
    /// Blog feed provider url.
    /// </summary>
    [JsonPropertyName("location")]
    public string? location { get; set; } = null;

    /// <summary>
    /// Blog feed provider path.
    /// </summary>
    [JsonPropertyName("path")]
    public string? path { get; set; } = null;
}