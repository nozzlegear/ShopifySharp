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
/// Represents the url of the body of a theme file.
/// </summary>
public record OnlineStoreThemeFileBodyUrl : IGraphQLUnionCase, IGraphQLObject
{
    /// <summary>
    /// The short lived url for the body of the theme file.
    /// </summary>
    [JsonPropertyName("url")]
    public string? url { get; set; } = null;
}