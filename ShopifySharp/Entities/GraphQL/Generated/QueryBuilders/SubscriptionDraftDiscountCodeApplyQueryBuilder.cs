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

public class SubscriptionDraftDiscountCodeApplyQueryBuilder() : GraphQueryBuilder<SubscriptionDraftDiscountCodeApplyPayload>("query subscriptionDraftDiscountCodeApply")
{
    public SubscriptionDraftDiscountCodeApplyQueryBuilder AddArgumentDraftId(string? draftId)
    {
        AddArgument("draftId", draftId);
        return this;
    }

    public SubscriptionDraftDiscountCodeApplyQueryBuilder AddArgumentRedeemCode(string? redeemCode)
    {
        AddArgument("redeemCode", redeemCode);
        return this;
    }
}