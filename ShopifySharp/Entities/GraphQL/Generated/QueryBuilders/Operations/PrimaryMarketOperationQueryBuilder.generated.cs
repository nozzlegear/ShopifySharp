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
    [Obsolete("Use `backupRegion` instead.")]
    public sealed class PrimaryMarketOperationQueryBuilder : FieldsQueryBuilderBase<Market, PrimaryMarketOperationQueryBuilder>, IGraphOperationQueryBuilder<Market>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override PrimaryMarketOperationQueryBuilder Self => this;

        public PrimaryMarketOperationQueryBuilder() : this("primaryMarket")
        {
        }

        public PrimaryMarketOperationQueryBuilder(string name) : base(new Query<Market>(name))
        {
        }

        public PrimaryMarketOperationQueryBuilder(IQuery<Market> query) : base(query)
        {
        }

        public PrimaryMarketOperationQueryBuilder AssignedCustomization()
        {
            base.InnerQuery.AddField("assignedCustomization");
            return this;
        }

        public PrimaryMarketOperationQueryBuilder Catalogs(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogConnectionQueryBuilder> build)
        {
            var query = new Query<MarketCatalogConnection>("catalogs");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCatalogConnection>(query);
            return this;
        }

        public PrimaryMarketOperationQueryBuilder CatalogsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("catalogsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public PrimaryMarketOperationQueryBuilder Conditions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketConditionsQueryBuilder> build)
        {
            var query = new Query<MarketConditions>("conditions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketConditionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketConditions>(query);
            return this;
        }

        public PrimaryMarketOperationQueryBuilder CurrencySettings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketCurrencySettingsQueryBuilder> build)
        {
            var query = new Query<MarketCurrencySettings>("currencySettings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketCurrencySettingsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCurrencySettings>(query);
            return this;
        }

        [Obsolete("Use `status` instead.")]
        public PrimaryMarketOperationQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }

        public PrimaryMarketOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public PrimaryMarketOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PrimaryMarketOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public PrimaryMarketOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public PrimaryMarketOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public PrimaryMarketOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public PrimaryMarketOperationQueryBuilder PriceInclusions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketPriceInclusionsQueryBuilder> build)
        {
            var query = new Query<MarketPriceInclusions>("priceInclusions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketPriceInclusionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketPriceInclusions>(query);
            return this;
        }

        public PrimaryMarketOperationQueryBuilder PriceList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        [Obsolete("This field is deprecated and will be removed in the future.")]
        public PrimaryMarketOperationQueryBuilder Primary()
        {
            base.InnerQuery.AddField("primary");
            return this;
        }

        public PrimaryMarketOperationQueryBuilder Regions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionConnectionQueryBuilder> build)
        {
            var query = new Query<MarketRegionConnection>("regions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketRegionConnection>(query);
            return this;
        }

        public PrimaryMarketOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public PrimaryMarketOperationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public PrimaryMarketOperationQueryBuilder WebPresence(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("webPresence");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public PrimaryMarketOperationQueryBuilder WebPresences(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceConnectionQueryBuilder> build)
        {
            var query = new Query<MarketWebPresenceConnection>("webPresences");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresenceConnection>(query);
            return this;
        }
    }
}