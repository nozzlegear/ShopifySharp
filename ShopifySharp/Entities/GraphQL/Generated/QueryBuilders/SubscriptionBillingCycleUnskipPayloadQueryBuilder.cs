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

public class SubscriptionBillingCycleUnskipPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleUnskipPayload>("query subscriptionBillingCycleUnskipPayload")
{
    public SubscriptionBillingCycleUnskipPayloadQueryBuilder AddFieldBillingCycle()
    {
        AddField("billingCycle");
        return this;
    }

    public SubscriptionBillingCycleUnskipPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}