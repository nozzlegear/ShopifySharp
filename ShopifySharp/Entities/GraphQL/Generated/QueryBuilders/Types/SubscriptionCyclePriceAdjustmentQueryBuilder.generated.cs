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
    public sealed class SubscriptionCyclePriceAdjustmentQueryBuilder : FieldsQueryBuilderBase<SubscriptionCyclePriceAdjustment, SubscriptionCyclePriceAdjustmentQueryBuilder>
    {
        protected override SubscriptionCyclePriceAdjustmentQueryBuilder Self => this;

        public SubscriptionCyclePriceAdjustmentQueryBuilder() : this("subscriptionCyclePriceAdjustment")
        {
        }

        public SubscriptionCyclePriceAdjustmentQueryBuilder(string name) : base(new Query<SubscriptionCyclePriceAdjustment>(name))
        {
        }

        public SubscriptionCyclePriceAdjustmentQueryBuilder(IQuery<SubscriptionCyclePriceAdjustment> query) : base(query)
        {
        }

        public SubscriptionCyclePriceAdjustmentQueryBuilder AdjustmentType()
        {
            base.InnerQuery.AddField("adjustmentType");
            return this;
        }

        public SubscriptionCyclePriceAdjustmentQueryBuilder AfterCycle()
        {
            base.InnerQuery.AddField("afterCycle");
            return this;
        }

        public SubscriptionCyclePriceAdjustmentQueryBuilder ComputedPrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("computedPrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionCyclePriceAdjustmentQueryBuilder AdjustmentValue(Action<SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder> build)
        {
            var query = new Query<SellingPlanPricingPolicyAdjustmentValue>("adjustmentValue");
            var unionBuilder = new SellingPlanPricingPolicyAdjustmentValueUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}