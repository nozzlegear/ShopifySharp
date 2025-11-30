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

public class SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftDiscountCodeApplyPayload>("query subscriptionDraftDiscountCodeApplyPayload")
{
    public SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder AddFieldAppliedDiscount()
    {
        AddField("appliedDiscount");
        return this;
    }

    public SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder AddFieldDraft()
    {
        AddField("draft");
        return this;
    }

    public SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}