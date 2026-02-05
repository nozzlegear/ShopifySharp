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
    public sealed class SellingPlanPricingPolicyAdjustmentValueQueryBuilder : FieldsQueryBuilderBase<SellingPlanPricingPolicyAdjustmentValue, SellingPlanPricingPolicyAdjustmentValueQueryBuilder>
    {
        protected override SellingPlanPricingPolicyAdjustmentValueQueryBuilder Self => this;

        public SellingPlanPricingPolicyAdjustmentValueQueryBuilder() : this("sellingPlanPricingPolicyAdjustmentValue")
        {
        }

        public SellingPlanPricingPolicyAdjustmentValueQueryBuilder(string name) : base(new Query<SellingPlanPricingPolicyAdjustmentValue>(name))
        {
        }

        public SellingPlanPricingPolicyAdjustmentValueQueryBuilder(IQuery<SellingPlanPricingPolicyAdjustmentValue> query) : base(query)
        {
        }

        public SellingPlanPricingPolicyAdjustmentValueQueryBuilder SellingPlanPricingPolicyAdjustmentValue(Action<SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanPricingPolicyAdjustmentValue>("sellingPlanPricingPolicyAdjustmentValue");
            var unionBuilder = new SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}