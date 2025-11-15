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

public class SellingPlanFixedBillingPolicyQueryBuilder() : GraphQueryBuilder<SellingPlanFixedBillingPolicy>("query sellingPlanFixedBillingPolicy")
{
    public SellingPlanFixedBillingPolicyQueryBuilder AddFieldCheckoutCharge()
    {
        AddField("checkoutCharge");
        return this;
    }

    public SellingPlanFixedBillingPolicyQueryBuilder AddFieldRemainingBalanceChargeExactTime()
    {
        AddField("remainingBalanceChargeExactTime");
        return this;
    }

    public SellingPlanFixedBillingPolicyQueryBuilder AddFieldRemainingBalanceChargeTimeAfterCheckout()
    {
        AddField("remainingBalanceChargeTimeAfterCheckout");
        return this;
    }

    public SellingPlanFixedBillingPolicyQueryBuilder AddFieldRemainingBalanceChargeTrigger()
    {
        AddField("remainingBalanceChargeTrigger");
        return this;
    }
}