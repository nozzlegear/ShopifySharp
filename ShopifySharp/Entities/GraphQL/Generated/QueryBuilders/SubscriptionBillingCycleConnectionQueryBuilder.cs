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

public class SubscriptionBillingCycleConnectionQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleConnection>("query subscriptionBillingCycleConnection")
{
    public SubscriptionBillingCycleConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public SubscriptionBillingCycleConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public SubscriptionBillingCycleConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}