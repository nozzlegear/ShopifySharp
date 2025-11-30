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

public class SubscriptionDraftLineUpdatePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftLineUpdatePayload>("query subscriptionDraftLineUpdatePayload")
{
    public SubscriptionDraftLineUpdatePayloadQueryBuilder AddFieldDraft()
    {
        AddField("draft");
        return this;
    }

    public SubscriptionDraftLineUpdatePayloadQueryBuilder AddFieldLineUpdated()
    {
        AddField("lineUpdated");
        return this;
    }

    public SubscriptionDraftLineUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}