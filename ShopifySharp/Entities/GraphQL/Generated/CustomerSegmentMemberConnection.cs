#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The connection type for the `CustomerSegmentMembers` object.
/// </summary>
public record CustomerSegmentMemberConnection : ConnectionWithEdges<CustomerSegmentMemberEdge?>
{
    /// <summary>
    /// The statistics for a given segment.
    /// </summary>
    [JsonPropertyName("statistics")]
    public SegmentStatistics? statistics { get; set; } = null;
}