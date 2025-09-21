#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// The response type for the `segmentMembership` object.
/// </summary>
public record SegmentMembership : IGraphQLObject
{
    /// <summary>
    /// A Boolean that indicates whether or not the customer in the query is a member
    /// of the segment, which is identified using the `segmentId`.
    /// </summary>
    [JsonPropertyName("isMember")]
    public bool? isMember { get; set; } = null;

    /// <summary>
    /// A `segmentId` that's used for testing membership.
    /// </summary>
    [JsonPropertyName("segmentId")]
    public string? segmentId { get; set; } = null;
}