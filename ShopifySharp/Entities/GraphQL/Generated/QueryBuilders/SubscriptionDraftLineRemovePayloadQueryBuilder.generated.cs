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

public class SubscriptionDraftLineRemovePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftLineRemovePayload>("subscriptionDraftLineRemovePayload")
{
    public SubscriptionDraftLineRemovePayloadQueryBuilder AddFieldDiscountsUpdated(Func<SubscriptionManualDiscountQueryBuilder, SubscriptionManualDiscountQueryBuilder> build)
    {
        AddField<SubscriptionManualDiscount, SubscriptionManualDiscountQueryBuilder>("discountsUpdated", build);
        return this;
    }

    public SubscriptionDraftLineRemovePayloadQueryBuilder AddFieldDraft(Func<SubscriptionDraftQueryBuilder, SubscriptionDraftQueryBuilder> build)
    {
        AddField<SubscriptionDraft, SubscriptionDraftQueryBuilder>("draft", build);
        return this;
    }

    public SubscriptionDraftLineRemovePayloadQueryBuilder AddFieldLineRemoved(Func<SubscriptionLineQueryBuilder, SubscriptionLineQueryBuilder> build)
    {
        AddField<SubscriptionLine, SubscriptionLineQueryBuilder>("lineRemoved", build);
        return this;
    }

    public SubscriptionDraftLineRemovePayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionDraftUserErrorQueryBuilder, SubscriptionDraftUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionDraftUserError, SubscriptionDraftUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}