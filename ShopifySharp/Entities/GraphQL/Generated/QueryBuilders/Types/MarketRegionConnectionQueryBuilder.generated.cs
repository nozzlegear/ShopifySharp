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
    public sealed class MarketRegionConnectionQueryBuilder : FieldsQueryBuilderBase<MarketRegionConnection, MarketRegionConnectionQueryBuilder>
    {
        protected override MarketRegionConnectionQueryBuilder Self => this;

        public MarketRegionConnectionQueryBuilder() : this("marketRegionConnection")
        {
        }

        public MarketRegionConnectionQueryBuilder(string name) : base(new Query<MarketRegionConnection>(name))
        {
        }

        public MarketRegionConnectionQueryBuilder(IQuery<MarketRegionConnection> query) : base(query)
        {
        }

        public MarketRegionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionEdgeQueryBuilder> build)
        {
            var query = new Query<MarketRegionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketRegionEdge>(query);
            return this;
        }

        public MarketRegionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionQueryBuilder> build)
        {
            var query = new Query<IMarketRegion>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketRegionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMarketRegion>(query);
            return this;
        }

        public MarketRegionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}