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
    public sealed class ProductVariantOperationQueryBuilder : FieldsQueryBuilderBase<ProductVariant, ProductVariantOperationQueryBuilder>, IGraphOperationQueryBuilder<ProductVariant>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ProductVariantArgumentsBuilder Arguments { get; }
        protected override ProductVariantOperationQueryBuilder Self => this;

        public ProductVariantOperationQueryBuilder() : this("productVariant")
        {
        }

        public ProductVariantOperationQueryBuilder(string name) : base(new Query<ProductVariant>(name))
        {
            Arguments = new ProductVariantArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantOperationQueryBuilder(IQuery<ProductVariant> query) : base(query)
        {
            Arguments = new ProductVariantArgumentsBuilder(base.InnerQuery);
        }

        public ProductVariantOperationQueryBuilder AvailableForSale()
        {
            base.InnerQuery.AddField("availableForSale");
            return this;
        }

        public ProductVariantOperationQueryBuilder Barcode()
        {
            base.InnerQuery.AddField("barcode");
            return this;
        }

        public ProductVariantOperationQueryBuilder CompareAtPrice()
        {
            base.InnerQuery.AddField("compareAtPrice");
            return this;
        }

        public ProductVariantOperationQueryBuilder ContextualPricing(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantContextualPricingQueryBuilder> build)
        {
            var query = new Query<ProductVariantContextualPricing>("contextualPricing");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantContextualPricingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantContextualPricing>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ProductVariantOperationQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public ProductVariantOperationQueryBuilder DeliveryProfile(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("deliveryProfile");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfile>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public ProductVariantOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductVariantOperationQueryBuilder Image(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder InventoryItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("inventoryItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder InventoryPolicy()
        {
            base.InnerQuery.AddField("inventoryPolicy");
            return this;
        }

        public ProductVariantOperationQueryBuilder InventoryQuantity()
        {
            base.InnerQuery.AddField("inventoryQuantity");
            return this;
        }

        public ProductVariantOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public ProductVariantOperationQueryBuilder Media(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaConnectionQueryBuilder> build)
        {
            var query = new Query<MediaConnection>("media");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaConnection>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }

        public ProductVariantOperationQueryBuilder PresentmentPrices(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantPricePairConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantPricePairConnection>("presentmentPrices");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantPricePairConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantPricePairConnection>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder Price()
        {
            base.InnerQuery.AddField("price");
            return this;
        }

        public ProductVariantOperationQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder ProductParents(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("productParents");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder ProductVariantComponents(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantComponentConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantComponentConnection>("productVariantComponents");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantComponentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantComponentConnection>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder RequiresComponents()
        {
            base.InnerQuery.AddField("requiresComponents");
            return this;
        }

        public ProductVariantOperationQueryBuilder SelectedOptions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SelectedOptionQueryBuilder> build)
        {
            var query = new Query<SelectedOption>("selectedOptions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SelectedOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SelectedOption>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder SellableOnlineQuantity()
        {
            base.InnerQuery.AddField("sellableOnlineQuantity");
            return this;
        }

        [Obsolete("Use `sellingPlanGroupsCount` instead.")]
        public ProductVariantOperationQueryBuilder SellingPlanGroupCount()
        {
            base.InnerQuery.AddField("sellingPlanGroupCount");
            return this;
        }

        public ProductVariantOperationQueryBuilder SellingPlanGroups(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupConnection>("sellingPlanGroups");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupConnection>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder SellingPlanGroupsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("sellingPlanGroupsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder ShowUnitPrice()
        {
            base.InnerQuery.AddField("showUnitPrice");
            return this;
        }

        public ProductVariantOperationQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        [Obsolete("Use `id` instead.")]
        public ProductVariantOperationQueryBuilder StorefrontId()
        {
            base.InnerQuery.AddField("storefrontId");
            return this;
        }

        public ProductVariantOperationQueryBuilder Taxable()
        {
            base.InnerQuery.AddField("taxable");
            return this;
        }

        [Obsolete("This field should no longer be used in new integrations. This field will not be available in future API versions.")]
        public ProductVariantOperationQueryBuilder TaxCode()
        {
            base.InnerQuery.AddField("taxCode");
            return this;
        }

        public ProductVariantOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public ProductVariantOperationQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder UnitPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("unitPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder UnitPriceMeasurement(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UnitPriceMeasurementQueryBuilder> build)
        {
            var query = new Query<UnitPriceMeasurement>("unitPriceMeasurement");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UnitPriceMeasurementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UnitPriceMeasurement>(query);
            return this;
        }

        public ProductVariantOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}