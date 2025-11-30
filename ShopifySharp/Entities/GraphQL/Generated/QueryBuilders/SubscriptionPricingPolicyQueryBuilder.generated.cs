#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class SubscriptionPricingPolicyQueryBuilder() : GraphQueryBuilder<SubscriptionPricingPolicy>("subscriptionPricingPolicy")
{
    public SubscriptionPricingPolicyQueryBuilder AddFieldBasePrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("basePrice", build);
        return this;
    }

    public SubscriptionPricingPolicyQueryBuilder AddFieldCycleDiscounts(Func<SubscriptionCyclePriceAdjustmentQueryBuilder, SubscriptionCyclePriceAdjustmentQueryBuilder> build)
    {
        AddField<SubscriptionCyclePriceAdjustment, SubscriptionCyclePriceAdjustmentQueryBuilder>("cycleDiscounts", build);
        return this;
    }
}