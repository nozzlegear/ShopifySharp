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

public class SubscriptionBillingCycleChargeQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleChargePayload>("query subscriptionBillingCycleCharge")
{
    public SubscriptionBillingCycleChargeQueryBuilder AddArgumentBillingCycleSelector(SubscriptionBillingCycleSelector? billingCycleSelector)
    {
        AddArgument("billingCycleSelector", billingCycleSelector);
        return this;
    }

    public SubscriptionBillingCycleChargeQueryBuilder AddArgumentInventoryPolicy(SubscriptionBillingAttemptInventoryPolicy? inventoryPolicy)
    {
        AddArgument("inventoryPolicy", inventoryPolicy);
        return this;
    }

    public SubscriptionBillingCycleChargeQueryBuilder AddArgumentSubscriptionContractId(string? subscriptionContractId)
    {
        AddArgument("subscriptionContractId", subscriptionContractId);
        return this;
    }
}