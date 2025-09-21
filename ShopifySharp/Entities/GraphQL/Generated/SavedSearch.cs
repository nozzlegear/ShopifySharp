#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A saved search is a representation of a search query saved in the admin.
/// </summary>
public record SavedSearch : IGraphQLObject, ILegacyInteroperability, INode
{
    /// <summary>
    /// The filters of a saved search.
    /// </summary>
    [JsonPropertyName("filters")]
    public ICollection<SearchFilter>? filters { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// The name of a saved search.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The query string of a saved search. This includes search terms and filters.
    /// </summary>
    [JsonPropertyName("query")]
    public string? query { get; set; } = null;

    /// <summary>
    /// The type of resource this saved search is searching in.
    /// </summary>
    [JsonPropertyName("resourceType")]
    public SearchResultType? resourceType { get; set; } = null;

    /// <summary>
    /// The search terms of a saved search.
    /// </summary>
    [JsonPropertyName("searchTerms")]
    public string? searchTerms { get; set; } = null;
}