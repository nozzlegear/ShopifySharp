#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ShopFeaturesQueryBuilder : FieldsQueryBuilderBase<ShopFeatures, ShopFeaturesQueryBuilder>
    {
        protected override ShopFeaturesQueryBuilder Self => this;

        public ShopFeaturesQueryBuilder() : this("shopFeatures")
        {
        }

        public ShopFeaturesQueryBuilder(string name) : base(new Query<ShopFeatures>(name))
        {
        }

        public ShopFeaturesQueryBuilder(IQuery<ShopFeatures> query) : base(query)
        {
        }

        public ShopFeaturesQueryBuilder AvalaraAvatax()
        {
            base.InnerQuery.AddField("avalaraAvatax");
            return this;
        }

        public ShopFeaturesQueryBuilder Branding()
        {
            base.InnerQuery.AddField("branding");
            return this;
        }

        public ShopFeaturesQueryBuilder Bundles(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BundlesFeatureQueryBuilder> build)
        {
            var query = new Query<BundlesFeature>("bundles");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BundlesFeatureQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BundlesFeature>(query);
            return this;
        }

        public ShopFeaturesQueryBuilder Captcha()
        {
            base.InnerQuery.AddField("captcha");
            return this;
        }

        [Obsolete("No longer required for external domains")]
        public ShopFeaturesQueryBuilder CaptchaExternalDomains()
        {
            base.InnerQuery.AddField("captchaExternalDomains");
            return this;
        }

        public ShopFeaturesQueryBuilder CartTransform(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformFeatureQueryBuilder> build)
        {
            var query = new Query<CartTransformFeature>("cartTransform");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformFeatureQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransformFeature>(query);
            return this;
        }

        [Obsolete("Delivery profiles are now 100% enabled across Shopify.")]
        public ShopFeaturesQueryBuilder DeliveryProfiles()
        {
            base.InnerQuery.AddField("deliveryProfiles");
            return this;
        }

        public ShopFeaturesQueryBuilder DynamicRemarketing()
        {
            base.InnerQuery.AddField("dynamicRemarketing");
            return this;
        }

        public ShopFeaturesQueryBuilder EligibleForSubscriptionMigration()
        {
            base.InnerQuery.AddField("eligibleForSubscriptionMigration");
            return this;
        }

        public ShopFeaturesQueryBuilder EligibleForSubscriptions()
        {
            base.InnerQuery.AddField("eligibleForSubscriptions");
            return this;
        }

        public ShopFeaturesQueryBuilder GiftCards()
        {
            base.InnerQuery.AddField("giftCards");
            return this;
        }

        public ShopFeaturesQueryBuilder HarmonizedSystemCode()
        {
            base.InnerQuery.AddField("harmonizedSystemCode");
            return this;
        }

        [Obsolete("All shops have international domains through Shopify Markets.")]
        public ShopFeaturesQueryBuilder InternationalDomains()
        {
            base.InnerQuery.AddField("internationalDomains");
            return this;
        }

        [Obsolete("Use the `markets` field on `EntitlementsType`. Each market entitlement has a `catalogs` field that indicates whether the shops markets have access to catalogs and price overrides. ")]
        public ShopFeaturesQueryBuilder InternationalPriceOverrides()
        {
            base.InnerQuery.AddField("internationalPriceOverrides");
            return this;
        }

        [Obsolete("Use the `markets` field on `EntitlementsType`. Each market entitlement has a `catalogs` field that indicates whether the shops markets have access to catalogs and price overrides. ")]
        public ShopFeaturesQueryBuilder InternationalPriceRules()
        {
            base.InnerQuery.AddField("internationalPriceRules");
            return this;
        }

        public ShopFeaturesQueryBuilder LegacySubscriptionGatewayEnabled()
        {
            base.InnerQuery.AddField("legacySubscriptionGatewayEnabled");
            return this;
        }

        public ShopFeaturesQueryBuilder LiveView()
        {
            base.InnerQuery.AddField("liveView");
            return this;
        }

        [Obsolete("No longer supported.")]
        public ShopFeaturesQueryBuilder OnboardingVisual()
        {
            base.InnerQuery.AddField("onboardingVisual");
            return this;
        }

        public ShopFeaturesQueryBuilder PaypalExpressSubscriptionGatewayStatus()
        {
            base.InnerQuery.AddField("paypalExpressSubscriptionGatewayStatus");
            return this;
        }

        public ShopFeaturesQueryBuilder Reports()
        {
            base.InnerQuery.AddField("reports");
            return this;
        }

        public ShopFeaturesQueryBuilder SellsSubscriptions()
        {
            base.InnerQuery.AddField("sellsSubscriptions");
            return this;
        }

        [Obsolete("Use Shop.plan.shopifyPlus instead.")]
        public ShopFeaturesQueryBuilder ShopifyPlus()
        {
            base.InnerQuery.AddField("shopifyPlus");
            return this;
        }

        public ShopFeaturesQueryBuilder ShowMetrics()
        {
            base.InnerQuery.AddField("showMetrics");
            return this;
        }

        public ShopFeaturesQueryBuilder Storefront()
        {
            base.InnerQuery.AddField("storefront");
            return this;
        }

        public ShopFeaturesQueryBuilder UnifiedMarkets()
        {
            base.InnerQuery.AddField("unifiedMarkets");
            return this;
        }

        public ShopFeaturesQueryBuilder UsingShopifyBalance()
        {
            base.InnerQuery.AddField("usingShopifyBalance");
            return this;
        }
    }
}