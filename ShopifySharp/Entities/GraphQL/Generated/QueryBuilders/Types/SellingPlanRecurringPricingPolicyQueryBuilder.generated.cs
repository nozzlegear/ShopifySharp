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
    public sealed class SellingPlanRecurringPricingPolicyQueryBuilder : FieldsQueryBuilderBase<SellingPlanRecurringPricingPolicy, SellingPlanRecurringPricingPolicyQueryBuilder>
    {
        protected override SellingPlanRecurringPricingPolicyQueryBuilder Self => this;

        public SellingPlanRecurringPricingPolicyQueryBuilder() : this("sellingPlanRecurringPricingPolicy")
        {
        }

        public SellingPlanRecurringPricingPolicyQueryBuilder(string name) : base(new Query<SellingPlanRecurringPricingPolicy>(name))
        {
        }

        public SellingPlanRecurringPricingPolicyQueryBuilder(IQuery<SellingPlanRecurringPricingPolicy> query) : base(query)
        {
        }

        public SellingPlanRecurringPricingPolicyQueryBuilder AdjustmentType()
        {
            base.InnerQuery.AddField("adjustmentType");
            return this;
        }

        public SellingPlanRecurringPricingPolicyQueryBuilder AfterCycle()
        {
            base.InnerQuery.AddField("afterCycle");
            return this;
        }

        public SellingPlanRecurringPricingPolicyQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public SellingPlanRecurringPricingPolicyQueryBuilder AdjustmentValue(Action<SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanPricingPolicyAdjustmentValue>("adjustmentValue");
            var unionBuilder = new SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}