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

public class SubscriptionDraftLineRemoveQueryBuilder() : GraphQueryBuilder<SubscriptionDraftLineRemovePayload>("query subscriptionDraftLineRemove")
{
    public SubscriptionDraftLineRemoveQueryBuilder AddArgumentDraftId(string? draftId)
    {
        AddArgument("draftId", draftId);
        return this;
    }

    public SubscriptionDraftLineRemoveQueryBuilder AddArgumentLineId(string? lineId)
    {
        AddArgument("lineId", lineId);
        return this;
    }
}