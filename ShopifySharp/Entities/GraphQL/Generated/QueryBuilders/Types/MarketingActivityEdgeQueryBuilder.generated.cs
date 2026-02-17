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
    public sealed class MarketingActivityEdgeQueryBuilder : FieldsQueryBuilderBase<MarketingActivityEdge, MarketingActivityEdgeQueryBuilder>
    {
        protected override MarketingActivityEdgeQueryBuilder Self => this;

        public MarketingActivityEdgeQueryBuilder() : this("marketingActivityEdge")
        {
        }

        public MarketingActivityEdgeQueryBuilder(string name) : base(new Query<MarketingActivityEdge>(name))
        {
        }

        public MarketingActivityEdgeQueryBuilder(IQuery<MarketingActivityEdge> query) : base(query)
        {
        }

        public MarketingActivityEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MarketingActivityEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }
    }
}