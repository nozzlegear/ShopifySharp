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