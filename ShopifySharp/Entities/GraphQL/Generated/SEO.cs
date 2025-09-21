#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// SEO information.
/// </summary>
public record SEO : IGraphQLObject
{
    /// <summary>
    /// SEO Description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// SEO Title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;
}