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

public class SubscriptionContractSetNextBillingDatePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionContractSetNextBillingDatePayload>("query subscriptionContractSetNextBillingDatePayload")
{
    public SubscriptionContractSetNextBillingDatePayloadQueryBuilder AddFieldContract()
    {
        AddField("contract");
        return this;
    }

    public SubscriptionContractSetNextBillingDatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}