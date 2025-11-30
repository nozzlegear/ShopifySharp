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

public class SubscriptionCyclePriceAdjustmentQueryBuilder() : GraphQueryBuilder<SubscriptionCyclePriceAdjustment>("query subscriptionCyclePriceAdjustment")
{
    public SubscriptionCyclePriceAdjustmentQueryBuilder AddFieldAdjustmentType()
    {
        AddField("adjustmentType");
        return this;
    }

    public SubscriptionCyclePriceAdjustmentQueryBuilder AddFieldAdjustmentValue()
    {
        AddField("adjustmentValue");
        return this;
    }

    public SubscriptionCyclePriceAdjustmentQueryBuilder AddFieldAfterCycle()
    {
        AddField("afterCycle");
        return this;
    }

    public SubscriptionCyclePriceAdjustmentQueryBuilder AddFieldComputedPrice()
    {
        AddField("computedPrice");
        return this;
    }
}