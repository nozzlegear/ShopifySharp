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
    public sealed class MarketEdgeQueryBuilder : FieldsQueryBuilderBase<MarketEdge, MarketEdgeQueryBuilder>
    {
        protected override MarketEdgeQueryBuilder Self => this;

        public MarketEdgeQueryBuilder() : this("marketEdge")
        {
        }

        public MarketEdgeQueryBuilder(string name) : base(new Query<MarketEdge>(name))
        {
        }

        public MarketEdgeQueryBuilder(IQuery<MarketEdge> query) : base(query)
        {
        }

        public MarketEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MarketEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }
    }
}