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
/// Represents the feature set available to the shop.
/// Most fields specify whether a feature is enabled for a shop, and some fields return information
/// related to specific features.
/// </summary>
public record ShopFeatures : IGraphQLObject
{
    /// <summary>
    /// Whether a shop has access to Avalara AvaTax.
    /// </summary>
    [JsonPropertyName("avalaraAvatax")]
    public bool? avalaraAvatax { get; set; } = null;

    /// <summary>
    /// The branding of the shop, which influences its look and feel in the Shopify admin.
    /// </summary>
    [JsonPropertyName("branding")]
    public ShopBranding? branding { get; set; } = null;

    /// <summary>
    /// Represents the Bundles feature configuration for the shop.
    /// </summary>
    [JsonPropertyName("bundles")]
    public BundlesFeature? bundles { get; set; } = null;

    /// <summary>
    /// Whether a shop's online store can have CAPTCHA protection.
    /// </summary>
    [JsonPropertyName("captcha")]
    public bool? captcha { get; set; } = null;

    /// <summary>
    /// Whether a shop's online store can have CAPTCHA protection for domains not managed by Shopify.
    /// </summary>
    [JsonPropertyName("captchaExternalDomains")]
    [Obsolete("No longer required for external domains")]
    public bool? captchaExternalDomains { get; set; } = null;

    /// <summary>
    /// Represents the cart transform feature configuration for the shop.
    /// </summary>
    [JsonPropertyName("cartTransform")]
    public CartTransformFeature? cartTransform { get; set; } = null;

    /// <summary>
    /// Whether the delivery profiles functionality is enabled for this shop.
    /// </summary>
    [JsonPropertyName("deliveryProfiles")]
    [Obsolete("Delivery profiles are now 100% enabled across Shopify.")]
    public bool? deliveryProfiles { get; set; } = null;

    /// <summary>
    /// Whether a shop has access to the Google Analytics dynamic remarketing feature.
    /// </summary>
    [JsonPropertyName("dynamicRemarketing")]
    public bool? dynamicRemarketing { get; set; } = null;

    /// <summary>
    /// Whether a shop can be migrated to use Shopify subscriptions.
    /// </summary>
    [JsonPropertyName("eligibleForSubscriptionMigration")]
    public bool? eligibleForSubscriptionMigration { get; set; } = null;

    /// <summary>
    /// Whether a shop is configured properly to sell subscriptions.
    /// </summary>
    [JsonPropertyName("eligibleForSubscriptions")]
    public bool? eligibleForSubscriptions { get; set; } = null;

    /// <summary>
    /// Whether a shop can create gift cards.
    /// </summary>
    [JsonPropertyName("giftCards")]
    public bool? giftCards { get; set; } = null;

    /// <summary>
    /// Whether a shop displays Harmonized System codes on products. This is used for customs when shipping
    /// internationally.
    /// </summary>
    [JsonPropertyName("harmonizedSystemCode")]
    public bool? harmonizedSystemCode { get; set; } = null;

    /// <summary>
    /// Whether a shop can enable international domains.
    /// </summary>
    [JsonPropertyName("internationalDomains")]
    [Obsolete("All shops have international domains through Shopify Markets.")]
    public bool? internationalDomains { get; set; } = null;

    /// <summary>
    /// Whether a shop can enable international price overrides.
    /// </summary>
    [JsonPropertyName("internationalPriceOverrides")]
    [Obsolete("Use the `markets` field on `EntitlementsType`. Each market entitlement has a `catalogs` field that indicates whether the shops markets have access to catalogs and price overrides. ")]
    public bool? internationalPriceOverrides { get; set; } = null;

    /// <summary>
    /// Whether a shop can enable international price rules.
    /// </summary>
    [JsonPropertyName("internationalPriceRules")]
    [Obsolete("Use the `markets` field on `EntitlementsType`. Each market entitlement has a `catalogs` field that indicates whether the shops markets have access to catalogs and price overrides. ")]
    public bool? internationalPriceRules { get; set; } = null;

    /// <summary>
    /// Whether a shop has enabled a legacy subscription gateway to handle older subscriptions.
    /// </summary>
    [JsonPropertyName("legacySubscriptionGatewayEnabled")]
    public bool? legacySubscriptionGatewayEnabled { get; set; } = null;

    /// <summary>
    /// Whether to show the Live View metrics in the Shopify admin. Live view is hidden from merchants that are on a trial
    /// or don't have a storefront.
    /// </summary>
    [JsonPropertyName("liveView")]
    public bool? liveView { get; set; } = null;

    /// <summary>
    /// Whether a shop has access to the onboarding visual.
    /// </summary>
    [JsonPropertyName("onboardingVisual")]
    [Obsolete("No longer supported.")]
    public bool? onboardingVisual { get; set; } = null;

    /// <summary>
    /// Whether a shop is configured to sell subscriptions with PayPal Express.
    /// </summary>
    [JsonPropertyName("paypalExpressSubscriptionGatewayStatus")]
    public PaypalExpressSubscriptionsGatewayStatus? paypalExpressSubscriptionGatewayStatus { get; set; } = null;

    /// <summary>
    /// Whether a shop has access to all reporting features.
    /// </summary>
    [JsonPropertyName("reports")]
    public bool? reports { get; set; } = null;

    /// <summary>
    /// Whether a shop has ever had subscription products.
    /// </summary>
    [JsonPropertyName("sellsSubscriptions")]
    public bool? sellsSubscriptions { get; set; } = null;

    /// <summary>
    /// Whether the shop has a Shopify Plus subscription.
    /// </summary>
    [JsonPropertyName("shopifyPlus")]
    [Obsolete("Use Shop.plan.shopifyPlus instead.")]
    public bool? shopifyPlus { get; set; } = null;

    /// <summary>
    /// Whether to show metrics in the Shopify admin. Metrics are hidden for new merchants until they become meaningful.
    /// </summary>
    [JsonPropertyName("showMetrics")]
    public bool? showMetrics { get; set; } = null;

    /// <summary>
    /// Whether a shop has an online store.
    /// </summary>
    [JsonPropertyName("storefront")]
    public bool? storefront { get; set; } = null;

    /// <summary>
    /// Whether a shop is eligible for Unified Markets.
    /// </summary>
    [JsonPropertyName("unifiedMarkets")]
    public bool? unifiedMarkets { get; set; } = null;

    /// <summary>
    /// Whether a shop is using Shopify Balance.
    /// </summary>
    [JsonPropertyName("usingShopifyBalance")]
    public bool? usingShopifyBalance { get; set; } = null;
}