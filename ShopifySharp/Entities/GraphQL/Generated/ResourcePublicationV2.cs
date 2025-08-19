#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A resource publication represents information about the publication of a resource.
/// Unlike `ResourcePublication`, an instance of `ResourcePublicationV2` can't be
/// unpublished. It must either be published or scheduled to be published.
/// See [ResourcePublication](/api/admin-graphql/latest/objects/ResourcePublication) for more context.
/// </summary>
public record ResourcePublicationV2 : IGraphQLObject
{
    /// <summary>
    /// Whether the resource publication is published. If true, then the resource publication is published to the publication.
    /// If false, then the resource publication is staged to be published to the publication.
    /// </summary>
    [JsonPropertyName("isPublished")]
    public bool? isPublished { get; set; } = null;

    /// <summary>
    /// The publication the resource publication is published to.
    /// </summary>
    [JsonPropertyName("publication")]
    public Publication? publication { get; set; } = null;

    /// <summary>
    /// The resource published to the publication.
    /// </summary>
    [JsonPropertyName("publishable")]
    public IPublishable? publishable { get; set; } = null;

    /// <summary>
    /// The date that the resource publication was or is going to be published to the publication.
    /// </summary>
    [JsonPropertyName("publishDate")]
#if NETSTANDARD2_0
	[System.Text.Json.DateOnlyConverter]
#endif
    public DateTime? publishDate { get; set; } = null;
}