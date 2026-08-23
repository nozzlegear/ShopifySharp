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
    public sealed class SellingPlanDeliveryPolicyUnionCasesBuilder : UnionCasesBuilderBase<SellingPlanDeliveryPolicy, SellingPlanDeliveryPolicyUnionCasesBuilder>
    {
        protected override SellingPlanDeliveryPolicyUnionCasesBuilder Self => this;

        public SellingPlanDeliveryPolicyUnionCasesBuilder(string fieldName = "sellingPlanDeliveryPolicy") : this(new Query<SellingPlanDeliveryPolicy>(fieldName))
        {
        }

        public SellingPlanDeliveryPolicyUnionCasesBuilder(IQuery<SellingPlanDeliveryPolicy> query) : base(query)
        {
        }

        public SellingPlanDeliveryPolicyUnionCasesBuilder OnSellingPlanFixedDeliveryPolicy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanFixedDeliveryPolicyQueryBuilder> build)
        {
            var query = new Query<SellingPlanFixedDeliveryPolicy>("... on SellingPlanFixedDeliveryPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanFixedDeliveryPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SellingPlanDeliveryPolicyUnionCasesBuilder OnSellingPlanRecurringDeliveryPolicy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanRecurringDeliveryPolicyQueryBuilder> build)
        {
            var query = new Query<SellingPlanRecurringDeliveryPolicy>("... on SellingPlanRecurringDeliveryPolicy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanRecurringDeliveryPolicyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}