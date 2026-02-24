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
    public sealed class QueryRootInventoryItemQueryBuilder : FieldsQueryBuilderBase<InventoryItem, QueryRootInventoryItemQueryBuilder>, IHasArguments<QueryRootInventoryItemArgumentsBuilder>
    {
        public QueryRootInventoryItemArgumentsBuilder Arguments { get; }
        protected override QueryRootInventoryItemQueryBuilder Self => this;

        public QueryRootInventoryItemQueryBuilder(string name) : base(new Query<InventoryItem>(name))
        {
            Arguments = new QueryRootInventoryItemArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootInventoryItemQueryBuilder(IQuery<InventoryItem> query) : base(query)
        {
            Arguments = new QueryRootInventoryItemArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootInventoryItemQueryBuilder SetArguments(Action<QueryRootInventoryItemArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootInventoryItemQueryBuilder CountryCodeOfOrigin()
        {
            base.InnerQuery.AddField("countryCodeOfOrigin");
            return this;
        }

        public QueryRootInventoryItemQueryBuilder CountryHarmonizedSystemCodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeConnectionQueryBuilder> build)
        {
            var query = new Query<CountryHarmonizedSystemCodeConnection>("countryHarmonizedSystemCodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountryHarmonizedSystemCodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CountryHarmonizedSystemCodeConnection>(query);
            return this;
        }

        public QueryRootInventoryItemQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootInventoryItemQueryBuilder DuplicateSkuCount()
        {
            base.InnerQuery.AddField("duplicateSkuCount");
            return this;
        }

        public QueryRootInventoryItemQueryBuilder HarmonizedSystemCode()
        {
            base.InnerQuery.AddField("harmonizedSystemCode");
            return this;
        }

        public QueryRootInventoryItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootInventoryItemQueryBuilder InventoryHistoryUrl()
        {
            base.InnerQuery.AddField("inventoryHistoryUrl");
            return this;
        }

        public QueryRootInventoryItemQueryBuilder InventoryLevel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("inventoryLevel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public QueryRootInventoryItemQueryBuilder InventoryLevels(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryLevelConnection>("inventoryLevels");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevelConnection>(query);
            return this;
        }

        public QueryRootInventoryItemQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public QueryRootInventoryItemQueryBuilder LocationsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("locationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootInventoryItemQueryBuilder Measurement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemMeasurementQueryBuilder> build)
        {
            var query = new Query<InventoryItemMeasurement>("measurement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemMeasurementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItemMeasurement>(query);
            return this;
        }

        public QueryRootInventoryItemQueryBuilder ProvinceCodeOfOrigin()
        {
            base.InnerQuery.AddField("provinceCodeOfOrigin");
            return this;
        }

        public QueryRootInventoryItemQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public QueryRootInventoryItemQueryBuilder Sku()
        {
            base.InnerQuery.AddField("sku");
            return this;
        }

        public QueryRootInventoryItemQueryBuilder Tracked()
        {
            base.InnerQuery.AddField("tracked");
            return this;
        }

        public QueryRootInventoryItemQueryBuilder TrackedEditable(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EditablePropertyQueryBuilder> build)
        {
            var query = new Query<EditableProperty>("trackedEditable");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EditablePropertyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EditableProperty>(query);
            return this;
        }

        public QueryRootInventoryItemQueryBuilder UnitCost(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("unitCost");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootInventoryItemQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }

        public QueryRootInventoryItemQueryBuilder Variant(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("variant");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }
    }
}