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

public class SubscriptionDraftUpdateQueryBuilder() : GraphQueryBuilder<SubscriptionDraftUpdatePayload>("query subscriptionDraftUpdate")
{
    public SubscriptionDraftUpdateQueryBuilder AddArgumentDraftId(string? draftId)
    {
        AddArgument("draftId", draftId);
        return this;
    }

    public SubscriptionDraftUpdateQueryBuilder AddArgumentInput(SubscriptionDraftInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}