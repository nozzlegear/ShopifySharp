#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the body of a theme file.
/// </summary>
public record OnlineStoreThemeFileBodyText : OnlineStoreThemeFileBody, IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The body of the theme file.
    /// </summary>
    [JsonPropertyName("content")]
    public string? content { get; set; } = null;
}