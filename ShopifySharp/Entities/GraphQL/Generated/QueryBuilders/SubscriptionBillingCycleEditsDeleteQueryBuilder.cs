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

public class SubscriptionBillingCycleEditsDeleteQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleEditsDeletePayload>("query subscriptionBillingCycleEditsDelete")
{
    public SubscriptionBillingCycleEditsDeleteQueryBuilder AddArgumentContractId(string? contractId)
    {
        AddArgument("contractId", contractId);
        return this;
    }

    public SubscriptionBillingCycleEditsDeleteQueryBuilder AddArgumentTargetSelection(SubscriptionBillingCyclesTargetSelection? targetSelection)
    {
        AddArgument("targetSelection", targetSelection);
        return this;
    }
}