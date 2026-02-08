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
/// An authenticated link to an external platform that supports syndication and
/// optionally order ingestion, such as Facebook, Pinterest, an online store, or
/// Point of Sale (POS).
/// Each channel provides access to its underlying
/// [`App`](https://shopify.dev/docs/api/admin-graphql/latest/objects/App),
/// published products and collections, and [`Publication`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
/// settings, as well as what features of the platform it supports such as [scheduled publishing](https://shopify.dev/docs/apps/build/sales-channels/scheduled-product-publishing).
/// Use channels to manage where catalog items appear, track publication status
/// across platforms, and control
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
/// visibility for different customer touchpoints.
/// </summary>
public record Channel : IGraphQLObject, INode
{
    /// <summary>
    /// The underlying app used by the channel.
    /// </summary>
    [JsonPropertyName("app")]
    public App? app { get; set; } = null;

    /// <summary>
    /// The list of collection publications. Each record represents information about the publication of a collection.
    /// </summary>
    [JsonPropertyName("collectionPublicationsV3")]
    public ResourcePublicationConnection? collectionPublicationsV3 { get; set; } = null;

    /// <summary>
    /// The list of collections published to the channel.
    /// </summary>
    [JsonPropertyName("collections")]
    public CollectionConnection? collections { get; set; } = null;

    /// <summary>
    /// The unique identifier for the channel.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Whether the collection is available to the channel.
    /// </summary>
    [JsonPropertyName("hasCollection")]
    public bool? hasCollection { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The name of the channel.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The menu items for the channel, which also appear as submenu items in the left navigation sidebar in the Shopify admin.
    /// </summary>
    [JsonPropertyName("navigationItems")]
    [Obsolete("Use [AppInstallation.navigationItems](           https://shopify.dev/api/admin-graphql/current/objects/AppInstallation#field-appinstallation-navigationitems) instead.")]
    public ICollection<NavigationItem>? navigationItems { get; set; } = null;

    /// <summary>
    /// Home page for the channel.
    /// </summary>
    [JsonPropertyName("overviewPath")]
    [Obsolete("Use [AppInstallation.launchUrl](           https://shopify.dev/api/admin-graphql/current/objects/AppInstallation#field-appinstallation-launchurl) instead.")]
    public string? overviewPath { get; set; } = null;

    /// <summary>
    /// The product publications for the products published to the channel.
    /// </summary>
    [JsonPropertyName("productPublications")]
    [Obsolete("Use `productPublicationsV3` instead.")]
    public ProductPublicationConnection? productPublications { get; set; } = null;

    /// <summary>
    /// The list of product publication records for products published to this channel.
    /// </summary>
    [JsonPropertyName("productPublicationsV3")]
    public ResourcePublicationConnection? productPublicationsV3 { get; set; } = null;

    /// <summary>
    /// The list of products published to the channel.
    /// </summary>
    [JsonPropertyName("products")]
    public ProductConnection? products { get; set; } = null;

    /// <summary>
    /// Retrieves the total count of [`products`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
    /// published to a specific sales channel. Limited to a maximum of 10000 by default.
    /// </summary>
    [JsonPropertyName("productsCount")]
    public Count? productsCount { get; set; } = null;

    /// <summary>
    /// Whether the channel supports future publishing.
    /// </summary>
    [JsonPropertyName("supportsFuturePublishing")]
    public bool? supportsFuturePublishing { get; set; } = null;
}