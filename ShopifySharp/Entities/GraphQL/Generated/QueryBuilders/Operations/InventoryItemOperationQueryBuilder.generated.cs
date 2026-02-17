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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class InventoryItemOperationQueryBuilder : FieldsQueryBuilderBase<InventoryItem, InventoryItemOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryItem>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public InventoryItemArgumentsBuilder Arguments { get; }
        protected override InventoryItemOperationQueryBuilder Self => this;

        public InventoryItemOperationQueryBuilder() : this("inventoryItem")
        {
        }

        public InventoryItemOperationQueryBuilder(string name) : base(new Query<InventoryItem>(name))
        {
            Arguments = new InventoryItemArgumentsBuilder(base.InnerQuery);
        }

        public InventoryItemOperationQueryBuilder(IQuery<InventoryItem> query) : base(query)
        {
            Arguments = new InventoryItemArgumentsBuilder(base.InnerQuery);
        }

        public InventoryItemOperationQueryBuilder CountryCodeOfOrigin()
        {
            base.InnerQuery.AddField("countryCodeOfOrigin");
            return this;
        }

        public InventoryItemOperationQueryBuilder CountryHarmonizedSystemCodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeConnectionQueryBuilder> build)
        {
            var query = new Query<CountryHarmonizedSystemCodeConnection>("countryHarmonizedSystemCodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountryHarmonizedSystemCodeConnection>(query);
            return this;
        }

        public InventoryItemOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public InventoryItemOperationQueryBuilder DuplicateSkuCount()
        {
            base.InnerQuery.AddField("duplicateSkuCount");
            return this;
        }

        public InventoryItemOperationQueryBuilder HarmonizedSystemCode()
        {
            base.InnerQuery.AddField("harmonizedSystemCode");
            return this;
        }

        public InventoryItemOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryItemOperationQueryBuilder InventoryHistoryUrl()
        {
            base.InnerQuery.AddField("inventoryHistoryUrl");
            return this;
        }

        public InventoryItemOperationQueryBuilder InventoryLevel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("inventoryLevel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public InventoryItemOperationQueryBuilder InventoryLevels(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryLevelConnection>("inventoryLevels");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevelConnection>(query);
            return this;
        }

        public InventoryItemOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public InventoryItemOperationQueryBuilder LocationsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("locationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public InventoryItemOperationQueryBuilder Measurement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemMeasurementQueryBuilder> build)
        {
            var query = new Query<InventoryItemMeasurement>("measurement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemMeasurementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItemMeasurement>(query);
            return this;
        }

        public InventoryItemOperationQueryBuilder ProvinceCodeOfOrigin()
        {
            base.InnerQuery.AddField("provinceCodeOfOrigin");
            return this;
        }

        public InventoryItemOperationQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public InventoryItemOperationQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        public InventoryItemOperationQueryBuilder Tracked()
        {
            base.InnerQuery.AddField("tracked");
            return this;
        }

        public InventoryItemOperationQueryBuilder TrackedEditable(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EditablePropertyQueryBuilder> build)
        {
            var query = new Query<EditableProperty>("trackedEditable");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EditablePropertyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EditableProperty>(query);
            return this;
        }

        public InventoryItemOperationQueryBuilder UnitCost(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("unitCost");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public InventoryItemOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public InventoryItemOperationQueryBuilder Variant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public InventoryItemOperationQueryBuilder Variants(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder> build)
        {
            var query = new Query<ProductVariantConnection>("variants");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariantConnection>(query);
            return this;
        }
    }
}