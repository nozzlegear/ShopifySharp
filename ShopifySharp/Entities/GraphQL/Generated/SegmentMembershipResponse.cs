#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A list of maps that contain `segmentId` IDs and `isMember` Booleans. The maps represent segment memberships.
/// </summary>
public record SegmentMembershipResponse : IGraphQLObject
{
    /// <summary>
    /// The membership status for the given list of segments.
    /// </summary>
    [JsonPropertyName("memberships")]
    public ICollection<SegmentMembership>? memberships { get; set; } = null;
}