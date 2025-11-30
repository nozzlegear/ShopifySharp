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

public class SubscriptionBillingAttemptGenericErrorQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttemptGenericError>("query subscriptionBillingAttemptGenericError")
{
    public SubscriptionBillingAttemptGenericErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionBillingAttemptGenericErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}