#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the base64 encoded body of a theme file.
/// </summary>
public record OnlineStoreThemeFileBodyBase64 : OnlineStoreThemeFileBody, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The body of the theme file, base64 encoded.
    /// </summary>
    [JsonPropertyName("contentBase64")]
    public string? contentBase64 { get; set; } = null;
}