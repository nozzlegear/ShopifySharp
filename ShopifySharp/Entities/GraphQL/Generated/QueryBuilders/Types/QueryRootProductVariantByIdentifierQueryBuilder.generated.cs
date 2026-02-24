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
    public sealed class QueryRootProductVariantByIdentifierQueryBuilder : FieldsQueryBuilderBase<ProductVariant, QueryRootProductVariantByIdentifierQueryBuilder>, IHasArguments<QueryRootProductVariantByIdentifierArgumentsBuilder>
    {
        public QueryRootProductVariantByIdentifierArgumentsBuilder Arguments { get; }
        protected override QueryRootProductVariantByIdentifierQueryBuilder Self => this;

        public QueryRootProductVariantByIdentifierQueryBuilder(string name) : base(new Query<ProductVariant>(name))
        {
            Arguments = new QueryRootProductVariantByIdentifierArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductVariantByIdentifierQueryBuilder(IQuery<ProductVariant> query) : base(query)
        {
            Arguments = new QueryRootProductVariantByIdentifierArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductVariantByIdentifierQueryBuilder SetArguments(Action<QueryRootProductVariantByIdentifierArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder AvailableForSale()
        {
            base.InnerQuery.AddField("availableForSale");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Barcode()
        {
            base.InnerQuery.AddField("barcode");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder CompareAtPrice()
        {
            base.InnerQuery.AddField("compareAtPrice");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder ContextualPricing(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantContextualPricingQueryBuilder> build)
        {
            var query = new Query<ProductVariantContextualPricing>("contextualPricing");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantContextualPricingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantContextualPricing>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder DeliveryProfile(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileQueryBuilder> build)
        {
            var query = new Query<DeliveryProfile>("deliveryProfile");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryProfile>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Image(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("image");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder InventoryItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("inventoryItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder InventoryPolicy()
        {
            base.InnerQuery.AddField("inventoryPolicy");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder InventoryQuantity()
        {
            base.InnerQuery.AddField("inventoryQuantity");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Media(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MediaConnectionQueryBuilder> build)
        {
            var query = new Query<MediaConnection>("media");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MediaConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MediaConnection>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Position()
        {
            base.InnerQuery.AddField("position");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder PresentmentPrices(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantPricePairConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantPricePairConnection>("presentmentPrices");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantPricePairConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantPricePairConnection>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Price()
        {
            base.InnerQuery.AddField("price");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder ProductParents(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("productParents");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder ProductVariantComponents(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantComponentConnection>("productVariantComponents");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantComponentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantComponentConnection>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder RequiresComponents()
        {
            base.InnerQuery.AddField("requiresComponents");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder SelectedOptions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SelectedOptionQueryBuilder> build)
        {
            var query = new Query<SelectedOption>("selectedOptions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SelectedOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SelectedOption>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder SellableOnlineQuantity()
        {
            base.InnerQuery.AddField("sellableOnlineQuantity");
            return this;
        }

        [Obsolete("Use `sellingPlanGroupsCount` instead.")]
        public QueryRootProductVariantByIdentifierQueryBuilder SellingPlanGroupCount()
        {
            base.InnerQuery.AddField("sellingPlanGroupCount");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder SellingPlanGroups(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupConnection>("sellingPlanGroups");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanGroupConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupConnection>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder SellingPlanGroupsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("sellingPlanGroupsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder ShowUnitPrice()
        {
            base.InnerQuery.AddField("showUnitPrice");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        [Obsolete("Use `id` instead.")]
        public QueryRootProductVariantByIdentifierQueryBuilder StorefrontId()
        {
            base.InnerQuery.AddField("storefrontId");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Taxable()
        {
            base.InnerQuery.AddField("taxable");
            return this;
        }

        [Obsolete("This field should no longer be used in new integrations. This field will not be available in future API versions.")]
        public QueryRootProductVariantByIdentifierQueryBuilder TaxCode()
        {
            base.InnerQuery.AddField("taxCode");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder Translations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder> build)
        {
            var query = new Query<Translation>("translations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Translation>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder UnitPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("unitPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder UnitPriceMeasurement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UnitPriceMeasurementQueryBuilder> build)
        {
            var query = new Query<UnitPriceMeasurement>("unitPriceMeasurement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UnitPriceMeasurementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UnitPriceMeasurement>(query);
            return this;
        }

        public QueryRootProductVariantByIdentifierQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}