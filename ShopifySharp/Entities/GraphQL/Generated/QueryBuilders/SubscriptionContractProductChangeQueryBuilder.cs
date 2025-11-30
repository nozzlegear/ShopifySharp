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

public class SubscriptionContractProductChangeQueryBuilder() : GraphQueryBuilder<SubscriptionContractProductChangePayload>("query subscriptionContractProductChange")
{
    public SubscriptionContractProductChangeQueryBuilder AddArgumentInput(SubscriptionContractProductChangeInput? input)
    {
        AddArgument("input", input);
        return this;
    }

    public SubscriptionContractProductChangeQueryBuilder AddArgumentLineId(string? lineId)
    {
        AddArgument("lineId", lineId);
        return this;
    }

    public SubscriptionContractProductChangeQueryBuilder AddArgumentSubscriptionContractId(string? subscriptionContractId)
    {
        AddArgument("subscriptionContractId", subscriptionContractId);
        return this;
    }
}