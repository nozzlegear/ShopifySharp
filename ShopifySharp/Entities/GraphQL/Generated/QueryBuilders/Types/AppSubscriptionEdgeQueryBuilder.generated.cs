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
    public sealed class AppSubscriptionEdgeQueryBuilder : FieldsQueryBuilderBase<AppSubscriptionEdge, AppSubscriptionEdgeQueryBuilder>
    {
        protected override AppSubscriptionEdgeQueryBuilder Self => this;

        public AppSubscriptionEdgeQueryBuilder() : this("appSubscriptionEdge")
        {
        }

        public AppSubscriptionEdgeQueryBuilder(string name) : base(new Query<AppSubscriptionEdge>(name))
        {
        }

        public AppSubscriptionEdgeQueryBuilder(IQuery<AppSubscriptionEdge> query) : base(query)
        {
        }

        public AppSubscriptionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public AppSubscriptionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder> build)
        {
            var query = new Query<AppSubscription>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppSubscription>(query);
            return this;
        }
    }
}