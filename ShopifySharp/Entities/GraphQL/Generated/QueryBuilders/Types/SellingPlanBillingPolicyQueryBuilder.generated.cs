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
    public sealed class SellingPlanBillingPolicyQueryBuilder : FieldsQueryBuilderBase<SellingPlanBillingPolicy, SellingPlanBillingPolicyQueryBuilder>
    {
        protected override SellingPlanBillingPolicyQueryBuilder Self => this;

        public SellingPlanBillingPolicyQueryBuilder() : this("sellingPlanBillingPolicy")
        {
        }

        public SellingPlanBillingPolicyQueryBuilder(string name) : base(new Query<SellingPlanBillingPolicy>(name))
        {
        }

        public SellingPlanBillingPolicyQueryBuilder(IQuery<SellingPlanBillingPolicy> query) : base(query)
        {
        }

        public SellingPlanBillingPolicyQueryBuilder SellingPlanBillingPolicy(Action<SellingPlanBillingPolicyUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanBillingPolicy>("sellingPlanBillingPolicy");
            var unionBuilder = new SellingPlanBillingPolicyUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}