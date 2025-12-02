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

public class SubscriptionCyclePriceAdjustmentQueryBuilder() : GraphQueryBuilder<SubscriptionCyclePriceAdjustment>("subscriptionCyclePriceAdjustment")
{
    public SubscriptionCyclePriceAdjustmentQueryBuilder AddFieldAdjustmentType()
    {
        AddField("adjustmentType");
        return this;
    }

    public SubscriptionCyclePriceAdjustmentQueryBuilder AddUnionCaseAdjustmentValue(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddUnion<MoneyV2, MoneyV2QueryBuilder>("adjustmentValue", build);
        return this;
    }

    public SubscriptionCyclePriceAdjustmentQueryBuilder AddUnionCaseAdjustmentValue(Func<SellingPlanPricingPolicyPercentageValueQueryBuilder, SellingPlanPricingPolicyPercentageValueQueryBuilder> build)
    {
        AddUnion<SellingPlanPricingPolicyPercentageValue, SellingPlanPricingPolicyPercentageValueQueryBuilder>("adjustmentValue", build);
        return this;
    }

    public SubscriptionCyclePriceAdjustmentQueryBuilder AddFieldAfterCycle()
    {
        AddField("afterCycle");
        return this;
    }

    public SubscriptionCyclePriceAdjustmentQueryBuilder AddFieldComputedPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("computedPrice", build);
        return this;
    }
}