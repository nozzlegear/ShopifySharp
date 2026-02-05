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
/// A segment and its corresponding saved search. 
/// For example, you can use `SegmentMigration` to retrieve the segment ID that corresponds to a saved search ID.
/// </summary>
public record SegmentMigration : IGraphQLObject
{
    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The ID of the saved search.
    /// </summary>
    [JsonPropertyName("savedSearchId")]
    public string? savedSearchId { get; set; } = null;

    /// <summary>
    /// The ID of the segment.
    /// </summary>
    [JsonPropertyName("segmentId")]
    public string? segmentId { get; set; } = null;
}