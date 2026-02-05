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
/// The `Collection` object represents a group of [products](https://shopify.dev/docs/api/admin-graphql/latest/objects/Product)
/// that merchants can organize to make their stores easier to browse and help customers find related products.
/// Collections serve as the primary way to categorize and display products across
/// [online stores](https://shopify.dev/docs/apps/build/online-store),
/// [sales channels](https://shopify.dev/docs/apps/build/sales-channels), and marketing campaigns.
/// There are two types of collections:
/// - **[Custom (manual) collections](https://help.shopify.com/manual/products/collections/manual-shopify-collection)**:
/// You specify the products to include in a collection.
/// - **[Smart (automated) collections](https://help.shopify.com/manual/products/collections/automated-collections)**:
/// You define rules, and products matching those rules are automatically included
/// in the collection.
/// The `Collection` object provides information to:
/// - Organize products by category, season, or promotion.
/// - Automate product grouping using rules (for example, by tag, type, or price).
/// - Configure product sorting and display order (for example, alphabetical, best-selling, price, or manual).
/// - Manage collection visibility and publication across sales channels.
/// - Add rich descriptions, images, and metadata to enhance discovery.
/// > Note:
/// > Collections are unpublished by default. To make them available to customers,
/// use the [`publishablePublish`](https://shopify.dev/docs/api/admin-graphql/latest/mutations/publishablePublish)
/// mutation after creation.
/// Collections can be displayed in a store with Shopify's theme system through [Liquid templates](https://shopify.dev/docs/storefronts/themes/architecture/templates/collection)
/// and can be customized with [template suffixes](https://shopify.dev/docs/storefronts/themes/architecture/templates/alternate-templates)
/// for unique layouts. They also support advanced features like translated content, resource feedback,
/// and contextual publication for location-based catalogs.
/// Learn about [using metafields with smart collections](https://shopify.dev/docs/apps/build/custom-data/metafields/use-metafield-capabilities).
/// </summary>
public record Collection : IGraphQLUnionCase, IGraphQLObject, IHasEvents, IHasMetafieldDefinitions, IHasMetafields, IHasPublishedTranslations, INode, IPublishable
{
    /// <summary>
    /// Collection duplicate operations involving this collection, either as a source
    /// (copying products from this collection to another) or a target (copying
    /// products to this collection from another).
    /// </summary>
    [JsonPropertyName("activeOperations")]
    public CollectionOperations? activeOperations { get; set; } = null;

    /// <summary>
    /// The number of
    /// [publications](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
    /// that a resource is published to, without
    /// [feedback errors](https://shopify.dev/docs/api/admin-graphql/latest/objects/ResourceFeedback).
    /// </summary>
    [JsonPropertyName("availablePublicationsCount")]
    public Count? availablePublicationsCount { get; set; } = null;

    /// <summary>
    /// A single-line, text-only description of the collection, stripped of any HTML
    /// tags and formatting that were included in the description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? description { get; set; } = null;

    /// <summary>
    /// The description of the collection, including any HTML tags and formatting.
    /// This content is typically displayed to customers, such as on an online store,
    /// depending on the theme.
    /// </summary>
    [JsonPropertyName("descriptionHtml")]
    public string? descriptionHtml { get; set; } = null;

    /// <summary>
    /// The paginated list of events associated with the host subject.
    /// </summary>
    [JsonPropertyName("events")]
    public EventConnection? events { get; set; } = null;

    /// <summary>
    /// Information about the collection that's provided through resource feedback.
    /// </summary>
    [JsonPropertyName("feedback")]
    public ResourceFeedback? feedback { get; set; } = null;

