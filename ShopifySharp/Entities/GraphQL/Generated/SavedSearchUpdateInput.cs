#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The input fields to update a saved search.
/// </summary>
public record SavedSearchUpdateInput : GraphQLInputObject<SavedSearchUpdateInput>
{
    /// <summary>
    /// ID of the saved search to update.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// A descriptive name of the saved search.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The query string of a saved search. This included search terms and filters.
    /// </summary>
    [JsonPropertyName("query")]
    public string? query { get; set; } = null;
}