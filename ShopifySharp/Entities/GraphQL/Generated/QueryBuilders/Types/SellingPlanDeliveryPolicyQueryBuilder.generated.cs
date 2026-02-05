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
    public sealed class SellingPlanDeliveryPolicyQueryBuilder : FieldsQueryBuilderBase<SellingPlanDeliveryPolicy, SellingPlanDeliveryPolicyQueryBuilder>
    {
        protected override SellingPlanDeliveryPolicyQueryBuilder Self => this;

        public SellingPlanDeliveryPolicyQueryBuilder() : this("sellingPlanDeliveryPolicy")
        {
        }

        public SellingPlanDeliveryPolicyQueryBuilder(string name) : base(new Query<SellingPlanDeliveryPolicy>(name))
        {
        }

        public SellingPlanDeliveryPolicyQueryBuilder(IQuery<SellingPlanDeliveryPolicy> query) : base(query)
        {
        }

        public SellingPlanDeliveryPolicyQueryBuilder SellingPlanDeliveryPolicy(Action<SellingPlanDeliveryPolicyUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanDeliveryPolicy>("sellingPlanDeliveryPolicy");
            var unionBuilder = new SellingPlanDeliveryPolicyUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}