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

public class SubscriptionBillingCycleScheduleEditQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleScheduleEditPayload>("query subscriptionBillingCycleScheduleEdit")
{
    public SubscriptionBillingCycleScheduleEditQueryBuilder AddArgumentBillingCycleInput(SubscriptionBillingCycleInput? billingCycleInput)
    {
        AddArgument("billingCycleInput", billingCycleInput);
        return this;
    }

    public SubscriptionBillingCycleScheduleEditQueryBuilder AddArgumentInput(SubscriptionBillingCycleScheduleEditInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}