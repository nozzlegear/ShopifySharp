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

public class SubscriptionBillingCycleSkipUserErrorQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleSkipUserError>("query subscriptionBillingCycleSkipUserError")
{
    public SubscriptionBillingCycleSkipUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionBillingCycleSkipUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public SubscriptionBillingCycleSkipUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}