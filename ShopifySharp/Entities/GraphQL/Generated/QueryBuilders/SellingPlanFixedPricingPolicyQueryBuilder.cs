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

public class SellingPlanFixedPricingPolicyQueryBuilder() : GraphQueryBuilder<SellingPlanFixedPricingPolicy>("query sellingPlanFixedPricingPolicy")
{
    public SellingPlanFixedPricingPolicyQueryBuilder AddFieldAdjustmentType()
    {
        AddField("adjustmentType");
        return this;
    }

    public SellingPlanFixedPricingPolicyQueryBuilder AddFieldAdjustmentValue()
    {
        AddField("adjustmentValue");
        return this;
    }

    public SellingPlanFixedPricingPolicyQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }
}