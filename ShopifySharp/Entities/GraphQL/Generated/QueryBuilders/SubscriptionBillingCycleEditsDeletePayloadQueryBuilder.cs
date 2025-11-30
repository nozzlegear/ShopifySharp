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

public class SubscriptionBillingCycleEditsDeletePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleEditsDeletePayload>("query subscriptionBillingCycleEditsDeletePayload")
{
    public SubscriptionBillingCycleEditsDeletePayloadQueryBuilder AddFieldBillingCycles()
    {
        AddField("billingCycles");
        return this;
    }

    public SubscriptionBillingCycleEditsDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}