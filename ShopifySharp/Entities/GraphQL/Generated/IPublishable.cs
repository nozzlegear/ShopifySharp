#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// Represents a resource that can be published to a channel.
/// A publishable resource can be either a Product or Collection.
/// </summary>
public interface IPublishable : IGraphQLObject
{
    /// <summary>
    /// The number of
    /// [publications](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
    /// that a resource is published to, without
    /// [feedback errors](https://shopify.dev/docs/api/admin-graphql/latest/objects/ResourceFeedback).
    /// </summary>
    [JsonPropertyName("availablePublicationsCount")]
    public Count? availablePublicationsCount { get; set; }

    /// <summary>
    /// The number of
    /// [publications](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
    /// that a resource is published to, without
    /// [feedback errors](https://shopify.dev/docs/api/admin-graphql/latest/objects/ResourceFeedback).
    /// </summary>
    [JsonPropertyName("publicationCount")]
    [Obsolete("Use `resourcePublicationsCount` instead.")]
    public int? publicationCount { get; set; }

    /// <summary>
    /// Whether the resource is published to a specific channel.
    /// </summary>
    [JsonPropertyName("publishedOnChannel")]
    [Obsolete("Use `publishedOnPublication` instead.")]
    public bool? publishedOnChannel { get; set; }

    /// <summary>
    /// Whether the resource is published to a
    /// [channel](https://shopify.dev/docs/api/admin-graphql/latest/objects/Channel).
    /// For example, the resource might be published to the online store channel.
    /// </summary>
    [JsonPropertyName("publishedOnCurrentChannel")]
    [Obsolete("Use `publishedOnCurrentPublication` instead.")]
    public bool? publishedOnCurrentChannel { get; set; }

    /// <summary>
    /// Whether the resource is published to the app's
    /// [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// For example, the resource might be published to the app's online store channel.
    /// </summary>
    [JsonPropertyName("publishedOnCurrentPublication")]
    public bool? publishedOnCurrentPublication { get; set; }

    /// <summary>
    /// Whether the resource is published to a specified
    /// [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// </summary>
    [JsonPropertyName("publishedOnPublication")]
    public bool? publishedOnPublication { get; set; }

    /// <summary>
    /// The list of resources that are published to a
    /// [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// </summary>
    [JsonPropertyName("resourcePublications")]
    public ResourcePublicationConnection? resourcePublications { get; set; }

    /// <summary>
    /// The number of
    /// [publications](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
    /// that a resource is published to, without
    /// [feedback errors](https://shopify.dev/docs/api/admin-graphql/latest/objects/ResourceFeedback).
    /// </summary>
    [JsonPropertyName("resourcePublicationsCount")]
    public Count? resourcePublicationsCount { get; set; }

    /// <summary>
    /// The list of resources that are either published or staged to be published to a
    /// [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// </summary>
    [JsonPropertyName("resourcePublicationsV2")]
    public ResourcePublicationV2Connection? resourcePublicationsV2 { get; set; }

    /// <summary>
    /// The list of channels that the resource is not published to.
    /// </summary>
    [JsonPropertyName("unpublishedChannels")]
    [Obsolete("Use `unpublishedPublications` instead.")]
    public ChannelConnection? unpublishedChannels { get; set; }

    /// <summary>
    /// The list of [publications](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
    /// that the resource isn't published to.
    /// </summary>
    [JsonPropertyName("unpublishedPublications")]
    public PublicationConnection? unpublishedPublications { get; set; }
}