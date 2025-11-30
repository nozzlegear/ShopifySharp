#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ShopFeaturesQueryBuilder() : GraphQueryBuilder<ShopFeatures>("query shopFeatures")
{
    public ShopFeaturesQueryBuilder AddFieldAvalaraAvatax()
    {
        AddField("avalaraAvatax");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldBranding()
    {
        AddField("branding");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldBundles()
    {
        AddField("bundles");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldCaptcha()
    {
        AddField("captcha");
        return this;
    }

    [Obsolete("No longer required for external domains")]
    public ShopFeaturesQueryBuilder AddFieldCaptchaExternalDomains()
    {
        AddField("captchaExternalDomains");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldCartTransform()
    {
        AddField("cartTransform");
        return this;
    }

    [Obsolete("Delivery profiles are now 100% enabled across Shopify.")]
    public ShopFeaturesQueryBuilder AddFieldDeliveryProfiles()
    {
        AddField("deliveryProfiles");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldDynamicRemarketing()
    {
        AddField("dynamicRemarketing");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldEligibleForSubscriptionMigration()
    {
        AddField("eligibleForSubscriptionMigration");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldEligibleForSubscriptions()
    {
        AddField("eligibleForSubscriptions");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldGiftCards()
    {
        AddField("giftCards");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldHarmonizedSystemCode()
    {
        AddField("harmonizedSystemCode");
        return this;
    }

    [Obsolete("All shops have international domains through Shopify Markets.")]
    public ShopFeaturesQueryBuilder AddFieldInternationalDomains()
    {
        AddField("internationalDomains");
        return this;
    }

    [Obsolete("Use the `markets` field on `EntitlementsType`. Each market entitlement has a `catalogs` field that indicates whether the shops markets have access to catalogs and price overrides. ")]
    public ShopFeaturesQueryBuilder AddFieldInternationalPriceOverrides()
    {
        AddField("internationalPriceOverrides");
        return this;
    }

    [Obsolete("Use the `markets` field on `EntitlementsType`. Each market entitlement has a `catalogs` field that indicates whether the shops markets have access to catalogs and price overrides. ")]
    public ShopFeaturesQueryBuilder AddFieldInternationalPriceRules()
    {
        AddField("internationalPriceRules");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldLegacySubscriptionGatewayEnabled()
    {
        AddField("legacySubscriptionGatewayEnabled");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldLiveView()
    {
        AddField("liveView");
        return this;
    }

    [Obsolete("No longer supported.")]
    public ShopFeaturesQueryBuilder AddFieldOnboardingVisual()
    {
        AddField("onboardingVisual");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldPaypalExpressSubscriptionGatewayStatus()
    {
        AddField("paypalExpressSubscriptionGatewayStatus");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldReports()
    {
        AddField("reports");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldSellsSubscriptions()
    {
        AddField("sellsSubscriptions");
        return this;
    }

    [Obsolete("Use Shop.plan.shopifyPlus instead.")]
    public ShopFeaturesQueryBuilder AddFieldShopifyPlus()
    {
        AddField("shopifyPlus");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldShowMetrics()
    {
        AddField("showMetrics");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldStorefront()
    {
        AddField("storefront");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldUnifiedMarkets()
    {
        AddField("unifiedMarkets");
        return this;
    }

    public ShopFeaturesQueryBuilder AddFieldUsingShopifyBalance()
    {
        AddField("usingShopifyBalance");
        return this;
    }
}