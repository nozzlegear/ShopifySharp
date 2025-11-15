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

public class SubscriptionBillingCycleContractDraftConcatenatePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleContractDraftConcatenatePayload>("query subscriptionBillingCycleContractDraftConcatenatePayload")
{
    public SubscriptionBillingCycleContractDraftConcatenatePayloadQueryBuilder AddFieldDraft()
    {
        AddField("draft");
        return this;
    }

    public SubscriptionBillingCycleContractDraftConcatenatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}