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

public class SubscriptionDraftLineAddPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftLineAddPayload>("query subscriptionDraftLineAddPayload")
{
    public SubscriptionDraftLineAddPayloadQueryBuilder AddFieldDraft()
    {
        AddField("draft");
        return this;
    }

    public SubscriptionDraftLineAddPayloadQueryBuilder AddFieldLineAdded()
    {
        AddField("lineAdded");
        return this;
    }

    public SubscriptionDraftLineAddPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}