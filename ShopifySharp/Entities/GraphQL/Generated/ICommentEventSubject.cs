#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// The subject line of a comment event.
/// </summary>
public interface ICommentEventSubject : IGraphQLObject
{
    /// <summary>
    /// Whether the timeline subject has a timeline comment. If true, then a timeline comment exists.
    /// </summary>
    [JsonPropertyName("hasTimelineComment")]
    public bool? hasTimelineComment { get; set; }

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; }
}