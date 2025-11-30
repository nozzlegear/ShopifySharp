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

public class SubscriptionBillingCycleScheduleEditPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleScheduleEditPayload>("query subscriptionBillingCycleScheduleEditPayload")
{
    public SubscriptionBillingCycleScheduleEditPayloadQueryBuilder AddFieldBillingCycle()
    {
        AddField("billingCycle");
        return this;
    }

    public SubscriptionBillingCycleScheduleEditPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}