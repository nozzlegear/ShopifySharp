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

public class SubscriptionDraftDiscountUpdatePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftDiscountUpdatePayload>("query subscriptionDraftDiscountUpdatePayload")
{
    public SubscriptionDraftDiscountUpdatePayloadQueryBuilder AddFieldDiscountUpdated()
    {
        AddField("discountUpdated");
        return this;
    }

    public SubscriptionDraftDiscountUpdatePayloadQueryBuilder AddFieldDraft()
    {
        AddField("draft");
        return this;
    }

    public SubscriptionDraftDiscountUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}