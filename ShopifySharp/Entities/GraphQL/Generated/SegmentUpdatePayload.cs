#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// Return type for `segmentUpdate` mutation.
/// </summary>
public record SegmentUpdatePayload : IGraphQLObject
{
    /// <summary>
    /// The updated segment.
    /// </summary>
    [JsonPropertyName("segment")]
    public Segment? segment { get; set; } = null;

    /// <summary>
    /// The list of errors that occurred from executing the mutation.
    /// </summary>
    [JsonPropertyName("userErrors")]
    public ICollection<UserError>? userErrors { get; set; } = null;
}