#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The URL redirect for the online store.
/// </summary>
public record UrlRedirect : IGraphQLObject, INode
{
    /// <summary>
    /// The ID of the URL redirect.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

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