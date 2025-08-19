#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A locale.
/// </summary>
public record Locale : IGraphQLObject
{
    /// <summary>
    /// Locale ISO code.
    /// </summary>
    [JsonPropertyName("isoCode")]
    public string? isoCode { get; set; } = null;

    /// <summary>
    /// Human-readable locale name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;
}