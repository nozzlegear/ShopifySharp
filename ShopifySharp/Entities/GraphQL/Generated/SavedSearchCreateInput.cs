#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to create a saved search.
/// </summary>
public record SavedSearchCreateInput : GraphQLInputObject<SavedSearchCreateInput>
{
    /// <summary>
    /// A descriptive name of the saved search.
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
}