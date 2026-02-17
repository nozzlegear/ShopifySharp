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
    public sealed class SubscriptionBillingCycleEdgeQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingCycleEdge, SubscriptionBillingCycleEdgeQueryBuilder>
    {
        protected override SubscriptionBillingCycleEdgeQueryBuilder Self => this;

        public SubscriptionBillingCycleEdgeQueryBuilder() : this("subscriptionBillingCycleEdge")
        {
        }

        public SubscriptionBillingCycleEdgeQueryBuilder(string name) : base(new Query<SubscriptionBillingCycleEdge>(name))
        {
        }

        public SubscriptionBillingCycleEdgeQueryBuilder(IQuery<SubscriptionBillingCycleEdge> query) : base(query)
        {
        }

        public SubscriptionBillingCycleEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SubscriptionBillingCycleEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingCycle>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingCycleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingCycle>(query);
            return this;
        }
    }
}