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
    public sealed class SellingPlanFixedPricingPolicyQueryBuilder : FieldsQueryBuilderBase<SellingPlanFixedPricingPolicy, SellingPlanFixedPricingPolicyQueryBuilder>
    {
        protected override SellingPlanFixedPricingPolicyQueryBuilder Self => this;

        public SellingPlanFixedPricingPolicyQueryBuilder() : this("sellingPlanFixedPricingPolicy")
        {
        }

        public SellingPlanFixedPricingPolicyQueryBuilder(string name) : base(new Query<SellingPlanFixedPricingPolicy>(name))
        {
        }

        public SellingPlanFixedPricingPolicyQueryBuilder(IQuery<SellingPlanFixedPricingPolicy> query) : base(query)
        {
        }

        public SellingPlanFixedPricingPolicyQueryBuilder AdjustmentType()
        {
            base.InnerQuery.AddField("adjustmentType");
            return this;
        }

        public SellingPlanFixedPricingPolicyQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public SellingPlanFixedPricingPolicyQueryBuilder AdjustmentValue(Action<SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanPricingPolicyAdjustmentValue>("adjustmentValue");
            var unionBuilder = new SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}