#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A dynamic collection of customers based on specific criteria.
/// </summary>
public record Segment : IGraphQLObject, INode
{
    /// <summary>
    /// The date and time when the segment was added to the store.
    /// </summary>
    [JsonPropertyName("creationDate")]
    public DateTime? creationDate { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The date and time when the segment was last updated.
    /// </summary>
    [JsonPropertyName("lastEditDate")]
    public DateTime? lastEditDate { get; set; } = null;

    /// <summary>
    /// The name of the segment.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A precise definition of the segment. The definition is composed of a combination of conditions on facts about customers.
    /// </summary>
    [JsonPropertyName("query")]
    public string? query { get; set; } = null;
}