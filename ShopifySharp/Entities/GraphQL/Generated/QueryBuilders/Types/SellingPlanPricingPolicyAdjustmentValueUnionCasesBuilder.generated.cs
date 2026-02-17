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
    public sealed class SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder : UnionCasesBuilderBase<SellingPlanPricingPolicyAdjustmentValue, SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder>
    {
        protected override SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder Self => this;

        public SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder(string fieldName = "adjustmentValue") : this(new Query<SellingPlanPricingPolicyAdjustmentValue>(fieldName))
        {
        }

        public SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder(IQuery<SellingPlanPricingPolicyAdjustmentValue> query) : base(query)
        {
        }

        public SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder OnMoneyV2(Action<MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("... on MoneyV2");
            var queryBuilder = new MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder OnSellingPlanPricingPolicyPercentageValue(Action<SellingPlanPricingPolicyPercentageValueQueryBuilder> build)
        {
            var query = new Query<SellingPlanPricingPolicyPercentageValue>("... on SellingPlanPricingPolicyPercentageValue");
            var queryBuilder = new SellingPlanPricingPolicyPercentageValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}