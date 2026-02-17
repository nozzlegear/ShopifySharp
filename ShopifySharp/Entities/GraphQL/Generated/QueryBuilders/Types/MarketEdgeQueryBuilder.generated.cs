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

        public MarketEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }
    }
}