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
/// A preview of a URL redirect import row.
/// </summary>
public record UrlRedirectImportPreview : IGraphQLObject
{
    /// <summary>
    /// The old path to be redirected from. When the user visits this path, they will be redirected to the target location.
    /// </summary>
    [JsonPropertyName("path")]
    public string? path { get; set; } = null;

    /// <summary>
    /// The target location where the user will be redirected to.
    /// </summary>
    [JsonPropertyName("target")]
    public string? target { get; set; } = null;
}