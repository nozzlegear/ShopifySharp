#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Represents the body of a theme file.
/// </summary>
public record OnlineStoreThemeFileBodyText : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The body of the theme file.
    /// </summary>
    [JsonPropertyName("content")]
    public string? content { get; set; } = null;
}