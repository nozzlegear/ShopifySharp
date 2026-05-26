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
/// A connection between a Shopify shop and an external selling platform that
/// supports product syndication and optionally order ingestion. Each channel binds
/// a merchant's account on a specific platform — such as Amazon, eBay, Google, or a
/// point-of-sale system — to the shop, establishing the publishing destination for product feeds.
/// Sales Channel applications use [`channelCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/channelCreate)
/// to establish channels after merchant authentication, and can manage multiple
/// channel connections per app. Each channel is bound to a channel specification
/// that declares the platform's regional coverage, capabilities, and requirements.
/// Use channels to manage where catalog items are syndicated, track publication
/// status across platforms, and control
/// [`Product`](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
/// visibility for different selling destinations.
/// </summary>
public record Channel : IGraphQLObject, INode
{
    /// <summary>
    /// The unique account ID for the merchant on the external platform. This value is
    /// opaque to Shopify — its format is determined by the channel, such as an Amazon
    /// Seller ID or Google Merchant Center ID.
    /// </summary>
    [JsonPropertyName("accountId")]
    public string? accountId { get; set; } = null;

    /// <summary>
    /// The merchant-facing name for the external account. Displayed in Shopify Admin
    /// wherever the channel connection is referenced, such as in Markets and order attribution.
    /// </summary>
    [JsonPropertyName("accountName")]
    public string? accountName { get; set; } = null;

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
    /// A unique, human-readable identifier for the channel within the shop. Set during [`channelCreate`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/channelCreate)
    /// or auto-generated from the specification handle and account ID. Use with [`channelByHandle`](https://shopify.dev/docs/api/admin-graphql/latest/queries/channelByHandle) for lookups.
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
    /// The resource feedback for the channel. Returns `null` when no active feedback
    /// exists—for example, after `shopResourceFeedbackCreate` is called with `state:
    /// ACCEPTED`, which clears the feedback signal. A `null` result is expected and
    /// means the channel has no outstanding feedback.
    /// </summary>
    [JsonPropertyName("resourceFeedback")]
    public AppFeedback? resourceFeedback { get; set; } = null;

    /// <summary>
    /// The handle of the [channel specification](https://shopify.dev/docs/apps/build/sales-channels/channel-config-extension)
    /// bound to this channel. The specification declares the channel's regional
    /// coverage, capabilities, and requirements, and is deployed by the Sales Channel
    /// application via `shopify app deploy`.
    /// </summary>
    [JsonPropertyName("specificationHandle")]
    public string? specificationHandle { get; set; } = null;

    /// <summary>
    /// Whether the channel supports future publishing.
    /// </summary>
    [JsonPropertyName("supportsFuturePublishing")]
    public bool? supportsFuturePublishing { get; set; } = null;
}