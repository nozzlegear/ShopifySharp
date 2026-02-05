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
    public sealed class SubscriptionBillingAttemptEdgeQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptEdge, SubscriptionBillingAttemptEdgeQueryBuilder>
    {
        protected override SubscriptionBillingAttemptEdgeQueryBuilder Self => this;

        public SubscriptionBillingAttemptEdgeQueryBuilder() : this("subscriptionBillingAttemptEdge")
        {
        }

        public SubscriptionBillingAttemptEdgeQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptEdge>(name))
        {
        }

        public SubscriptionBillingAttemptEdgeQueryBuilder(IQuery<SubscriptionBillingAttemptEdge> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SubscriptionBillingAttemptEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttempt>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttempt>(query);
            return this;
        }
    }
}