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

public class SubscriptionDraftLineRemovePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftLineRemovePayload>("query subscriptionDraftLineRemovePayload")
{
    public SubscriptionDraftLineRemovePayloadQueryBuilder AddFieldDiscountsUpdated()
    {
        AddField("discountsUpdated");
        return this;
    }

    public SubscriptionDraftLineRemovePayloadQueryBuilder AddFieldDraft()
    {
        AddField("draft");
        return this;
    }

    public SubscriptionDraftLineRemovePayloadQueryBuilder AddFieldLineRemoved()
    {
        AddField("lineRemoved");
        return this;
    }

    public SubscriptionDraftLineRemovePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}