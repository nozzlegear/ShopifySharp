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
    public sealed class SubscriptionBillingPolicyQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingPolicy, SubscriptionBillingPolicyQueryBuilder>
    {
        protected override SubscriptionBillingPolicyQueryBuilder Self => this;

        public SubscriptionBillingPolicyQueryBuilder() : this("subscriptionBillingPolicy")
        {
        }

        public SubscriptionBillingPolicyQueryBuilder(string name) : base(new Query<SubscriptionBillingPolicy>(name))
        {
        }

        public SubscriptionBillingPolicyQueryBuilder(IQuery<SubscriptionBillingPolicy> query) : base(query)
        {
        }

        public SubscriptionBillingPolicyQueryBuilder Anchors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanAnchorQueryBuilder> build)
        {
            var query = new Query<SellingPlanAnchor>("anchors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanAnchorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanAnchor>(query);
            return this;
        }

        public SubscriptionBillingPolicyQueryBuilder Interval()
        {
            base.InnerQuery.AddField("interval");
            return this;
        }

        public SubscriptionBillingPolicyQueryBuilder IntervalCount()
        {
            base.InnerQuery.AddField("intervalCount");
            return this;
        }

        public SubscriptionBillingPolicyQueryBuilder MaxCycles()
        {
            base.InnerQuery.AddField("maxCycles");
            return this;
        }

        public SubscriptionBillingPolicyQueryBuilder MinCycles()
        {
            base.InnerQuery.AddField("minCycles");
            return this;
        }
    }
}