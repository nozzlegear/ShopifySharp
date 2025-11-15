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

public class SubscriptionContractPauseQueryBuilder() : GraphQueryBuilder<SubscriptionContractPausePayload>("query subscriptionContractPause")
{
    public SubscriptionContractPauseQueryBuilder AddArgumentSubscriptionContractId(string? subscriptionContractId)
    {
        AddArgument("subscriptionContractId", subscriptionContractId);
        return this;
    }
}