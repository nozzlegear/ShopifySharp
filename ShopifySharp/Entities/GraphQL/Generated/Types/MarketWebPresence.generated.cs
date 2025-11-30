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
/// The market’s web presence, which defines its SEO strategy. This can be a different domain
/// (e.g. `example.ca`), subdomain (e.g. `ca.example.com`), or subfolders of the primary
/// domain (e.g. `example.com/en-ca`). Each web presence comprises one or more language
/// variants. If a market does not have its own web presence, it is accessible on the shop’s
/// primary domain via [country
/// selectors](https://shopify.dev/themes/internationalization/multiple-currencies-languages#the-country-selector).
/// Note: while the domain/subfolders defined by a market’s web presence are not applicable to
/// custom storefronts, which must manage their own domains and routing, the languages chosen
/// here do govern [the languages available on the Storefront
/// API](https://shopify.dev/custom-storefronts/internationalization/multiple-languages) for the countries in
/// this market.
/// </summary>
public record MarketWebPresence : IGraphQLObject, INode
{
    /// <summary>
    /// The ShopLocale object for the alternate locales. When a domain is used, these locales will be
    /// available as language-specific subfolders. For example, if English is an
    /// alternate locale, and `example.ca` is the market’s domain, then
    /// `example.ca/en` will load in English.
    /// </summary>
    [JsonPropertyName("alternateLocales")]
    public ICollection<ShopLocale>? alternateLocales { get; set; } = null;

    /// <summary>
    /// The ShopLocale object for the default locale. When a domain is used, this is the locale that will
    /// be used when the domain root is accessed. For example, if French is the default locale,
    /// and `example.ca` is the market’s domain, then `example.ca` will load in French.
    /// </summary>
    [JsonPropertyName("defaultLocale")]
    public ShopLocale? defaultLocale { get; set; } = null;

    /// <summary>
    /// The web presence’s domain.
    /// This field will be null if `subfolderSuffix` isn't null.
    /// </summary>
    [JsonPropertyName("domain")]
    public Domain? domain { get; set; } = null;

    /// <summary>
    /// A globally-unique ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string? id { get; set; } = null;

    /// <summary>
    /// The associated market. This can be null for a web presence that isn't associated with a market.
    /// </summary>
    [JsonPropertyName("market")]
    [Obsolete("Use `markets` instead.")]
    public Market? market { get; set; } = null;

    /// <summary>
    /// The associated markets for this web presence.
    /// </summary>
    [JsonPropertyName("markets")]
    public MarketConnection? markets { get; set; } = null;

    /// <summary>
    /// The list of root URLs for each of the web presence’s locales. As of version
    /// `2024-04` this value will no longer have a trailing slash.
    /// </summary>
    [JsonPropertyName("rootUrls")]
    public ICollection<MarketWebPresenceRootUrl>? rootUrls { get; set; } = null;

    /// <summary>
    /// The market-specific suffix of the subfolders defined by the web presence.
    /// Example: in `/en-us` the subfolder suffix is `us`. This field will be null if
    /// `domain` isn't null.
    /// </summary>
    [JsonPropertyName("subfolderSuffix")]
    public string? subfolderSuffix { get; set; } = null;
}