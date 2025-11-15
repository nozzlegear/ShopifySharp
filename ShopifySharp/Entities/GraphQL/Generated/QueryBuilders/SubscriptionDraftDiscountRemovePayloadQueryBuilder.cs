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

public class SubscriptionDraftDiscountRemovePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftDiscountRemovePayload>("query subscriptionDraftDiscountRemovePayload")
{
    public SubscriptionDraftDiscountRemovePayloadQueryBuilder AddFieldDiscountRemoved()
    {
        AddField("discountRemoved");
        return this;
    }

    public SubscriptionDraftDiscountRemovePayloadQueryBuilder AddFieldDraft()
    {
        AddField("draft");
        return this;
    }

    public SubscriptionDraftDiscountRemovePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}