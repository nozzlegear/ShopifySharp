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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ProductVariantQueryBuilder : FieldsQueryBuilderBase<ProductVariant, ProductVariantQueryBuilder>
    {
        protected override ProductVariantQueryBuilder Self => this;

        public ProductVariantQueryBuilder() : this("productVariant")
        {
        }

        public ProductVariantQueryBuilder(string name) : base(new Query<ProductVariant>(name))
        {
        }

        public ProductVariantQueryBuilder(IQuery<ProductVariant> query) : base(query)
        {
        }

        public ProductVariantQueryBuilder AvailableForSale()
        {
            base.InnerQuery.AddField("availableForSale");
            return this;
        }

        public ProductVariantQueryBuilder Barcode()
        {
            base.InnerQuery.AddField("barcode");
            return this;
        }

        public ProductVariantQueryBuilder CompareAtPrice()
        {
            base.InnerQuery.AddField("compareAtPrice");
            return this;
        }

        public ProductVariantQueryBuilder ContextualPricing(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantContextualPricingQueryBuilder> build)
        {
            var query = new Query<ProductVariantContextualPricing>("contextualPricing");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantContextualPricingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantContextualPricing>(query);
            return this;
        }

        public ProductVariantQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ProductVariantQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public ProductVariantQueryBuilder DeliveryProfile(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("deliveryProfile");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfile>(query);
            return this;
        }

        public ProductVariantQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public ProductVariantQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public ProductVariantQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ProductVariantQueryBuilder Image(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public ProductVariantQueryBuilder InventoryItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("inventoryItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public ProductVariantQueryBuilder InventoryPolicy()
        {
            base.InnerQuery.AddField("inventoryPolicy");
            return this;
        }

        public ProductVariantQueryBuilder InventoryQuantity()
        {
            base.InnerQuery.AddField("inventoryQuantity");
            return this;
        }

        public ProductVariantQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public ProductVariantQueryBuilder Media(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaConnectionQueryBuilder> build)
        {
            var query = new Query<MediaConnection>("media");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MediaConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaConnection>(query);
            return this;
        }

        public ProductVariantQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public ProductVariantQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public ProductVariantQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public ProductVariantQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }

        public ProductVariantQueryBuilder PresentmentPrices(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantPricePairConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantPricePairConnection>("presentmentPrices");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantPricePairConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantPricePairConnection>(query);
            return this;
        }

        public ProductVariantQueryBuilder Price()
        {
            base.InnerQuery.AddField("price");
            return this;
        }

        public ProductVariantQueryBuilder Product(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public ProductVariantQueryBuilder ProductParents(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("productParents");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public ProductVariantQueryBuilder ProductVariantComponents(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantComponentConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantComponentConnection>("productVariantComponents");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantComponentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantComponentConnection>(query);
            return this;
        }

        public ProductVariantQueryBuilder RequiresComponents()
        {
            base.InnerQuery.AddField("requiresComponents");
            return this;
        }

        public ProductVariantQueryBuilder SelectedOptions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SelectedOptionQueryBuilder> build)
        {
            var query = new Query<SelectedOption>("selectedOptions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SelectedOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SelectedOption>(query);
            return this;
        }

        public ProductVariantQueryBuilder SellableOnlineQuantity()
        {
            base.InnerQuery.AddField("sellableOnlineQuantity");
            return this;
        }

        [Obsolete("Use `sellingPlanGroupsCount` instead.")]
        public ProductVariantQueryBuilder SellingPlanGroupCount()
        {
            base.InnerQuery.AddField("sellingPlanGroupCount");
            return this;
        }

        public ProductVariantQueryBuilder SellingPlanGroups(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupConnection>("sellingPlanGroups");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupConnection>(query);
            return this;
        }

        public ProductVariantQueryBuilder SellingPlanGroupsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("sellingPlanGroupsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public ProductVariantQueryBuilder ShowUnitPrice()
        {
            base.InnerQuery.AddField("showUnitPrice");
            return this;
        }

        public ProductVariantQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        [Obsolete("Use `id` instead.")]
        public ProductVariantQueryBuilder StorefrontId()
        {
            base.InnerQuery.AddField("storefrontId");
            return this;
        }

        public ProductVariantQueryBuilder Taxable()
        {
            base.InnerQuery.AddField("taxable");
            return this;
        }

        [Obsolete("This field should no longer be used in new integrations. This field will not be available in future API versions.")]
        public ProductVariantQueryBuilder TaxCode()
        {
            base.InnerQuery.AddField("taxCode");
            return this;
        }

        public ProductVariantQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public ProductVariantQueryBuilder Translations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public ProductVariantQueryBuilder UnitPrice(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("unitPrice");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ProductVariantQueryBuilder UnitPriceMeasurement(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UnitPriceMeasurementQueryBuilder> build)
        {
            var query = new Query<UnitPriceMeasurement>("unitPriceMeasurement");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UnitPriceMeasurementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UnitPriceMeasurement>(query);
            return this;
        }

        public ProductVariantQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}