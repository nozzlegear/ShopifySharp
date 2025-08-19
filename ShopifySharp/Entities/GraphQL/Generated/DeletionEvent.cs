#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Deletion events chronicle the destruction of resources (e.g. products and collections).
/// Once deleted, the deletion event is the only trace of the original's existence,
/// as the resource itself has been removed and can no longer be accessed.
/// </summary>
public record DeletionEvent : IGraphQLObject
{
    /// <summary>
    /// The date and time when the deletion event for the related resource was generated.
    /// </summary>
    [JsonPropertyName("occurredAt")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? occurredAt { get; set; } = null;

    /// <summary>
    /// The ID of the resource that was deleted.
    /// </summary>
    [JsonPropertyName("subjectId")]
    public string? subjectId { get; set; } = null;

    /// <summary>
    /// The type of resource that was deleted.
    /// </summary>
    [JsonPropertyName("subjectType")]
    public DeletionEventSubjectType? subjectType { get; set; } = null;
}