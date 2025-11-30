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
/// A market is a group of one or more regions that you want to target for international sales.
/// By creating a market, you can configure a distinct, localized shopping experience for
/// customers from a specific area of the world. For example, you can
/// [change currency](https://shopify.dev/api/admin-graphql/current/mutations/marketCurrencySettingsUpdate),
/// [configure international pricing](https://shopify.dev/apps/internationalization/product-price-lists),
/// or [add market-specific domains or subfolders](https://shopify.dev/api/admin-graphql/current/objects/MarketWebPresence).
/// </summary>
public record Market : IGraphQLUnionCase, IGraphQLObject, IHasMetafieldDefinitions, IHasMetafields, INode
{
    /// <summary>
    /// Whether the market has a customization with the given ID.
    /// </summary>
    [JsonPropertyName("assignedCustomization")]
    public bool? assignedCustomization { get; set; } = null;

    /// <summary>
    /// The catalogs that belong to the market.
    /// </summary>
    [JsonPropertyName("catalogs")]
    public MarketCatalogConnection? catalogs { get; set; } = null;

    /// <summary>
    /// The number of catalogs that belong to the market.
    /// </summary>
    [JsonPropertyName("catalogsCount")]
    public Count? catalogsCount { get; set; } = null;

    /// <summary>
    /// The conditions under which a visitor is in the market.
    /// </summary>
    [JsonPropertyName("conditions")]
    public MarketConditions? conditions { get; set; } = null;

    /// <summary>
    /// The market’s currency settings.
    /// </summary>
    [JsonPropertyName("currencySettings")]
    public MarketCurrencySettings? currencySettings { get; set; } = null;

    /// <summary>
    /// Whether the market is enabled to receive visitors and sales. **Note**: Regions in inactive
    /// markets can't be selected on the storefront or in checkout.
    /// </summary>
    [JsonPropertyName("enabled")]
    [Obsolete("Use `status` instead.")]
    public bool? enabled { get; set; } = null;

    /// <summary>
    /// A short, human-readable unique identifier for the market. This is changeable by the merchant.
    /// </summary>
    [JsonPropertyName("handle")]
    public string? handle { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

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
    /// The name of the market. Not shown to customers.
    /// </summary>
    [JsonPropertyName("name")]
    public string? name { get; set; } = null;

    /// <summary>
    /// The inclusive pricing strategy for a market. This determines if prices include duties and / or taxes.
    /// </summary>
    [JsonPropertyName("priceInclusions")]
    public MarketPriceInclusions? priceInclusions { get; set; } = null;

    /// <summary>
    /// The market’s price list, which specifies a percentage-based price adjustment as well as
    /// fixed price overrides for specific variants.
    /// Markets with multiple catalogs can have multiple price lists. To query which price lists are connected to
    /// a market, please query for price lists through the catalogs connection.
    /// </summary>
    [JsonPropertyName("priceList")]
    [Obsolete("Use `catalogs` instead.")]
    public PriceList? priceList { get; set; } = null;

    /// <summary>
    /// Whether the market is the shop’s primary market.
    /// </summary>
    [JsonPropertyName("primary")]
    [Obsolete("This field is deprecated and will be removed in the future.")]
    public bool? primary { get; set; } = null;

    /// <summary>
    /// The regions that comprise the market.
    /// </summary>
    [JsonPropertyName("regions")]
    [Obsolete("This field is deprecated and will be removed in the future. Use `conditions.regionConditions` instead.")]
    public MarketRegionConnection? regions { get; set; } = null;

    /// <summary>
    /// Status of the market. Replaces the enabled field.
    /// </summary>
    [JsonPropertyName("status")]
    public MarketStatus? status { get; set; } = null;

    /// <summary>
    /// The type of the market.
    /// </summary>
    [JsonPropertyName("type")]
    public MarketType? type { get; set; } = null;

    /// <summary>
    /// The market’s web presence, which defines its SEO strategy. This can be a different domain,
    /// subdomain, or subfolders of the primary domain. Each web presence comprises one or more
    /// language variants. If a market doesn't have its own web presence, then the market is accessible on the
    /// primary market's domains using [country
    /// selectors](https://shopify.dev/themes/internationalization/multiple-currencies-languages#the-country-selector).
    /// If it's the primary market and it has multiple web presences, then this field will return the primary domain web presence.
    /// </summary>
    [JsonPropertyName("webPresence")]
    [Obsolete("Use `webPresences` instead.")]
    public MarketWebPresence? webPresence { get; set; } = null;

    /// <summary>
    /// The market’s web presences, which defines its SEO strategy. This can be a different domain,
    /// subdomain, or subfolders of the primary domain. Each web presence comprises one or more
    /// language variants. If a market doesn't have any web presences, then the market is accessible on the
    /// primary market's domains using [country
    /// selectors](https://shopify.dev/themes/internationalization/multiple-currencies-languages#the-country-selector).
    /// </summary>
    [JsonPropertyName("webPresences")]
    public MarketWebPresenceConnection? webPresences { get; set; } = null;
}