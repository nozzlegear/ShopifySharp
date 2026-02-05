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
    public sealed class SellingPlanPricingPolicyPercentageValueQueryBuilder : FieldsQueryBuilderBase<SellingPlanPricingPolicyPercentageValue, SellingPlanPricingPolicyPercentageValueQueryBuilder>
    {
        protected override SellingPlanPricingPolicyPercentageValueQueryBuilder Self => this;

        public SellingPlanPricingPolicyPercentageValueQueryBuilder() : this("sellingPlanPricingPolicyPercentageValue")
        {
        }

        public SellingPlanPricingPolicyPercentageValueQueryBuilder(string name) : base(new Query<SellingPlanPricingPolicyPercentageValue>(name))
        {
        }

        public SellingPlanPricingPolicyPercentageValueQueryBuilder(IQuery<SellingPlanPricingPolicyPercentageValue> query) : base(query)
        {
        }

        public SellingPlanPricingPolicyPercentageValueQueryBuilder Percentage()
        {
            base.InnerQuery.AddField("percentage");
            return this;
        }
    }
}