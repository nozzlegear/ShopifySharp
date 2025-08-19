#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A job to determine a list of members, such as customers, that are associated with an individual segment.
/// </summary>
public record CustomerSegmentMembersQuery : IGraphQLObject, IJobResult, INode
{
    /// <summary>
    /// The current total number of members in a given segment.
    /// </summary>
    [JsonPropertyName("currentCount")]
    public int? currentCount { get; set; } = null;

    /// <summary>
    /// This indicates if the job is still queued or has been run.
    /// </summary>
    [JsonPropertyName("done")]
    public bool? done { get; set; } = null;

    /// <summary>
    /// A globally-unique ID that's returned when running an asynchronous mutation.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;
}