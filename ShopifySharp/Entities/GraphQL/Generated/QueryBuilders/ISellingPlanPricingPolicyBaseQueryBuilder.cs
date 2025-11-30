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

public class ISellingPlanPricingPolicyBaseQueryBuilder() : GraphQueryBuilder<ISellingPlanPricingPolicyBase>("query iSellingPlanPricingPolicyBase")
{
    public ISellingPlanPricingPolicyBaseQueryBuilder AddFieldAdjustmentType()
    {
        AddField("adjustmentType");
        return this;
    }

    public ISellingPlanPricingPolicyBaseQueryBuilder AddFieldAdjustmentValue()
    {
        AddField("adjustmentValue");
        return this;
    }
}