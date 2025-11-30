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

public class SellingPlanRecurringPricingPolicyQueryBuilder() : GraphQueryBuilder<SellingPlanRecurringPricingPolicy>("sellingPlanRecurringPricingPolicy")
{
    public SellingPlanRecurringPricingPolicyQueryBuilder AddFieldAdjustmentType()
    {
        AddField("adjustmentType");
        return this;
    }

    public SellingPlanRecurringPricingPolicyQueryBuilder AddUnionCaseAdjustmentValue(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddUnion<MoneyV2, MoneyV2QueryBuilder>("adjustmentValue", build);
        return this;
    }

    public SellingPlanRecurringPricingPolicyQueryBuilder AddUnionCaseAdjustmentValue(Func<SellingPlanPricingPolicyPercentageValueQueryBuilder, SellingPlanPricingPolicyPercentageValueQueryBuilder> build)
    {
        AddUnion<SellingPlanPricingPolicyPercentageValue, SellingPlanPricingPolicyPercentageValueQueryBuilder>("adjustmentValue", build);
        return this;
    }

    public SellingPlanRecurringPricingPolicyQueryBuilder AddFieldAfterCycle()
    {
        AddField("afterCycle");
        return this;
    }

    public SellingPlanRecurringPricingPolicyQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }
}