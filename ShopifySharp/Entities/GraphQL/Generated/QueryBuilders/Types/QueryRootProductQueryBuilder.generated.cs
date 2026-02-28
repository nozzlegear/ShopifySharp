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
    public sealed class QueryRootProductQueryBuilder : FieldsQueryBuilderBase<Product, QueryRootProductQueryBuilder>, IHasArguments<QueryRootProductArgumentsBuilder>
    {
        public QueryRootProductArgumentsBuilder Arguments { get; }
        protected override QueryRootProductQueryBuilder Self => this;

        public QueryRootProductQueryBuilder(string name) : base(new Query<Product>(name))
        {
            Arguments = new QueryRootProductArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductQueryBuilder(IQuery<Product> query) : base(query)
        {
            Arguments = new QueryRootProductArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductQueryBuilder SetArguments(Action<QueryRootProductArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootProductQueryBuilder AvailablePublicationsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("availablePublicationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        [Obsolete("Use `descriptionHtml` instead.")]
        public QueryRootProductQueryBuilder BodyHtml()
        {
            base.InnerQuery.AddField("bodyHtml");
            return this;
        }

        public QueryRootProductQueryBuilder BundleComponents(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentConnectionQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponentConnection>("bundleComponents");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponentConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder BundleConsolidatedOptions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ComponentizedProductsBundleConsolidatedOptionQueryBuilder> build)
        {
            var query = new Query<ComponentizedProductsBundleConsolidatedOption>("bundleConsolidatedOptions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ComponentizedProductsBundleConsolidatedOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ComponentizedProductsBundleConsolidatedOption>(query);
            return this;
        }

        public QueryRootProductQueryBuilder Category(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategory>("category");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategory>(query);
            return this;
        }

        public QueryRootProductQueryBuilder Collections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder CombinedListing(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingQueryBuilder> build)
        {
            var query = new Query<CombinedListing>("combinedListing");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CombinedListing>(query);
            return this;
        }

        public QueryRootProductQueryBuilder CombinedListingRole()
        {
            base.InnerQuery.AddField("combinedListingRole");
            return this;
        }

        public QueryRootProductQueryBuilder CompareAtPriceRange(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductCompareAtPriceRangeQueryBuilder> build)
        {
            var query = new Query<ProductCompareAtPriceRange>("compareAtPriceRange");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductCompareAtPriceRangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductCompareAtPriceRange>(query);
            return this;
        }

        public QueryRootProductQueryBuilder ContextualPricing(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductContextualPricingQueryBuilder> build)
        {
            var query = new Query<ProductContextualPricing>("contextualPricing");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductContextualPricingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductContextualPricing>(query);
            return this;
        }

        public QueryRootProductQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        [Obsolete("Use `productType` instead.")]
        public QueryRootProductQueryBuilder CustomProductType()
        {
            base.InnerQuery.AddField("customProductType");
            return this;
        }

        public QueryRootProductQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public QueryRootProductQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public QueryRootProductQueryBuilder DescriptionHtml()
        {
            base.InnerQuery.AddField("descriptionHtml");
            return this;
        }

        [Obsolete("Use `description` instead.")]
        public QueryRootProductQueryBuilder DescriptionPlainSummary()
        {
            base.InnerQuery.AddField("descriptionPlainSummary");
            return this;
        }

        public QueryRootProductQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder FeaturedImage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("featuredImage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public QueryRootProductQueryBuilder FeaturedMedia(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaQueryBuilder> build)
        {
            var query = new Query<IMedia>("featuredMedia");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMedia>(query);
            return this;
        }

        public QueryRootProductQueryBuilder Feedback(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourceFeedbackQueryBuilder> build)
        {
            var query = new Query<ResourceFeedback>("feedback");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourceFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourceFeedback>(query);
            return this;
        }

        public QueryRootProductQueryBuilder GiftCardTemplateSuffix()
        {
            base.InnerQuery.AddField("giftCardTemplateSuffix");
            return this;
        }

        public QueryRootProductQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public QueryRootProductQueryBuilder HasOnlyDefaultVariant()
        {
            base.InnerQuery.AddField("hasOnlyDefaultVariant");
            return this;
        }

        public QueryRootProductQueryBuilder HasOutOfStockVariants()
        {
            base.InnerQuery.AddField("hasOutOfStockVariants");
            return this;
        }

        public QueryRootProductQueryBuilder HasVariantsThatRequiresComponents()
        {
            base.InnerQuery.AddField("hasVariantsThatRequiresComponents");
            return this;
        }

        public QueryRootProductQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootProductQueryBuilder Images(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageConnectionQueryBuilder> build)
        {
            var query = new Query<ImageConnection>("images");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ImageConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder InCollection()
        {
            base.InnerQuery.AddField("inCollection");
            return this;
        }

        public QueryRootProductQueryBuilder IsGiftCard()
        {
            base.InnerQuery.AddField("isGiftCard");
            return this;
        }

        public QueryRootProductQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public QueryRootProductQueryBuilder Media(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaConnectionQueryBuilder> build)
        {
            var query = new Query<MediaConnection>("media");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder MediaCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("mediaCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootProductQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public QueryRootProductQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder OnlineStorePreviewUrl()
        {
            base.InnerQuery.AddField("onlineStorePreviewUrl");
            return this;
        }

        public QueryRootProductQueryBuilder OnlineStoreUrl()
        {
            base.InnerQuery.AddField("onlineStoreUrl");
            return this;
        }

        public QueryRootProductQueryBuilder Options(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionQueryBuilder> build)
        {
            var query = new Query<ProductOption>("options");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOption>(query);
            return this;
        }

        public QueryRootProductQueryBuilder PriceRange(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPriceRangeQueryBuilder> build)
        {
            var query = new Query<ProductPriceRange>("priceRange");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPriceRangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPriceRange>(query);
            return this;
        }

        public QueryRootProductQueryBuilder PriceRangeV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPriceRangeV2QueryBuilder> build)
        {
            var query = new Query<ProductPriceRangeV2>("priceRangeV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPriceRangeV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPriceRangeV2>(query);
            return this;
        }

        public QueryRootProductQueryBuilder ProductCategory(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductCategoryQueryBuilder> build)
        {
            var query = new Query<ProductCategory>("productCategory");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductCategory>(query);
            return this;
        }

        public QueryRootProductQueryBuilder ProductComponents(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductComponentTypeConnectionQueryBuilder> build)
        {
            var query = new Query<ProductComponentTypeConnection>("productComponents");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductComponentTypeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductComponentTypeConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder ProductComponentsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productComponentsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootProductQueryBuilder ProductParents(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("productParents");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder ProductPublications(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ProductPublicationConnection>("productPublications");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublicationConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder ProductType()
        {
            base.InnerQuery.AddField("productType");
            return this;
        }

        [Obsolete("Use `resourcePublicationsCount` instead.")]
        public QueryRootProductQueryBuilder PublicationCount()
        {
            base.InnerQuery.AddField("publicationCount");
            return this;
        }

        public QueryRootProductQueryBuilder Publications(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ProductPublicationConnection>("publications");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublicationConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder PublishedAt()
        {
            base.InnerQuery.AddField("publishedAt");
            return this;
        }

        public QueryRootProductQueryBuilder PublishedInContext()
        {
            base.InnerQuery.AddField("publishedInContext");
            return this;
        }

        [Obsolete("Use `publishedOnPublication` instead.")]
        public QueryRootProductQueryBuilder PublishedOnChannel()
        {
            base.InnerQuery.AddField("publishedOnChannel");
            return this;
        }

        [Obsolete("Use `publishedOnCurrentPublication` instead.")]
        public QueryRootProductQueryBuilder PublishedOnCurrentChannel()
        {
            base.InnerQuery.AddField("publishedOnCurrentChannel");
            return this;
        }

        [Obsolete("Use `publishedOnPublication` instead.")]
        public QueryRootProductQueryBuilder PublishedOnCurrentPublication()
        {
            base.InnerQuery.AddField("publishedOnCurrentPublication");
            return this;
        }

        public QueryRootProductQueryBuilder PublishedOnPublication()
        {
            base.InnerQuery.AddField("publishedOnPublication");
            return this;
        }

        public QueryRootProductQueryBuilder RequiresSellingPlan()
        {
            base.InnerQuery.AddField("requiresSellingPlan");
            return this;
        }

        public QueryRootProductQueryBuilder ResourcePublicationOnCurrentPublication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2QueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2>("resourcePublicationOnCurrentPublication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2>(query);
            return this;
        }

        public QueryRootProductQueryBuilder ResourcePublications(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationConnection>("resourcePublications");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder ResourcePublicationsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("resourcePublicationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootProductQueryBuilder ResourcePublicationsV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2ConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2Connection>("resourcePublicationsV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2ConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2Connection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder RestrictedForResource(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RestrictedForResourceQueryBuilder> build)
        {
            var query = new Query<RestrictedForResource>("restrictedForResource");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RestrictedForResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RestrictedForResource>(query);
            return this;
        }

        [Obsolete("Use `sellingPlanGroupsCount` instead.")]
        public QueryRootProductQueryBuilder SellingPlanGroupCount()
        {
            base.InnerQuery.AddField("sellingPlanGroupCount");
            return this;
        }

        public QueryRootProductQueryBuilder SellingPlanGroups(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupConnection>("sellingPlanGroups");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder SellingPlanGroupsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("sellingPlanGroupsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootProductQueryBuilder Seo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SEOQueryBuilder> build)
        {
            var query = new Query<SEO>("seo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SEOQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SEO>(query);
            return this;
        }

        public QueryRootProductQueryBuilder StandardizedProductType(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StandardizedProductTypeQueryBuilder> build)
        {
            var query = new Query<StandardizedProductType>("standardizedProductType");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StandardizedProductTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardizedProductType>(query);
            return this;
        }

        public QueryRootProductQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        [Obsolete("Use `id` instead.")]
        public QueryRootProductQueryBuilder StorefrontId()
        {
            base.InnerQuery.AddField("storefrontId");
            return this;
        }

        public QueryRootProductQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public QueryRootProductQueryBuilder TemplateSuffix()
        {
            base.InnerQuery.AddField("templateSuffix");
            return this;
        }

        public QueryRootProductQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public QueryRootProductQueryBuilder TotalInventory()
        {
            base.InnerQuery.AddField("totalInventory");
            return this;
        }

        [Obsolete("Use `variantsCount` instead.")]
        public QueryRootProductQueryBuilder TotalVariants()
        {
            base.InnerQuery.AddField("totalVariants");
            return this;
        }

        public QueryRootProductQueryBuilder TracksInventory()
        {
            base.InnerQuery.AddField("tracksInventory");
            return this;
        }

        public QueryRootProductQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public QueryRootProductQueryBuilder UnpublishedChannels(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelConnectionQueryBuilder> build)
        {
            var query = new Query<ChannelConnection>("unpublishedChannels");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder UnpublishedPublications(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationConnectionQueryBuilder> build)
        {
            var query = new Query<PublicationConnection>("unpublishedPublications");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public QueryRootProductQueryBuilder Variants(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("variants");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }

        public QueryRootProductQueryBuilder VariantsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("variantsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootProductQueryBuilder Vendor()
        {
            base.InnerQuery.AddField("vendor");
            return this;
        }
    }
}