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

public class SubscriptionPricingPolicyQueryBuilder() : GraphQueryBuilder<SubscriptionPricingPolicy>("query subscriptionPricingPolicy")
{
    public SubscriptionPricingPolicyQueryBuilder AddFieldBasePrice()
    {
        AddField("basePrice");
        return this;
    }

    public SubscriptionPricingPolicyQueryBuilder AddFieldCycleDiscounts()
    {
        AddField("cycleDiscounts");
        return this;
    }
}