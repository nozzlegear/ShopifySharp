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

public class SubscriptionContractPausePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionContractPausePayload>("query subscriptionContractPausePayload")
{
    public SubscriptionContractPausePayloadQueryBuilder AddFieldContract()
    {
        AddField("contract");
        return this;
    }

    public SubscriptionContractPausePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}