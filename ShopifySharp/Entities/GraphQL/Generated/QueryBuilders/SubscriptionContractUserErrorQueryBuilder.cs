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

public class SubscriptionContractUserErrorQueryBuilder() : GraphQueryBuilder<SubscriptionContractUserError>("query subscriptionContractUserError")
{
    public SubscriptionContractUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionContractUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public SubscriptionContractUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}