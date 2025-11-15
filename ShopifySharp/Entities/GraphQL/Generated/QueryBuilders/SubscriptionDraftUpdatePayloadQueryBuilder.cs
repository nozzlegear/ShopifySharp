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

public class SubscriptionDraftUpdatePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftUpdatePayload>("query subscriptionDraftUpdatePayload")
{
    public SubscriptionDraftUpdatePayloadQueryBuilder AddFieldDraft()
    {
        AddField("draft");
        return this;
    }

    public SubscriptionDraftUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}