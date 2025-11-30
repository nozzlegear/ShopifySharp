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
/// The input fields for a script tag. This input object is used when creating or updating
/// a script tag to specify its URL, where it should be included, and how it will be cached.
/// </summary>
public record ScriptTagInput : GraphQLInputObject<ScriptTagInput>
{
    /// <summary>
    /// Whether the Shopify CDN can cache and serve the script tag.
    /// If `true`, then the script will be cached and served by the CDN.
    /// The cache expires 15 minutes after the script tag is successfully returned.
    /// If `false`, then the script is served as is.
    /// The default value is `false`.
    /// </summary>
    [JsonPropertyName("cache")]
    public bool? cache { get; set; } = null;

    /// <summary>
    /// The page or pages on the online store where the script should be included.
    /// </summary>
    [JsonPropertyName("displayScope")]
    public ScriptTagDisplayScope? displayScope { get; set; } = null;

    /// <summary>
    /// The URL of the remote script. For example: `https://example.com/path/to/script.js`.
    /// </summary>
    [JsonPropertyName("src")]
    public string? src { get; set; } = null;
}