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
    public sealed class SellingPlanDeliveryPolicyUnionCasesBuilder : UnionCasesBuilderBase<SellingPlanDeliveryPolicy, SellingPlanDeliveryPolicyUnionCasesBuilder>
    {
        protected override SellingPlanDeliveryPolicyUnionCasesBuilder Self => this;

        public SellingPlanDeliveryPolicyUnionCasesBuilder(string fieldName = "sellingPlanDeliveryPolicy") : this(new Query<SellingPlanDeliveryPolicy>(fieldName))
        {
        }

        public SellingPlanDeliveryPolicyUnionCasesBuilder(IQuery<SellingPlanDeliveryPolicy> query) : base(query)
        {
        }

        public SellingPlanDeliveryPolicyUnionCasesBuilder OnSellingPlanFixedDeliveryPolicy(Action<SellingPlanFixedDeliveryPolicyQueryBuilder> build)
        {
            var query = new Query<SellingPlanFixedDeliveryPolicy>("... on SellingPlanFixedDeliveryPolicy");
            var queryBuilder = new SellingPlanFixedDeliveryPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SellingPlanDeliveryPolicyUnionCasesBuilder OnSellingPlanRecurringDeliveryPolicy(Action<SellingPlanRecurringDeliveryPolicyQueryBuilder> build)
        {
            var query = new Query<SellingPlanRecurringDeliveryPolicy>("... on SellingPlanRecurringDeliveryPolicy");
            var queryBuilder = new SellingPlanRecurringDeliveryPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}