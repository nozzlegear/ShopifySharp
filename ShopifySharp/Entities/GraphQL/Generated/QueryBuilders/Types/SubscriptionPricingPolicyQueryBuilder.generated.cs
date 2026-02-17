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
    public sealed class SubscriptionPricingPolicyQueryBuilder : FieldsQueryBuilderBase<SubscriptionPricingPolicy, SubscriptionPricingPolicyQueryBuilder>
    {
        protected override SubscriptionPricingPolicyQueryBuilder Self => this;

        public SubscriptionPricingPolicyQueryBuilder() : this("subscriptionPricingPolicy")
        {
        }

        public SubscriptionPricingPolicyQueryBuilder(string name) : base(new Query<SubscriptionPricingPolicy>(name))
        {
        }

        public SubscriptionPricingPolicyQueryBuilder(IQuery<SubscriptionPricingPolicy> query) : base(query)
        {
        }

        public SubscriptionPricingPolicyQueryBuilder BasePrice(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("basePrice");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public SubscriptionPricingPolicyQueryBuilder CycleDiscounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionCyclePriceAdjustmentQueryBuilder> build)
        {
            var query = new Query<SubscriptionCyclePriceAdjustment>("cycleDiscounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionCyclePriceAdjustmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionCyclePriceAdjustment>(query);
            return this;
        }
    }
}