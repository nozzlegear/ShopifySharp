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

public class SubscriptionBillingAttemptCreatePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttemptCreatePayload>("query subscriptionBillingAttemptCreatePayload")
{
    public SubscriptionBillingAttemptCreatePayloadQueryBuilder AddFieldSubscriptionBillingAttempt()
    {
        AddField("subscriptionBillingAttempt");
        return this;
    }

    public SubscriptionBillingAttemptCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}