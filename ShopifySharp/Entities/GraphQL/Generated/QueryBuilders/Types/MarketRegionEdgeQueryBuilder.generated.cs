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
    public sealed class MarketRegionEdgeQueryBuilder : FieldsQueryBuilderBase<MarketRegionEdge, MarketRegionEdgeQueryBuilder>
    {
        protected override MarketRegionEdgeQueryBuilder Self => this;

        public MarketRegionEdgeQueryBuilder() : this("marketRegionEdge")
        {
        }

        public MarketRegionEdgeQueryBuilder(string name) : base(new Query<MarketRegionEdge>(name))
        {
        }

        public MarketRegionEdgeQueryBuilder(IQuery<MarketRegionEdge> query) : base(query)
        {
        }

        public MarketRegionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MarketRegionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketRegionQueryBuilder> build)
        {
            var query = new Query<IMarketRegion>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketRegionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IMarketRegion>(query);
            return this;
        }
    }
}