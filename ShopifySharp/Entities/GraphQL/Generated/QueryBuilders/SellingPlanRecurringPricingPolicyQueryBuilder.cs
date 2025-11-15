#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class SellingPlanRecurringPricingPolicyQueryBuilder() : GraphQueryBuilder<SellingPlanRecurringPricingPolicy>("query sellingPlanRecurringPricingPolicy")
{
    public SellingPlanRecurringPricingPolicyQueryBuilder AddFieldAdjustmentType()
    {
        AddField("adjustmentType");
        return this;
    }

    public SellingPlanRecurringPricingPolicyQueryBuilder AddFieldAdjustmentValue()
    {
        AddField("adjustmentValue");
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