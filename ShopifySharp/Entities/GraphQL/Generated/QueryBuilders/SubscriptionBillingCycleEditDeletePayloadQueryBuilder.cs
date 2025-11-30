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

public class SubscriptionBillingCycleEditDeletePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleEditDeletePayload>("query subscriptionBillingCycleEditDeletePayload")
{
    public SubscriptionBillingCycleEditDeletePayloadQueryBuilder AddFieldBillingCycles()
    {
        AddField("billingCycles");
        return this;
    }

    public SubscriptionBillingCycleEditDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}