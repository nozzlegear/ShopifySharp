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
    public sealed class SellingPlanFixedDeliveryPolicyQueryBuilder : FieldsQueryBuilderBase<SellingPlanFixedDeliveryPolicy, SellingPlanFixedDeliveryPolicyQueryBuilder>
    {
        protected override SellingPlanFixedDeliveryPolicyQueryBuilder Self => this;

        public SellingPlanFixedDeliveryPolicyQueryBuilder() : this("sellingPlanFixedDeliveryPolicy")
        {
        }

        public SellingPlanFixedDeliveryPolicyQueryBuilder(string name) : base(new Query<SellingPlanFixedDeliveryPolicy>(name))
        {
        }

        public SellingPlanFixedDeliveryPolicyQueryBuilder(IQuery<SellingPlanFixedDeliveryPolicy> query) : base(query)
        {
        }

        public SellingPlanFixedDeliveryPolicyQueryBuilder Anchors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanAnchorQueryBuilder> build)
        {
            var query = new Query<SellingPlanAnchor>("anchors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SellingPlanAnchorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanAnchor>(query);
            return this;
        }

        public SellingPlanFixedDeliveryPolicyQueryBuilder Cutoff()
        {
            base.InnerQuery.AddField("cutoff");
            return this;
        }

        public SellingPlanFixedDeliveryPolicyQueryBuilder FulfillmentExactTime()
        {
            base.InnerQuery.AddField("fulfillmentExactTime");
            return this;
        }

        public SellingPlanFixedDeliveryPolicyQueryBuilder FulfillmentTrigger()
        {
            base.InnerQuery.AddField("fulfillmentTrigger");
            return this;
        }

        public SellingPlanFixedDeliveryPolicyQueryBuilder Intent()
        {
            base.InnerQuery.AddField("intent");
            return this;
        }

        public SellingPlanFixedDeliveryPolicyQueryBuilder PreAnchorBehavior()
        {
            base.InnerQuery.AddField("preAnchorBehavior");
            return this;
        }
    }
}