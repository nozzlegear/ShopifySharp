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

public class SubscriptionBillingCycleUnskipUserErrorQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleUnskipUserError>("query subscriptionBillingCycleUnskipUserError")
{
    public SubscriptionBillingCycleUnskipUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionBillingCycleUnskipUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public SubscriptionBillingCycleUnskipUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}