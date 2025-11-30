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

public class SubscriptionDraftDiscountAddPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftDiscountAddPayload>("query subscriptionDraftDiscountAddPayload")
{
    public SubscriptionDraftDiscountAddPayloadQueryBuilder AddFieldDiscountAdded()
    {
        AddField("discountAdded");
        return this;
    }

    public SubscriptionDraftDiscountAddPayloadQueryBuilder AddFieldDraft()
    {
        AddField("draft");
        return this;
    }

    public SubscriptionDraftDiscountAddPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}