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
    public sealed class SellingPlanBillingPolicyUnionCasesBuilder : UnionCasesBuilderBase<SellingPlanBillingPolicy, SellingPlanBillingPolicyUnionCasesBuilder>
    {
        protected override SellingPlanBillingPolicyUnionCasesBuilder Self => this;

        public SellingPlanBillingPolicyUnionCasesBuilder(string fieldName = "sellingPlanBillingPolicy") : this(new Query<SellingPlanBillingPolicy>(fieldName))
        {
        }

        public SellingPlanBillingPolicyUnionCasesBuilder(IQuery<SellingPlanBillingPolicy> query) : base(query)
        {
        }

        public SellingPlanBillingPolicyUnionCasesBuilder OnSellingPlanFixedBillingPolicy(Action<SellingPlanFixedBillingPolicyQueryBuilder> build)
        {
            var query = new Query<SellingPlanFixedBillingPolicy>("... on SellingPlanFixedBillingPolicy");
            var queryBuilder = new SellingPlanFixedBillingPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SellingPlanBillingPolicyUnionCasesBuilder OnSellingPlanRecurringBillingPolicy(Action<SellingPlanRecurringBillingPolicyQueryBuilder> build)
        {
            var query = new Query<SellingPlanRecurringBillingPolicy>("... on SellingPlanRecurringBillingPolicy");
            var queryBuilder = new SellingPlanRecurringBillingPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}