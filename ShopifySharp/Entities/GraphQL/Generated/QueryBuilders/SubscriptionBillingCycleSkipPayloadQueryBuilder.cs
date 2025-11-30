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

public class SubscriptionBillingCycleSkipPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleSkipPayload>("query subscriptionBillingCycleSkipPayload")
{
    public SubscriptionBillingCycleSkipPayloadQueryBuilder AddFieldBillingCycle()
    {
        AddField("billingCycle");
        return this;
    }

    public SubscriptionBillingCycleSkipPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}