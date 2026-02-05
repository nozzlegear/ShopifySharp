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
    public sealed class SellingPlanRecurringBillingPolicyQueryBuilder : FieldsQueryBuilderBase<SellingPlanRecurringBillingPolicy, SellingPlanRecurringBillingPolicyQueryBuilder>
    {
        protected override SellingPlanRecurringBillingPolicyQueryBuilder Self => this;

        public SellingPlanRecurringBillingPolicyQueryBuilder() : this("sellingPlanRecurringBillingPolicy")
        {
        }

        public SellingPlanRecurringBillingPolicyQueryBuilder(string name) : base(new Query<SellingPlanRecurringBillingPolicy>(name))
        {
        }

        public SellingPlanRecurringBillingPolicyQueryBuilder(IQuery<SellingPlanRecurringBillingPolicy> query) : base(query)
        {
        }

        public SellingPlanRecurringBillingPolicyQueryBuilder Anchors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanAnchorQueryBuilder> build)
        {
            var query = new Query<SellingPlanAnchor>("anchors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanAnchorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanAnchor>(query);
            return this;
        }

        public SellingPlanRecurringBillingPolicyQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public SellingPlanRecurringBillingPolicyQueryBuilder Interval()
        {
            base.InnerQuery.AddField("interval");
            return this;
        }

        public SellingPlanRecurringBillingPolicyQueryBuilder IntervalCount()
        {
            base.InnerQuery.AddField("intervalCount");
            return this;
        }

        public SellingPlanRecurringBillingPolicyQueryBuilder MaxCycles()
        {
            base.InnerQuery.AddField("maxCycles");
            return this;
        }

        public SellingPlanRecurringBillingPolicyQueryBuilder MinCycles()
        {
            base.InnerQuery.AddField("minCycles");
            return this;
        }
    }
}