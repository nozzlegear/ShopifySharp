#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// An auto-generated type for paginating through multiple OnlineStoreThemeFiles.
/// </summary>
public record OnlineStoreThemeFileConnection : ConnectionWithNodesAndEdges<OnlineStoreThemeFile?>
{
    /// <summary>
    /// List of errors that occurred during the request.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<OnlineStoreThemeFileReadResult>? userErrors { get; set; } = null;
}