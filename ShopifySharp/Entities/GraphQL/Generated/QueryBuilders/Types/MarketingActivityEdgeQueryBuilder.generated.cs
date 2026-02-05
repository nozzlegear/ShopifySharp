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

        public MarketingActivityEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }
    }
}