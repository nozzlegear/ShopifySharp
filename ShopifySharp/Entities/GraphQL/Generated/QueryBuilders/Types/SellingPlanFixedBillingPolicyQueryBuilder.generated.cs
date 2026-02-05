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
    public sealed class SellingPlanFixedBillingPolicyQueryBuilder : FieldsQueryBuilderBase<SellingPlanFixedBillingPolicy, SellingPlanFixedBillingPolicyQueryBuilder>
    {
        protected override SellingPlanFixedBillingPolicyQueryBuilder Self => this;

        public SellingPlanFixedBillingPolicyQueryBuilder() : this("sellingPlanFixedBillingPolicy")
        {
        }

        public SellingPlanFixedBillingPolicyQueryBuilder(string name) : base(new Query<SellingPlanFixedBillingPolicy>(name))
        {
        }

        public SellingPlanFixedBillingPolicyQueryBuilder(IQuery<SellingPlanFixedBillingPolicy> query) : base(query)
        {
        }

        public SellingPlanFixedBillingPolicyQueryBuilder CheckoutCharge(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanCheckoutChargeQueryBuilder> build)
        {
            var query = new Query<SellingPlanCheckoutCharge>("checkoutCharge");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanCheckoutChargeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanCheckoutCharge>(query);
            return this;
        }

        public SellingPlanFixedBillingPolicyQueryBuilder RemainingBalanceChargeExactTime()
        {
            base.InnerQuery.AddField("remainingBalanceChargeExactTime");
            return this;
        }

        public SellingPlanFixedBillingPolicyQueryBuilder RemainingBalanceChargeTimeAfterCheckout()
        {
            base.InnerQuery.AddField("remainingBalanceChargeTimeAfterCheckout");
            return this;
        }

        public SellingPlanFixedBillingPolicyQueryBuilder RemainingBalanceChargeTrigger()
        {
            base.InnerQuery.AddField("remainingBalanceChargeTrigger");
            return this;
        }
    }
}