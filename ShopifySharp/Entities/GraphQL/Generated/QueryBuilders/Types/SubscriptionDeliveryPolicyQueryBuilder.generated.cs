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
    public sealed class SubscriptionDeliveryPolicyQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryPolicy, SubscriptionDeliveryPolicyQueryBuilder>
    {
        protected override SubscriptionDeliveryPolicyQueryBuilder Self => this;

        public SubscriptionDeliveryPolicyQueryBuilder() : this("subscriptionDeliveryPolicy")
        {
        }

        public SubscriptionDeliveryPolicyQueryBuilder(string name) : base(new Query<SubscriptionDeliveryPolicy>(name))
        {
        }

        public SubscriptionDeliveryPolicyQueryBuilder(IQuery<SubscriptionDeliveryPolicy> query) : base(query)
        {
        }

        public SubscriptionDeliveryPolicyQueryBuilder Anchors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanAnchorQueryBuilder> build)
        {
            var query = new Query<SellingPlanAnchor>("anchors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanAnchorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanAnchor>(query);
            return this;
        }

        public SubscriptionDeliveryPolicyQueryBuilder Interval()
        {
            base.InnerQuery.AddField("interval");
            return this;
        }

        public SubscriptionDeliveryPolicyQueryBuilder IntervalCount()
        {
            base.InnerQuery.AddField("intervalCount");
            return this;
        }
    }
}