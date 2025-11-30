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

public class SubscriptionContractSetNextBillingDateQueryBuilder() : GraphQueryBuilder<SubscriptionContractSetNextBillingDatePayload>("query subscriptionContractSetNextBillingDate")
{
    public SubscriptionContractSetNextBillingDateQueryBuilder AddArgumentContractId(string? contractId)
    {
        AddArgument("contractId", contractId);
        return this;
    }

    public SubscriptionContractSetNextBillingDateQueryBuilder AddArgumentDate(DateTime? date)
    {
        AddArgument("date", date);
        return this;
    }
}