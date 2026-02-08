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
    public sealed class SellingPlanPricingPolicyBaseQueryBuilder : FieldsQueryBuilderBase<ISellingPlanPricingPolicyBase, SellingPlanPricingPolicyBaseQueryBuilder>
    {
        protected override SellingPlanPricingPolicyBaseQueryBuilder Self => this;

        public SellingPlanPricingPolicyBaseQueryBuilder() : this("sellingPlanPricingPolicyBase")
        {
        }

        public SellingPlanPricingPolicyBaseQueryBuilder(string name) : base(new Query<ISellingPlanPricingPolicyBase>(name))
        {
        }

        public SellingPlanPricingPolicyBaseQueryBuilder(IQuery<ISellingPlanPricingPolicyBase> query) : base(query)
        {
        }

        public SellingPlanPricingPolicyBaseQueryBuilder AdjustmentType()
        {
            base.InnerQuery.AddField("adjustmentType");
            return this;
        }

        public SellingPlanPricingPolicyBaseQueryBuilder AdjustmentValue(Action<SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanPricingPolicyAdjustmentValue>("adjustmentValue");
            var unionBuilder = new SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}