    /// <summary>
    /// A unique string that identifies the collection. If a handle isn't specified
    /// when a collection is created, it's automatically generated from the
    /// collection's original title, and typically includes words from the title
    /// separated by hyphens. For example, a collection that was created with the
    /// title `Summer Catalog 2022` might have the handle `summer-catalog-2022`.
    /// If the title is changed, the handle doesn't automatically change.
    /// The handle can be used in themes by the Liquid templating language to refer to
    /// the collection, but using the ID is preferred because it never changes.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// Whether the collection includes the specified product.
    /// </summary>
    [JsonPropertyName("hasProduct")]
    public bool? hasProduct { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The image associated with the collection.
    /// </summary>
    [JsonPropertyName("image")]
    public Image? image { get; set; } = null;

    /// <summary>
    /// The ID of the corresponding resource in the REST Admin API.
    /// </summary>
    [JsonPropertyName("legacyResourceId")]
    public ulong? legacyResourceId { get; set; } = null;

    /// <summary>
    /// A [custom field](https://shopify.dev/docs/apps/build/custom-data),
    /// including its `namespace` and `key`, that's associated with a Shopify resource
    /// for the purposes of adding and storing additional information.
    /// </summary>
    [JsonPropertyName("metafield")]
    public Metafield? metafield { get; set; } = null;

    /// <summary>
    /// List of metafield definitions.
    /// </summary>
    [JsonPropertyName("metafieldDefinitions")]
    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public MetafieldDefinitionConnection? metafieldDefinitions { get; set; } = null;

    /// <summary>
    /// A list of [custom fields](https://shopify.dev/docs/apps/build/custom-data)
    /// that a merchant associates with a Shopify resource.
    /// </summary>
    [JsonPropertyName("metafields")]
    public MetafieldConnection? metafields { get; set; } = null;

    /// <summary>
    /// The products that are included in the collection.
    /// </summary>
    [JsonPropertyName("products")]
    public ProductConnection? products { get; set; } = null;

    /// <summary>
    /// The number of products in the collection.
    /// </summary>
    [JsonPropertyName("productsCount")]
    public Count? productsCount { get; set; } = null;

    /// <summary>
    /// The number of
    /// [publications](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
    /// that a resource is published to, without
    /// [feedback errors](https://shopify.dev/docs/api/admin-graphql/latest/objects/ResourceFeedback).
    /// </summary>
    [JsonPropertyName("publicationCount")]
    [Obsolete("Use `resourcePublicationsCount` instead.")]
    public int? publicationCount { get; set; } = null;

    /// <summary>
    /// The channels where the collection is published.
    /// </summary>
    [JsonPropertyName("publications")]
    [Obsolete("Use `resourcePublications` instead.")]
    public CollectionPublicationConnection? publications { get; set; } = null;

    /// <summary>
    /// Whether the resource is published to a specific channel.
    /// </summary>
    [JsonPropertyName("publishedOnChannel")]
    [Obsolete("Use `publishedOnPublication` instead.")]
    public bool? publishedOnChannel { get; set; } = null;

    /// <summary>
    /// Whether the resource is published to a
    /// [channel](https://shopify.dev/docs/api/admin-graphql/latest/objects/Channel).
    /// For example, the resource might be published to the online store channel.
    /// </summary>
    [JsonPropertyName("publishedOnCurrentChannel")]
    [Obsolete("Use `publishedOnCurrentPublication` instead.")]
    public bool? publishedOnCurrentChannel { get; set; } = null;

    /// <summary>
    /// Whether the resource is published to the app's
    /// [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// For example, the resource might be published to the app's online store channel.
    /// </summary>
    [JsonPropertyName("publishedOnCurrentPublication")]
    public bool? publishedOnCurrentPublication { get; set; } = null;

    /// <summary>
    /// Whether the resource is published to a specified
    /// [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// </summary>
    [JsonPropertyName("publishedOnPublication")]
    public bool? publishedOnPublication { get; set; } = null;

    /// <summary>
    /// The list of resources that are published to a
    /// [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// </summary>
    [JsonPropertyName("resourcePublications")]
    public ResourcePublicationConnection? resourcePublications { get; set; } = null;

    /// <summary>
    /// The number of
    /// [publications](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
    /// that a resource is published to, without
    /// [feedback errors](https://shopify.dev/docs/api/admin-graphql/latest/objects/ResourceFeedback).
    /// </summary>
    [JsonPropertyName("resourcePublicationsCount")]
    public Count? resourcePublicationsCount { get; set; } = null;

    /// <summary>
    /// The list of resources that are either published or staged to be published to a
    /// [publication](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication).
    /// </summary>
    [JsonPropertyName("resourcePublicationsV2")]
    public ResourcePublicationV2Connection? resourcePublicationsV2 { get; set; } = null;

    /// <summary>
    /// For a smart (automated) collection, specifies the rules that determine whether a product is included.
    /// </summary>
    [JsonPropertyName("ruleSet")]
    public CollectionRuleSet? ruleSet { get; set; } = null;

    /// <summary>
    /// If the default SEO fields for page title and description have been modified, contains the modified information.
    /// </summary>
    [JsonPropertyName("seo")]
    public SEO? seo { get; set; } = null;

    /// <summary>
    /// The order in which the products in the collection are displayed by default in
    /// the Shopify admin and in sales channels, such as an online store.
    /// </summary>
    [JsonPropertyName("sortOrder")]
    public CollectionSortOrder? sortOrder { get; set; } = null;

    /// <summary>
    /// The Storefront GraphQL API ID of the `Collection`.
    /// As of the `2022-04` version release, the Storefront GraphQL API will no longer
    /// return Base64 encoded IDs to match the behavior of the Admin GraphQL API.
    /// Therefore, you can safely use the `id` field's value instead.
    /// </summary>
    [JsonPropertyName("storefrontId")]
    [Obsolete("Use `id` instead.")]
    public string? storefrontId { get; set; } = null;

    /// <summary>
    /// The suffix of the Liquid template being used to show the collection in an
    /// online store. For example, if the value is `custom`, then the collection is
    /// using the `collection.custom.liquid` template. If the value is `null`, then
    /// the collection is using the default `collection.liquid` template.
    /// </summary>
    [JsonPropertyName("templateSuffix")]
    public string? templateSuffix { get; set; } = null;

    /// <summary>
    /// The name of the collection. It's displayed in the Shopify admin and is
    /// typically displayed in sales channels, such as an online store.
    /// </summary>
    [JsonPropertyName("title")]
    public string? title { get; set; } = null;

    /// <summary>
    /// The published translations associated with the resource.
    /// </summary>
    [JsonPropertyName("translations")]
    public ICollection<Translation>? translations { get; set; } = null;

    /// <summary>
    /// The list of channels that the resource is not published to.
    /// </summary>
    [JsonPropertyName("unpublishedChannels")]
    [Obsolete("Use `unpublishedPublications` instead.")]
    public ChannelConnection? unpublishedChannels { get; set; } = null;

    /// <summary>
    /// The list of [publications](https://shopify.dev/docs/api/admin-graphql/latest/objects/Publication)
    /// that the resource isn't published to.
    /// </summary>
    [JsonPropertyName("unpublishedPublications")]
    public PublicationConnection? unpublishedPublications { get; set; } = null;

    /// <summary>
    /// The date and time ([ISO 8601 format](http://en.wikipedia.org/wiki/ISO_8601)) when the collection was last modified.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public DateTimeOffset? updatedAt { get; set; } = null;
}