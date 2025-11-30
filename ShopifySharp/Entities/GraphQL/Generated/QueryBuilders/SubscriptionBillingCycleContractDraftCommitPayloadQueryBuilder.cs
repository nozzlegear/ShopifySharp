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

public class SubscriptionBillingCycleContractDraftCommitPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleContractDraftCommitPayload>("query subscriptionBillingCycleContractDraftCommitPayload")
{
    public SubscriptionBillingCycleContractDraftCommitPayloadQueryBuilder AddFieldContract()
    {
        AddField("contract");
        return this;
    }

    public SubscriptionBillingCycleContractDraftCommitPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}