#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

/// <summary>
/// A resource publication represents information about the publication of a resource.
/// An instance of `ResourcePublication`, unlike `ResourcePublicationV2`, can be neither published or scheduled to be published.
/// See [ResourcePublicationV2](/api/admin-graphql/latest/objects/ResourcePublicationV2) for more context.
/// </summary>
public record ResourcePublication : IGraphQLObject
{
    /// <summary>
    /// The channel the resource publication is published to.
    /// </summary>
    [JsonPropertyName("channel")]
    [Obsolete("Use `publication` instead.")]
    public Channel? channel { get; set; } = null;

    /// <summary>
    /// Whether the resource publication is published. Also returns true if the resource publication is scheduled to be published.
    /// If false, then the resource publication is neither published nor scheduled to be published.
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
    /// If the product isn't published, then this field returns an epoch timestamp.
    /// </summary>
    [JsonPropertyName("publishDate")]
    public DateTimeOffset? publishDate { get; set; } = null;
}