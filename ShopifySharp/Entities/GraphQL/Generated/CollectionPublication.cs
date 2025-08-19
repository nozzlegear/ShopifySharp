#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents the publications where a collection is published.
/// </summary>
public record CollectionPublication : IGraphQLObject
{
    /// <summary>
    /// The channel where the collection will be published.
    /// </summary>
    [JsonPropertyName("channel")]
    [Obsolete("Use `publication` instead.")]
    public Channel? channel { get; set; } = null;

    /// <summary>
    /// The collection to be published on the publication.
    /// </summary>
    [JsonPropertyName("collection")]
    public Collection? collection { get; set; } = null;

    /// <summary>
    /// Whether the publication is published or not.
    /// </summary>
    [JsonPropertyName("isPublished")]
    public bool? isPublished { get; set; } = null;

    /// <summary>
    /// The publication where the collection will be published.
    /// </summary>
    [JsonPropertyName("publication")]
    public Publication? publication { get; set; } = null;

    /// <summary>
    /// The date that the publication was or is going to be published.
    /// </summary>
    [JsonPropertyName("publishDate")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? publishDate { get; set; } = null;
}