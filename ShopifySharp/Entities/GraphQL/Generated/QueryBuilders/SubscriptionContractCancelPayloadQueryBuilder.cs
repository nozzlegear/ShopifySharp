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

public class SubscriptionContractCancelPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionContractCancelPayload>("query subscriptionContractCancelPayload")
{
    public SubscriptionContractCancelPayloadQueryBuilder AddFieldContract()
    {
        AddField("contract");
        return this;
    }

    public SubscriptionContractCancelPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}