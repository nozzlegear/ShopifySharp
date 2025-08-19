#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Return type for `segmentCreate` mutation.
/// </summary>
public record SegmentCreatePayload : IGraphQLObject
{
    /// <summary>
    /// The newly created segment.
    /// </summary>
    [JsonPropertyName("segment")]
    public Segment? segment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}