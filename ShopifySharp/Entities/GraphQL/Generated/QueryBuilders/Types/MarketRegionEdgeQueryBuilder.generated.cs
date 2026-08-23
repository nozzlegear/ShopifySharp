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

        public MarketRegionEdgeQueryBuilder Node(Action<MarketRegionInterfaceCasesBuilder> build)
        {
            var query = new Query<IMarketRegion>("node");
            var unionBuilder = new MarketRegionInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}