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
    public sealed class InventoryItemQueryBuilder : FieldsQueryBuilderBase<InventoryItem, InventoryItemQueryBuilder>
    {
        protected override InventoryItemQueryBuilder Self => this;

        public InventoryItemQueryBuilder() : this("inventoryItem")
        {
        }

        public InventoryItemQueryBuilder(string name) : base(new Query<InventoryItem>(name))
        {
        }

        public InventoryItemQueryBuilder(IQuery<InventoryItem> query) : base(query)
        {
        }

        public InventoryItemQueryBuilder CountryCodeOfOrigin()
        {
            base.InnerQuery.AddField("countryCodeOfOrigin");
            return this;
        }

        public InventoryItemQueryBuilder CountryHarmonizedSystemCodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountryHarmonizedSystemCodeConnectionQueryBuilder> build)
        {
            var query = new Query<CountryHarmonizedSystemCodeConnection>("countryHarmonizedSystemCodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountryHarmonizedSystemCodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountryHarmonizedSystemCodeConnection>(query);
            return this;
        }

        public InventoryItemQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public InventoryItemQueryBuilder DuplicateSkuCount()
        {
            base.InnerQuery.AddField("duplicateSkuCount");
            return this;
        }

        public InventoryItemQueryBuilder HarmonizedSystemCode()
        {
            base.InnerQuery.AddField("harmonizedSystemCode");
            return this;
        }

        public InventoryItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryItemQueryBuilder InventoryHistoryUrl()
        {
            base.InnerQuery.AddField("inventoryHistoryUrl");
            return this;
        }

        public InventoryItemQueryBuilder InventoryLevel(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("inventoryLevel");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public InventoryItemQueryBuilder InventoryLevels(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryLevelConnection>("inventoryLevels");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevelConnection>(query);
            return this;
        }

        public InventoryItemQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public InventoryItemQueryBuilder LocationsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("locationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public InventoryItemQueryBuilder Measurement(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemMeasurementQueryBuilder> build)
        {
            var query = new Query<InventoryItemMeasurement>("measurement");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemMeasurementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItemMeasurement>(query);
            return this;
        }

        public InventoryItemQueryBuilder ProvinceCodeOfOrigin()
        {
            base.InnerQuery.AddField("provinceCodeOfOrigin");
            return this;
        }

        public InventoryItemQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public InventoryItemQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        public InventoryItemQueryBuilder Tracked()
        {
            base.InnerQuery.AddField("tracked");
            return this;
        }

        public InventoryItemQueryBuilder TrackedEditable(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EditablePropertyQueryBuilder> build)
        {
            var query = new Query<EditableProperty>("trackedEditable");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EditablePropertyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EditableProperty>(query);
            return this;
        }

        public InventoryItemQueryBuilder UnitCost(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("unitCost");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public InventoryItemQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public InventoryItemQueryBuilder Variant(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public InventoryItemQueryBuilder Variants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("variants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }
    }
}