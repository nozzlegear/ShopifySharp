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
    public sealed class SellingPlanPricingPolicyQueryBuilder : FieldsQueryBuilderBase<SellingPlanPricingPolicy, SellingPlanPricingPolicyQueryBuilder>
    {
        protected override SellingPlanPricingPolicyQueryBuilder Self => this;

        public SellingPlanPricingPolicyQueryBuilder() : this("sellingPlanPricingPolicy")
        {
        }

        public SellingPlanPricingPolicyQueryBuilder(string name) : base(new Query<SellingPlanPricingPolicy>(name))
        {
        }

        public SellingPlanPricingPolicyQueryBuilder(IQuery<SellingPlanPricingPolicy> query) : base(query)
        {
        }

        public SellingPlanPricingPolicyQueryBuilder SellingPlanPricingPolicy(Action<SellingPlanPricingPolicyUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanPricingPolicy>("sellingPlanPricingPolicy");
            var unionBuilder = new SellingPlanPricingPolicyUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}