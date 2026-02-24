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
    public sealed class MarketCatalogMarketsQueryBuilder : FieldsQueryBuilderBase<MarketConnection, MarketCatalogMarketsQueryBuilder>, IHasArguments<MarketCatalogMarketsArgumentsBuilder>
    {
        public MarketCatalogMarketsArgumentsBuilder Arguments { get; }
        protected override MarketCatalogMarketsQueryBuilder Self => this;

        public MarketCatalogMarketsQueryBuilder(string name) : base(new Query<MarketConnection>(name))
        {
            Arguments = new MarketCatalogMarketsArgumentsBuilder(base.InnerQuery);
        }

        public MarketCatalogMarketsQueryBuilder(IQuery<MarketConnection> query) : base(query)
        {
            Arguments = new MarketCatalogMarketsArgumentsBuilder(base.InnerQuery);
        }

        public MarketCatalogMarketsQueryBuilder SetArguments(Action<MarketCatalogMarketsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MarketCatalogMarketsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketEdgeQueryBuilder> build)
        {
            var query = new Query<MarketEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketEdge>(query);
            return this;
        }

        public MarketCatalogMarketsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public MarketCatalogMarketsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}