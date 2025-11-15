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

public class SubscriptionDraftDiscountAddQueryBuilder() : GraphQueryBuilder<SubscriptionDraftDiscountAddPayload>("query subscriptionDraftDiscountAdd")
{
    public SubscriptionDraftDiscountAddQueryBuilder AddArgumentDraftId(string? draftId)
    {
        AddArgument("draftId", draftId);
        return this;
    }

    public SubscriptionDraftDiscountAddQueryBuilder AddArgumentInput(SubscriptionManualDiscountInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}