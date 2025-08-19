#nullable enable
namespace ShopifySharp.GraphQL;
using System;
using System.Text.Json.Serialization;
using System.Collections.Generic;

/// <summary>
/// A publication is a group of products and collections that is published to an app.
/// </summary>
public record Publication : IGraphQLObject, INode
{
    /// <summary>
    /// The app associated with the publication.
    /// </summary>
    [JsonPropertyName("app")]
    [Obsolete("Use [AppCatalog.apps](https://shopify.dev/api/admin-graphql/unstable/objects/AppCatalog#connection-appcatalog-apps) instead.")]
    public App? app { get; set; } = null;

    /// <summary>
    /// Whether new products are automatically published to this publication.
    /// </summary>
    [JsonPropertyName("autoPublish")]
    public bool? autoPublish { get; set; } = null;

    /// <summary>
    /// The catalog associated with the publication.
    /// </summary>
    [JsonPropertyName("catalog")]
    public ICatalog? catalog { get; set; } = null;

    /// <summary>
    /// The collection publications for the list of collections published to the publication.
    /// </summary>
    [JsonPropertyName("collectionPublicationsV3")]
    public ResourcePublicationConnection? collectionPublicationsV3 { get; set; } = null;

    /// <summary>
    /// The list of collections published to the publication.
    /// </summary>
    [JsonPropertyName("collections")]
    public CollectionConnection? collections { get; set; } = null;

    /// <summary>
    /// Whether the collection is available to the publication.
    /// </summary>
    [JsonPropertyName("hasCollection")]
    public bool? hasCollection { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The list of products included, but not necessarily published, in the publication.
    /// </summary>
    [JsonPropertyName("includedProducts")]
    public ProductConnection? includedProducts { get; set; } = null;

    /// <summary>
    /// Name of the publication.
    /// </summary>
    [JsonPropertyName("name")]
    [Obsolete("Use [Catalog.title](https://shopify.dev/api/admin-graphql/unstable/interfaces/Catalog#field-catalog-title) instead.")]
    public string? name { get; set; } = null;

    /// <summary>
    /// A background operation associated with this publication.
    /// </summary>
    [JsonPropertyName("operation")]
    public PublicationOperation? operation { get; set; } = null;

    /// <summary>
    /// The product publications for the list of products published to the publication.
    /// </summary>
    [JsonPropertyName("productPublicationsV3")]
    public ResourcePublicationConnection? productPublicationsV3 { get; set; } = null;

    /// <summary>
    /// The list of products published to the publication.
    /// </summary>
    [JsonPropertyName("products")]
    public ProductConnection? products { get; set; } = null;

    /// <summary>
    /// Whether the publication supports future publishing.
    /// </summary>
    [JsonPropertyName("supportsFuturePublishing")]
    public bool? supportsFuturePublishing { get; set; } = null;
}