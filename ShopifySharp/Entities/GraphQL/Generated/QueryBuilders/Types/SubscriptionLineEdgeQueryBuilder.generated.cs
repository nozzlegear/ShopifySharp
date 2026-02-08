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
    public sealed class SubscriptionLineEdgeQueryBuilder : FieldsQueryBuilderBase<SubscriptionLineEdge, SubscriptionLineEdgeQueryBuilder>
    {
        protected override SubscriptionLineEdgeQueryBuilder Self => this;

        public SubscriptionLineEdgeQueryBuilder() : this("subscriptionLineEdge")
        {
        }

        public SubscriptionLineEdgeQueryBuilder(string name) : base(new Query<SubscriptionLineEdge>(name))
        {
        }

        public SubscriptionLineEdgeQueryBuilder(IQuery<SubscriptionLineEdge> query) : base(query)
        {
        }

        public SubscriptionLineEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SubscriptionLineEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder> build)
        {
            var query = new Query<SubscriptionLine>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionLine>(query);
            return this;
        }
    }
}