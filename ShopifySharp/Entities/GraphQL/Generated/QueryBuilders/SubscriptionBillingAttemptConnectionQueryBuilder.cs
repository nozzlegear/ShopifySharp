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

public class SubscriptionBillingAttemptConnectionQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttemptConnection>("query subscriptionBillingAttemptConnection")
{
    public SubscriptionBillingAttemptConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public SubscriptionBillingAttemptConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public SubscriptionBillingAttemptConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}