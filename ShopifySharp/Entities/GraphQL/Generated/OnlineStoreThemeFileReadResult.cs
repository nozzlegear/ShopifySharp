#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the result of a read operation performed on a theme asset.
/// </summary>
public record OnlineStoreThemeFileReadResult : IGraphQLObject
{
    /// <summary>
    /// Type that indicates the result of the operation.
    /// </summary>
    [JsonPropertyName("code")]
    public OnlineStoreThemeFileResultType? code { get; set; } = null;

    /// <summary>
    /// Unique identifier associated with the operation and the theme file.
    /// </summary>
    [JsonPropertyName("filename")]
    public string? filename { get; set; } = null;
}