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
    [Obsolete("This `market_by_geography` field will be removed in a future version of the API.")]
    public sealed class MarketByGeographyOperationQueryBuilder : FieldsQueryBuilderBase<Market, MarketByGeographyOperationQueryBuilder>, IGraphOperationQueryBuilder<Market>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MarketByGeographyArgumentsBuilder Arguments { get; }
        protected override MarketByGeographyOperationQueryBuilder Self => this;

        public MarketByGeographyOperationQueryBuilder() : this("marketByGeography")
        {
        }

        public MarketByGeographyOperationQueryBuilder(string name) : base(new Query<Market>(name))
        {
            Arguments = new MarketByGeographyArgumentsBuilder(base.InnerQuery);
        }

        public MarketByGeographyOperationQueryBuilder(IQuery<Market> query) : base(query)
        {
            Arguments = new MarketByGeographyArgumentsBuilder(base.InnerQuery);
        }

        public MarketByGeographyOperationQueryBuilder AssignedCustomization()
        {
            base.InnerQuery.AddField("assignedCustomization");
            return this;
        }

        public MarketByGeographyOperationQueryBuilder Catalogs(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogConnectionQueryBuilder> build)
        {
            var query = new Query<MarketCatalogConnection>("catalogs");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketCatalogConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCatalogConnection>(query);
            return this;
        }

        public MarketByGeographyOperationQueryBuilder CatalogsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("catalogsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public MarketByGeographyOperationQueryBuilder Conditions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketConditionsQueryBuilder> build)
        {
            var query = new Query<MarketConditions>("conditions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketConditionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketConditions>(query);
            return this;
        }

        public MarketByGeographyOperationQueryBuilder CurrencySettings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketCurrencySettingsQueryBuilder> build)
        {
            var query = new Query<MarketCurrencySettings>("currencySettings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketCurrencySettingsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketCurrencySettings>(query);
            return this;
        }

        [Obsolete("Use `status` instead.")]
        public MarketByGeographyOperationQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }

        public MarketByGeographyOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public MarketByGeographyOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MarketByGeographyOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public MarketByGeographyOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public MarketByGeographyOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public MarketByGeographyOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MarketByGeographyOperationQueryBuilder PriceInclusions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketPriceInclusionsQueryBuilder> build)
        {
            var query = new Query<MarketPriceInclusions>("priceInclusions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketPriceInclusionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketPriceInclusions>(query);
            return this;
        }

        public MarketByGeographyOperationQueryBuilder PriceList(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder> build)
        {
            var query = new Query<PriceList>("priceList");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PriceListQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PriceList>(query);
            return this;
        }

        [Obsolete("This field is deprecated and will be removed in the future.")]
        public MarketByGeographyOperationQueryBuilder Primary()
        {
            base.InnerQuery.AddField("primary");
            return this;
        }

        public MarketByGeographyOperationQueryBuilder Regions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionConnectionQueryBuilder> build)
        {
            var query = new Query<MarketRegionConnection>("regions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketRegionConnection>(query);
            return this;
        }

        public MarketByGeographyOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public MarketByGeographyOperationQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }

        public MarketByGeographyOperationQueryBuilder WebPresence(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder> build)
        {
            var query = new Query<MarketWebPresence>("webPresence");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresence>(query);
            return this;
        }

        public MarketByGeographyOperationQueryBuilder WebPresences(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceConnectionQueryBuilder> build)
        {
            var query = new Query<MarketWebPresenceConnection>("webPresences");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketWebPresenceConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketWebPresenceConnection>(query);
            return this;
        }
    }
}