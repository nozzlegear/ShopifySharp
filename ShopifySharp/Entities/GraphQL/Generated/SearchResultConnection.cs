#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The connection type for SearchResult.
/// </summary>
public record SearchResultConnection : ConnectionWithEdges<SearchResultEdge?>
{
    /// <summary>
    /// An object that’s used to retrieve [cursor
    /// information](https://shopify.dev/api/usage/pagination-graphql) about the current page.
    /// </summary>
    [JsonPropertyName("resultsAfterCount")]
    [Obsolete("The provided information is not accurate.")]
    public int? resultsAfterCount { get; set; } = null;
}