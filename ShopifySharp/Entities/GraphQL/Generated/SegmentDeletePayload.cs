#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `segmentDelete` mutation.
/// </summary>
public record SegmentDeletePayload : IGraphQLObject
{
    /// <summary>
    /// ID of the deleted segment.
    /// </summary>
    [JsonPropertyName("deletedSegmentId")]
    public string? deletedSegmentId { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}