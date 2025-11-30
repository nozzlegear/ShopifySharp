#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class SubscriptionBillingCycleBulkUserErrorQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleBulkUserError>("subscriptionBillingCycleBulkUserError")
{
    public SubscriptionBillingCycleBulkUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionBillingCycleBulkUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public SubscriptionBillingCycleBulkUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}