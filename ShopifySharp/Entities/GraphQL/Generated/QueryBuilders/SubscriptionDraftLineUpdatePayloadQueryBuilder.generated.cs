#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class SubscriptionDraftLineUpdatePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftLineUpdatePayload>("subscriptionDraftLineUpdatePayload")
{
    public SubscriptionDraftLineUpdatePayloadQueryBuilder AddFieldDraft(Func<SubscriptionDraftQueryBuilder, SubscriptionDraftQueryBuilder> build)
    {
        AddField<SubscriptionDraft, SubscriptionDraftQueryBuilder>("draft", build);
        return this;
    }

    public SubscriptionDraftLineUpdatePayloadQueryBuilder AddFieldLineUpdated(Func<SubscriptionLineQueryBuilder, SubscriptionLineQueryBuilder> build)
    {
        AddField<SubscriptionLine, SubscriptionLineQueryBuilder>("lineUpdated", build);
        return this;
    }

    public SubscriptionDraftLineUpdatePayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionDraftUserErrorQueryBuilder, SubscriptionDraftUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionDraftUserError, SubscriptionDraftUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}