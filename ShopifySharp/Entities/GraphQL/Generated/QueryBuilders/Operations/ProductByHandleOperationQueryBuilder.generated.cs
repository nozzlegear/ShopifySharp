#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    [Obsolete("Use `productByIdentifier` instead.")]
    public sealed class ProductByHandleOperationQueryBuilder : FieldsQueryBuilderBase<Product, ProductByHandleOperationQueryBuilder>, IGraphOperationQueryBuilder<Product>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ProductByHandleArgumentsBuilder Arguments { get; }
        protected override ProductByHandleOperationQueryBuilder Self => this;

        public ProductByHandleOperationQueryBuilder() : this("productByHandle")
        {
        }

        public ProductByHandleOperationQueryBuilder(string name) : base(new Query<Product>(name))
        {
            Arguments = new ProductByHandleArgumentsBuilder(base.InnerQuery);
        }

        public ProductByHandleOperationQueryBuilder(IQuery<Product> query) : base(query)
        {
            Arguments = new ProductByHandleArgumentsBuilder(base.InnerQuery);
        }

        public ProductByHandleOperationQueryBuilder AvailablePublicationsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("availablePublicationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        [Obsolete("Use `descriptionHtml` instead.")]
        public ProductByHandleOperationQueryBuilder BodyHtml()
        {
            base.InnerQuery.AddField("bodyHtml");
            return this;
        }

        public ProductByHandleOperationQueryBuilder BundleComponents(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentConnectionQueryBuilder> build)
        {
            var query = new Query<ProductBundleComponentConnection>("bundleComponents");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductBundleComponentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductBundleComponentConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder BundleConsolidatedOptions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ComponentizedProductsBundleConsolidatedOptionQueryBuilder> build)
        {
            var query = new Query<ComponentizedProductsBundleConsolidatedOption>("bundleConsolidatedOptions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ComponentizedProductsBundleConsolidatedOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ComponentizedProductsBundleConsolidatedOption>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder Category(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryQueryBuilder> build)
        {
            var query = new Query<TaxonomyCategory>("category");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TaxonomyCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TaxonomyCategory>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder Collections(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionConnectionQueryBuilder> build)
        {
            var query = new Query<CollectionConnection>("collections");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CollectionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder CombinedListing(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CombinedListingQueryBuilder> build)
        {
            var query = new Query<CombinedListing>("combinedListing");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CombinedListingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CombinedListing>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder CombinedListingRole()
        {
            base.InnerQuery.AddField("combinedListingRole");
            return this;
        }

        public ProductByHandleOperationQueryBuilder CompareAtPriceRange(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductCompareAtPriceRangeQueryBuilder> build)
        {
            var query = new Query<ProductCompareAtPriceRange>("compareAtPriceRange");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductCompareAtPriceRangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductCompareAtPriceRange>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder ContextualPricing(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductContextualPricingQueryBuilder> build)
        {
            var query = new Query<ProductContextualPricing>("contextualPricing");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductContextualPricingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductContextualPricing>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        [Obsolete("Use `productType` instead.")]
        public ProductByHandleOperationQueryBuilder CustomProductType()
        {
            base.InnerQuery.AddField("customProductType");
            return this;
        }

        public ProductByHandleOperationQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public ProductByHandleOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public ProductByHandleOperationQueryBuilder DescriptionHtml()
        {
            base.InnerQuery.AddField("descriptionHtml");
            return this;
        }

        [Obsolete("Use `description` instead.")]
        public ProductByHandleOperationQueryBuilder DescriptionPlainSummary()
        {
            base.InnerQuery.AddField("descriptionPlainSummary");
            return this;
        }

        public ProductByHandleOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder FeaturedImage(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("featuredImage");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder FeaturedMedia(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaQueryBuilder> build)
        {
            var query = new Query<IMedia>("featuredMedia");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMedia>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder Feedback(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceFeedbackQueryBuilder> build)
        {
            var query = new Query<ResourceFeedback>("feedback");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourceFeedbackQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourceFeedback>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder GiftCardTemplateSuffix()
        {
            base.InnerQuery.AddField("giftCardTemplateSuffix");
            return this;
        }

        public ProductByHandleOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public ProductByHandleOperationQueryBuilder HasOnlyDefaultVariant()
        {
            base.InnerQuery.AddField("hasOnlyDefaultVariant");
            return this;
        }

        public ProductByHandleOperationQueryBuilder HasOutOfStockVariants()
        {
            base.InnerQuery.AddField("hasOutOfStockVariants");
            return this;
        }

        public ProductByHandleOperationQueryBuilder HasVariantsThatRequiresComponents()
        {
            base.InnerQuery.AddField("hasVariantsThatRequiresComponents");
            return this;
        }

        public ProductByHandleOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductByHandleOperationQueryBuilder Images(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageConnectionQueryBuilder> build)
        {
            var query = new Query<ImageConnection>("images");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ImageConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder InCollection()
        {
            base.InnerQuery.AddField("inCollection");
            return this;
        }

        public ProductByHandleOperationQueryBuilder IsGiftCard()
        {
            base.InnerQuery.AddField("isGiftCard");
            return this;
        }

        public ProductByHandleOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public ProductByHandleOperationQueryBuilder Media(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaConnectionQueryBuilder> build)
        {
            var query = new Query<MediaConnection>("media");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder MediaCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("mediaCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder OnlineStorePreviewUrl()
        {
            base.InnerQuery.AddField("onlineStorePreviewUrl");
            return this;
        }

        public ProductByHandleOperationQueryBuilder OnlineStoreUrl()
        {
            base.InnerQuery.AddField("onlineStoreUrl");
            return this;
        }

        public ProductByHandleOperationQueryBuilder Options(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionQueryBuilder> build)
        {
            var query = new Query<ProductOption>("options");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductOption>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder PriceRange(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPriceRangeQueryBuilder> build)
        {
            var query = new Query<ProductPriceRange>("priceRange");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPriceRangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPriceRange>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder PriceRangeV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPriceRangeV2QueryBuilder> build)
        {
            var query = new Query<ProductPriceRangeV2>("priceRangeV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPriceRangeV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPriceRangeV2>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder ProductCategory(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductCategoryQueryBuilder> build)
        {
            var query = new Query<ProductCategory>("productCategory");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductCategoryQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductCategory>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder ProductComponents(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductComponentTypeConnectionQueryBuilder> build)
        {
            var query = new Query<ProductComponentTypeConnection>("productComponents");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductComponentTypeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductComponentTypeConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder ProductComponentsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("productComponentsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder ProductParents(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("productParents");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder ProductPublications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ProductPublicationConnection>("productPublications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublicationConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder ProductType()
        {
            base.InnerQuery.AddField("productType");
            return this;
        }

        [Obsolete("Use `resourcePublicationsCount` instead.")]
        public ProductByHandleOperationQueryBuilder PublicationCount()
        {
            base.InnerQuery.AddField("publicationCount");
            return this;
        }

        public ProductByHandleOperationQueryBuilder Publications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ProductPublicationConnection>("publications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductPublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductPublicationConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder PublishedAt()
        {
            base.InnerQuery.AddField("publishedAt");
            return this;
        }

        public ProductByHandleOperationQueryBuilder PublishedInContext()
        {
            base.InnerQuery.AddField("publishedInContext");
            return this;
        }

        [Obsolete("Use `publishedOnPublication` instead.")]
        public ProductByHandleOperationQueryBuilder PublishedOnChannel()
        {
            base.InnerQuery.AddField("publishedOnChannel");
            return this;
        }

        [Obsolete("Use `publishedOnCurrentPublication` instead.")]
        public ProductByHandleOperationQueryBuilder PublishedOnCurrentChannel()
        {
            base.InnerQuery.AddField("publishedOnCurrentChannel");
            return this;
        }

        public ProductByHandleOperationQueryBuilder PublishedOnCurrentPublication()
        {
            base.InnerQuery.AddField("publishedOnCurrentPublication");
            return this;
        }

        public ProductByHandleOperationQueryBuilder PublishedOnPublication()
        {
            base.InnerQuery.AddField("publishedOnPublication");
            return this;
        }

        public ProductByHandleOperationQueryBuilder RequiresSellingPlan()
        {
            base.InnerQuery.AddField("requiresSellingPlan");
            return this;
        }

        public ProductByHandleOperationQueryBuilder ResourcePublicationOnCurrentPublication(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationV2QueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2>("resourcePublicationOnCurrentPublication");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder ResourcePublications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationConnection>("resourcePublications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder ResourcePublicationsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("resourcePublicationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder ResourcePublicationsV2(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationV2ConnectionQueryBuilder> build)
        {
            var query = new Query<ResourcePublicationV2Connection>("resourcePublicationsV2");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ResourcePublicationV2ConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ResourcePublicationV2Connection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder RestrictedForResource(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RestrictedForResourceQueryBuilder> build)
        {
            var query = new Query<RestrictedForResource>("restrictedForResource");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RestrictedForResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RestrictedForResource>(query);
            return this;
        }

        [Obsolete("Use `sellingPlanGroupsCount` instead.")]
        public ProductByHandleOperationQueryBuilder SellingPlanGroupCount()
        {
            base.InnerQuery.AddField("sellingPlanGroupCount");
            return this;
        }

        public ProductByHandleOperationQueryBuilder SellingPlanGroups(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupConnection>("sellingPlanGroups");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder SellingPlanGroupsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("sellingPlanGroupsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder Seo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SEOQueryBuilder> build)
        {
            var query = new Query<SEO>("seo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SEOQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SEO>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder StandardizedProductType(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardizedProductTypeQueryBuilder> build)
        {
            var query = new Query<StandardizedProductType>("standardizedProductType");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StandardizedProductTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StandardizedProductType>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        [Obsolete("Use `id` instead.")]
        public ProductByHandleOperationQueryBuilder StorefrontId()
        {
            base.InnerQuery.AddField("storefrontId");
            return this;
        }

        public ProductByHandleOperationQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public ProductByHandleOperationQueryBuilder TemplateSuffix()
        {
            base.InnerQuery.AddField("templateSuffix");
            return this;
        }

        public ProductByHandleOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public ProductByHandleOperationQueryBuilder TotalInventory()
        {
            base.InnerQuery.AddField("totalInventory");
            return this;
        }

        [Obsolete("Use `variantsCount` instead.")]
        public ProductByHandleOperationQueryBuilder TotalVariants()
        {
            base.InnerQuery.AddField("totalVariants");
            return this;
        }

        public ProductByHandleOperationQueryBuilder TracksInventory()
        {
            base.InnerQuery.AddField("tracksInventory");
            return this;
        }

        public ProductByHandleOperationQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder UnpublishedChannels(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelConnectionQueryBuilder> build)
        {
            var query = new Query<ChannelConnection>("unpublishedChannels");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ChannelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ChannelConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder UnpublishedPublications(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationConnectionQueryBuilder> build)
        {
            var query = new Query<PublicationConnection>("unpublishedPublications");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PublicationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PublicationConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public ProductByHandleOperationQueryBuilder Variants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("variants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder VariantsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("variantsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductByHandleOperationQueryBuilder Vendor()
        {
            base.InnerQuery.AddField("vendor");
            return this;
        }
    }
}