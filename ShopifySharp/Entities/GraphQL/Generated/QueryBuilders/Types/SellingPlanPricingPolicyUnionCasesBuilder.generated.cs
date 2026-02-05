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
    public sealed class SellingPlanPricingPolicyUnionCasesBuilder : UnionCasesBuilderBase<SellingPlanPricingPolicy, SellingPlanPricingPolicyUnionCasesBuilder>
    {
        protected override SellingPlanPricingPolicyUnionCasesBuilder Self => this;

        public SellingPlanPricingPolicyUnionCasesBuilder(string fieldName = "sellingPlanPricingPolicy") : this(new Query<SellingPlanPricingPolicy>(fieldName))
        {
        }

        public SellingPlanPricingPolicyUnionCasesBuilder(IQuery<SellingPlanPricingPolicy> query) : base(query)
        {
        }

        public SellingPlanPricingPolicyUnionCasesBuilder OnSellingPlanFixedPricingPolicy(Action<SellingPlanFixedPricingPolicyQueryBuilder> build)
        {
            var query = new Query<SellingPlanFixedPricingPolicy>("... on SellingPlanFixedPricingPolicy");
            var queryBuilder = new SellingPlanFixedPricingPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SellingPlanPricingPolicyUnionCasesBuilder OnSellingPlanRecurringPricingPolicy(Action<SellingPlanRecurringPricingPolicyQueryBuilder> build)
        {
            var query = new Query<SellingPlanRecurringPricingPolicy>("... on SellingPlanRecurringPricingPolicy");
            var queryBuilder = new SellingPlanRecurringPricingPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}