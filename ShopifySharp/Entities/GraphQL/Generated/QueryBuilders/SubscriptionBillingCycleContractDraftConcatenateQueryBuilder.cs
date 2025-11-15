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

public class SubscriptionBillingCycleContractDraftConcatenateQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleContractDraftConcatenatePayload>("query subscriptionBillingCycleContractDraftConcatenate")
{
    public SubscriptionBillingCycleContractDraftConcatenateQueryBuilder AddArgumentConcatenatedBillingCycleContracts(ICollection<SubscriptionBillingCycleInput>? concatenatedBillingCycleContracts)
    {
        AddArgument("concatenatedBillingCycleContracts", concatenatedBillingCycleContracts);
        return this;
    }

    public SubscriptionBillingCycleContractDraftConcatenateQueryBuilder AddArgumentDraftId(string? draftId)
    {
        AddArgument("draftId", draftId);
        return this;
    }
}