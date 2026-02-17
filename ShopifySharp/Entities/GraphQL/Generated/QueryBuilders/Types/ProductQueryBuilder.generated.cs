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
    public sealed class ProductQueryBuilder : FieldsQueryBuilderBase<Product, ProductQueryBuilder>
    {
        protected override ProductQueryBuilder Self => this;

        public ProductQueryBuilder() : this("product")
        {
        }

        public ProductQueryBuilder(string name) : base(new Query<Product>(name))
        {
        }

        public ProductQueryBuilder(IQuery<Product> query) : base(query)
        {
        }

        public ProductQueryBuilder AvailablePublicationsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("availablePublicationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        [Obsolete("Use `descriptionHtml` instead.")]
        public ProductQueryBuilder BodyHtml()
        {
            base.InnerQuery.AddField("bodyHtml");
            return this;
        }

        public ProductQueryBuilder BundleComponents(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentConnectionQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponentConnection>("bundleComponents");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductBundleComponentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponentConnection>(query);
            return this;
        }

        public ProductQueryBuilder BundleConsolidatedOptions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ComponentizedProductsBundleConsolidatedOptionQueryBuilder> build)
        {
            var query = new Query<ComponentizedProductsBundleConsolidatedOption>("bundleConsolidatedOptions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ComponentizedProductsBundleConsolidatedOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ComponentizedProductsBundleConsolidatedOption>(query);
            return this;
        }

        public ProductQueryBuilder Category(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategory>("category");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TaxonomyCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategory>(query);
            return this;
        }

        public ProductQueryBuilder Collections(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public ProductQueryBuilder CombinedListing(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingQueryBuilder> build)
        {
            var query = new Query<CombinedListing>("combinedListing");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CombinedListingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CombinedListing>(query);
            return this;
        }

        public ProductQueryBuilder CombinedListingRole()
        {
            base.InnerQuery.AddField("combinedListingRole");
            return this;
        }

        public ProductQueryBuilder CompareAtPriceRange(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductCompareAtPriceRangeQueryBuilder> build)
        {
            var query = new Query<ProductCompareAtPriceRange>("compareAtPriceRange");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductCompareAtPriceRangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductCompareAtPriceRange>(query);
            return this;
        }

        public ProductQueryBuilder ContextualPricing(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductContextualPricingQueryBuilder> build)
        {
            var query = new Query<ProductContextualPricing>("contextualPricing");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductContextualPricingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductContextualPricing>(query);
            return this;
        }

        public ProductQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        [Obsolete("Use `productType` instead.")]
        public ProductQueryBuilder CustomProductType()
        {
            base.InnerQuery.AddField("customProductType");
            return this;
        }

        public ProductQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public ProductQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public ProductQueryBuilder DescriptionHtml()
        {
            base.InnerQuery.AddField("descriptionHtml");
            return this;
        }

        [Obsolete("Use `description` instead.")]
        public ProductQueryBuilder DescriptionPlainSummary()
        {
            base.InnerQuery.AddField("descriptionPlainSummary");
            return this;
        }

        public ProductQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public ProductQueryBuilder FeaturedImage(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("featuredImage");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public ProductQueryBuilder FeaturedMedia(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaQueryBuilder> build)
        {
            var query = new Query<IMedia>("featuredMedia");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMedia>(query);
            return this;
        }

        public ProductQueryBuilder Feedback(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourceFeedbackQueryBuilder> build)
        {
            var query = new Query<ResourceFeedback>("feedback");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourceFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourceFeedback>(query);
            return this;
        }

        public ProductQueryBuilder GiftCardTemplateSuffix()
        {
            base.InnerQuery.AddField("giftCardTemplateSuffix");
            return this;
        }

        public ProductQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public ProductQueryBuilder HasOnlyDefaultVariant()
        {
            base.InnerQuery.AddField("hasOnlyDefaultVariant");
            return this;
        }

        public ProductQueryBuilder HasOutOfStockVariants()
        {
            base.InnerQuery.AddField("hasOutOfStockVariants");
            return this;
        }

        public ProductQueryBuilder HasVariantsThatRequiresComponents()
        {
            base.InnerQuery.AddField("hasVariantsThatRequiresComponents");
            return this;
        }

        public ProductQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductQueryBuilder Images(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageConnectionQueryBuilder> build)
        {
            var query = new Query<ImageConnection>("images");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ImageConnection>(query);
            return this;
        }

        public ProductQueryBuilder InCollection()
        {
            base.InnerQuery.AddField("inCollection");
            return this;
        }

        public ProductQueryBuilder IsGiftCard()
        {
            base.InnerQuery.AddField("isGiftCard");
            return this;
        }

        public ProductQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public ProductQueryBuilder Media(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaConnectionQueryBuilder> build)
        {
            var query = new Query<MediaConnection>("media");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaConnection>(query);
            return this;
        }

        public ProductQueryBuilder MediaCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("mediaCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public ProductQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public ProductQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public ProductQueryBuilder OnlineStorePreviewUrl()
        {
            base.InnerQuery.AddField("onlineStorePreviewUrl");
            return this;
        }

        public ProductQueryBuilder OnlineStoreUrl()
        {
            base.InnerQuery.AddField("onlineStoreUrl");
            return this;
        }

        public ProductQueryBuilder Options(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionQueryBuilder> build)
        {
            var query = new Query<ProductOption>("options");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOption>(query);
            return this;
        }

        public ProductQueryBuilder PriceRange(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPriceRangeQueryBuilder> build)
        {
            var query = new Query<ProductPriceRange>("priceRange");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPriceRangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPriceRange>(query);
            return this;
        }

        public ProductQueryBuilder PriceRangeV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPriceRangeV2QueryBuilder> build)
        {
            var query = new Query<ProductPriceRangeV2>("priceRangeV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPriceRangeV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPriceRangeV2>(query);
            return this;
        }

        public ProductQueryBuilder ProductCategory(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductCategoryQueryBuilder> build)
        {
            var query = new Query<ProductCategory>("productCategory");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductCategory>(query);
            return this;
        }

        public ProductQueryBuilder ProductComponents(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductComponentTypeConnectionQueryBuilder> build)
        {
            var query = new Query<ProductComponentTypeConnection>("productComponents");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductComponentTypeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductComponentTypeConnection>(query);
            return this;
        }

        public ProductQueryBuilder ProductComponentsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productComponentsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductQueryBuilder ProductParents(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("productParents");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public ProductQueryBuilder ProductPublications(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ProductPublicationConnection>("productPublications");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublicationConnection>(query);
            return this;
        }

        public ProductQueryBuilder ProductType()
        {
            base.InnerQuery.AddField("productType");
            return this;
        }

        [Obsolete("Use `resourcePublicationsCount` instead.")]
        public ProductQueryBuilder PublicationCount()
        {
            base.InnerQuery.AddField("publicationCount");
            return this;
        }

        public ProductQueryBuilder Publications(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ProductPublicationConnection>("publications");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublicationConnection>(query);
            return this;
        }

        public ProductQueryBuilder PublishedAt()
        {
            base.InnerQuery.AddField("publishedAt");
            return this;
        }

        public ProductQueryBuilder PublishedInContext()
        {
            base.InnerQuery.AddField("publishedInContext");
            return this;
        }

        [Obsolete("Use `publishedOnPublication` instead.")]
        public ProductQueryBuilder PublishedOnChannel()
        {
            base.InnerQuery.AddField("publishedOnChannel");
            return this;
        }

        [Obsolete("Use `publishedOnCurrentPublication` instead.")]
        public ProductQueryBuilder PublishedOnCurrentChannel()
        {
            base.InnerQuery.AddField("publishedOnCurrentChannel");
            return this;
        }

        public ProductQueryBuilder PublishedOnCurrentPublication()
        {
            base.InnerQuery.AddField("publishedOnCurrentPublication");
            return this;
        }

        public ProductQueryBuilder PublishedOnPublication()
        {
            base.InnerQuery.AddField("publishedOnPublication");
            return this;
        }

        public ProductQueryBuilder RequiresSellingPlan()
        {
            base.InnerQuery.AddField("requiresSellingPlan");
            return this;
        }

        public ProductQueryBuilder ResourcePublicationOnCurrentPublication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2QueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2>("resourcePublicationOnCurrentPublication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2>(query);
            return this;
        }

        public ProductQueryBuilder ResourcePublications(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationConnection>("resourcePublications");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationConnection>(query);
            return this;
        }

        public ProductQueryBuilder ResourcePublicationsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("resourcePublicationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductQueryBuilder ResourcePublicationsV2(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2ConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2Connection>("resourcePublicationsV2");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ResourcePublicationV2ConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2Connection>(query);
            return this;
        }

        public ProductQueryBuilder RestrictedForResource(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RestrictedForResourceQueryBuilder> build)
        {
            var query = new Query<RestrictedForResource>("restrictedForResource");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RestrictedForResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RestrictedForResource>(query);
            return this;
        }

        [Obsolete("Use `sellingPlanGroupsCount` instead.")]
        public ProductQueryBuilder SellingPlanGroupCount()
        {
            base.InnerQuery.AddField("sellingPlanGroupCount");
            return this;
        }

        public ProductQueryBuilder SellingPlanGroups(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupConnection>("sellingPlanGroups");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupConnection>(query);
            return this;
        }

        public ProductQueryBuilder SellingPlanGroupsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("sellingPlanGroupsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductQueryBuilder Seo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SEOQueryBuilder> build)
        {
            var query = new Query<SEO>("seo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SEOQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SEO>(query);
            return this;
        }

        public ProductQueryBuilder StandardizedProductType(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StandardizedProductTypeQueryBuilder> build)
        {
            var query = new Query<StandardizedProductType>("standardizedProductType");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StandardizedProductTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardizedProductType>(query);
            return this;
        }

        public ProductQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        [Obsolete("Use `id` instead.")]
        public ProductQueryBuilder StorefrontId()
        {
            base.InnerQuery.AddField("storefrontId");
            return this;
        }

        public ProductQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public ProductQueryBuilder TemplateSuffix()
        {
            base.InnerQuery.AddField("templateSuffix");
            return this;
        }

        public ProductQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public ProductQueryBuilder TotalInventory()
        {
            base.InnerQuery.AddField("totalInventory");
            return this;
        }

        [Obsolete("Use `variantsCount` instead.")]
        public ProductQueryBuilder TotalVariants()
        {
            base.InnerQuery.AddField("totalVariants");
            return this;
        }

        public ProductQueryBuilder TracksInventory()
        {
            base.InnerQuery.AddField("tracksInventory");
            return this;
        }

        public ProductQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public ProductQueryBuilder UnpublishedChannels(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ChannelConnectionQueryBuilder> build)
        {
            var query = new Query<ChannelConnection>("unpublishedChannels");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ChannelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelConnection>(query);
            return this;
        }

        public ProductQueryBuilder UnpublishedPublications(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationConnectionQueryBuilder> build)
        {
            var query = new Query<PublicationConnection>("unpublishedPublications");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationConnection>(query);
            return this;
        }

        public ProductQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ProductQueryBuilder Variants(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("variants");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }

        public ProductQueryBuilder VariantsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("variantsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductQueryBuilder Vendor()
        {
            base.InnerQuery.AddField("vendor");
            return this;
        }
    }
}