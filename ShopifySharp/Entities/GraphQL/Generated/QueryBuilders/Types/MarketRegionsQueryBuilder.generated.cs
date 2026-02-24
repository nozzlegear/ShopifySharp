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
    public sealed class MarketRegionsQueryBuilder : FieldsQueryBuilderBase<MarketRegionConnection, MarketRegionsQueryBuilder>, IHasArguments<MarketRegionsArgumentsBuilder>
    {
        public MarketRegionsArgumentsBuilder Arguments { get; }
        protected override MarketRegionsQueryBuilder Self => this;

        public MarketRegionsQueryBuilder(string name) : base(new Query<MarketRegionConnection>(name))
        {
            Arguments = new MarketRegionsArgumentsBuilder(base.InnerQuery);
        }

        public MarketRegionsQueryBuilder(IQuery<MarketRegionConnection> query) : base(query)
        {
            Arguments = new MarketRegionsArgumentsBuilder(base.InnerQuery);
        }

        public MarketRegionsQueryBuilder SetArguments(Action<MarketRegionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MarketRegionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionEdgeQueryBuilder> build)
        {
            var query = new Query<MarketRegionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketRegionEdge>(query);
            return this;
        }

        public MarketRegionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionQueryBuilder> build)
        {
            var query = new Query<IMarketRegion>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMarketRegion>(query);
            return this;
        }

        public MarketRegionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}