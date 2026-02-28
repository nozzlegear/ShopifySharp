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
/// A group of [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product) and [collections](https://shopify.dev/docs/api/admin-graphql/latest/objects/Collection)
/// that are published to an app.
/// Each publication manages which products and collections display on its associated
/// [`Channel`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Channel).
/// Merchants can automatically publish products when they're created if [`autoPublish`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication#field-Publication.fields.autoPublish)
/// is enabled, or manually control publication through publication records.
/// Publications support scheduled publishing through future publish dates for
/// online store channels, allowing merchants to coordinate product launches and
/// promotional campaigns. The [`catalog`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication#field-Publication.fields.catalog)
/// field links to pricing and availability rules specific to that publication's context.
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
    /// The list of collection publication records, each representing the publication
    /// status and details for a collection published to this publication (typically channel).
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
    /// The count of products included in the publication. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("includedProductsCount")]
    public Count? includedProductsCount { get; set; } = null;

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