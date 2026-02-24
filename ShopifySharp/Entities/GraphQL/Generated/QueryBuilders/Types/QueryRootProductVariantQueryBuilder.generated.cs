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
    public sealed class QueryRootProductVariantQueryBuilder : FieldsQueryBuilderBase<ProductVariant, QueryRootProductVariantQueryBuilder>, IHasArguments<QueryRootProductVariantArgumentsBuilder>
    {
        public QueryRootProductVariantArgumentsBuilder Arguments { get; }
        protected override QueryRootProductVariantQueryBuilder Self => this;

        public QueryRootProductVariantQueryBuilder(string name) : base(new Query<ProductVariant>(name))
        {
            Arguments = new QueryRootProductVariantArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductVariantQueryBuilder(IQuery<ProductVariant> query) : base(query)
        {
            Arguments = new QueryRootProductVariantArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductVariantQueryBuilder SetArguments(Action<QueryRootProductVariantArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootProductVariantQueryBuilder AvailableForSale()
        {
            base.InnerQuery.AddField("availableForSale");
            return this;
        }

        public QueryRootProductVariantQueryBuilder Barcode()
        {
            base.InnerQuery.AddField("barcode");
            return this;
        }

        public QueryRootProductVariantQueryBuilder CompareAtPrice()
        {
            base.InnerQuery.AddField("compareAtPrice");
            return this;
        }

        public QueryRootProductVariantQueryBuilder ContextualPricing(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantContextualPricingQueryBuilder> build)
        {
            var query = new Query<ProductVariantContextualPricing>("contextualPricing");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantContextualPricingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantContextualPricing>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootProductVariantQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public QueryRootProductVariantQueryBuilder DeliveryProfile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("deliveryProfile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfile>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public QueryRootProductVariantQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootProductVariantQueryBuilder Image(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder InventoryItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("inventoryItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder InventoryPolicy()
        {
            base.InnerQuery.AddField("inventoryPolicy");
            return this;
        }

        public QueryRootProductVariantQueryBuilder InventoryQuantity()
        {
            base.InnerQuery.AddField("inventoryQuantity");
            return this;
        }

        public QueryRootProductVariantQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public QueryRootProductVariantQueryBuilder Media(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaConnectionQueryBuilder> build)
        {
            var query = new Query<MediaConnection>("media");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaConnection>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }

        public QueryRootProductVariantQueryBuilder PresentmentPrices(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantPricePairConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantPricePairConnection>("presentmentPrices");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantPricePairConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantPricePairConnection>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder Price()
        {
            base.InnerQuery.AddField("price");
            return this;
        }

        public QueryRootProductVariantQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder ProductParents(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("productParents");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder ProductVariantComponents(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantComponentConnection>("productVariantComponents");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantComponentConnection>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder RequiresComponents()
        {
            base.InnerQuery.AddField("requiresComponents");
            return this;
        }

        public QueryRootProductVariantQueryBuilder SelectedOptions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SelectedOptionQueryBuilder> build)
        {
            var query = new Query<SelectedOption>("selectedOptions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SelectedOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SelectedOption>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder SellableOnlineQuantity()
        {
            base.InnerQuery.AddField("sellableOnlineQuantity");
            return this;
        }

        [Obsolete("Use `sellingPlanGroupsCount` instead.")]
        public QueryRootProductVariantQueryBuilder SellingPlanGroupCount()
        {
            base.InnerQuery.AddField("sellingPlanGroupCount");
            return this;
        }

        public QueryRootProductVariantQueryBuilder SellingPlanGroups(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupConnection>("sellingPlanGroups");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupConnection>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder SellingPlanGroupsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("sellingPlanGroupsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder ShowUnitPrice()
        {
            base.InnerQuery.AddField("showUnitPrice");
            return this;
        }

        public QueryRootProductVariantQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        [Obsolete("Use `id` instead.")]
        public QueryRootProductVariantQueryBuilder StorefrontId()
        {
            base.InnerQuery.AddField("storefrontId");
            return this;
        }

        public QueryRootProductVariantQueryBuilder Taxable()
        {
            base.InnerQuery.AddField("taxable");
            return this;
        }

        [Obsolete("This field should no longer be used in new integrations. This field will not be available in future API versions.")]
        public QueryRootProductVariantQueryBuilder TaxCode()
        {
            base.InnerQuery.AddField("taxCode");
            return this;
        }

        public QueryRootProductVariantQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public QueryRootProductVariantQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder UnitPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("unitPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder UnitPriceMeasurement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UnitPriceMeasurementQueryBuilder> build)
        {
            var query = new Query<UnitPriceMeasurement>("unitPriceMeasurement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UnitPriceMeasurementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UnitPriceMeasurement>(query);
            return this;
        }

        public QueryRootProductVariantQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}