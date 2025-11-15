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

public class SubscriptionDraftFreeShippingDiscountAddPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftFreeShippingDiscountAddPayload>("query subscriptionDraftFreeShippingDiscountAddPayload")
{
    public SubscriptionDraftFreeShippingDiscountAddPayloadQueryBuilder AddFieldDiscountAdded()
    {
        AddField("discountAdded");
        return this;
    }

    public SubscriptionDraftFreeShippingDiscountAddPayloadQueryBuilder AddFieldDraft()
    {
        AddField("draft");
        return this;
    }

    public SubscriptionDraftFreeShippingDiscountAddPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}