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
    public sealed class SellingPlanRecurringDeliveryPolicyQueryBuilder : FieldsQueryBuilderBase<SellingPlanRecurringDeliveryPolicy, SellingPlanRecurringDeliveryPolicyQueryBuilder>
    {
        protected override SellingPlanRecurringDeliveryPolicyQueryBuilder Self => this;

        public SellingPlanRecurringDeliveryPolicyQueryBuilder() : this("sellingPlanRecurringDeliveryPolicy")
        {
        }

        public SellingPlanRecurringDeliveryPolicyQueryBuilder(string name) : base(new Query<SellingPlanRecurringDeliveryPolicy>(name))
        {
        }

        public SellingPlanRecurringDeliveryPolicyQueryBuilder(IQuery<SellingPlanRecurringDeliveryPolicy> query) : base(query)
        {
        }

        public SellingPlanRecurringDeliveryPolicyQueryBuilder Anchors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanAnchorQueryBuilder> build)
        {
            var query = new Query<SellingPlanAnchor>("anchors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanAnchorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanAnchor>(query);
            return this;
        }

        public SellingPlanRecurringDeliveryPolicyQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public SellingPlanRecurringDeliveryPolicyQueryBuilder Cutoff()
        {
            base.InnerQuery.AddField("cutoff");
            return this;
        }

        public SellingPlanRecurringDeliveryPolicyQueryBuilder Intent()
        {
            base.InnerQuery.AddField("intent");
            return this;
        }

        public SellingPlanRecurringDeliveryPolicyQueryBuilder Interval()
        {
            base.InnerQuery.AddField("interval");
            return this;
        }

        public SellingPlanRecurringDeliveryPolicyQueryBuilder IntervalCount()
        {
            base.InnerQuery.AddField("intervalCount");
            return this;
        }

        public SellingPlanRecurringDeliveryPolicyQueryBuilder PreAnchorBehavior()
        {
            base.InnerQuery.AddField("preAnchorBehavior");
            return this;
        }
    }
}