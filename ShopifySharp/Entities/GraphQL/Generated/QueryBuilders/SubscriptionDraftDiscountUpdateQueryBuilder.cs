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

public class SubscriptionDraftDiscountUpdateQueryBuilder() : GraphQueryBuilder<SubscriptionDraftDiscountUpdatePayload>("query subscriptionDraftDiscountUpdate")
{
    public SubscriptionDraftDiscountUpdateQueryBuilder AddArgumentDiscountId(string? discountId)
    {
        AddArgument("discountId", discountId);
        return this;
    }

    public SubscriptionDraftDiscountUpdateQueryBuilder AddArgumentDraftId(string? draftId)
    {
        AddArgument("draftId", draftId);
        return this;
    }

    public SubscriptionDraftDiscountUpdateQueryBuilder AddArgumentInput(SubscriptionManualDiscountInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}