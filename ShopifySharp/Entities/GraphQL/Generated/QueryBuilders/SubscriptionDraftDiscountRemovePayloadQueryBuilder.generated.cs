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

public class SubscriptionDraftDiscountRemovePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftDiscountRemovePayload>("subscriptionDraftDiscountRemovePayload")
{
    public SubscriptionDraftDiscountRemovePayloadQueryBuilder AddUnionCaseDiscountRemoved(Func<SubscriptionAppliedCodeDiscountQueryBuilder, SubscriptionAppliedCodeDiscountQueryBuilder> build)
    {
        AddUnion<SubscriptionAppliedCodeDiscount, SubscriptionAppliedCodeDiscountQueryBuilder>("discountRemoved", build);
        return this;
    }

    public SubscriptionDraftDiscountRemovePayloadQueryBuilder AddUnionCaseDiscountRemoved(Func<SubscriptionManualDiscountQueryBuilder, SubscriptionManualDiscountQueryBuilder> build)
    {
        AddUnion<SubscriptionManualDiscount, SubscriptionManualDiscountQueryBuilder>("discountRemoved", build);
        return this;
    }

    public SubscriptionDraftDiscountRemovePayloadQueryBuilder AddFieldDraft(Func<SubscriptionDraftQueryBuilder, SubscriptionDraftQueryBuilder> build)
    {
        AddField<SubscriptionDraft, SubscriptionDraftQueryBuilder>("draft", build);
        return this;
    }

    public SubscriptionDraftDiscountRemovePayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionDraftUserErrorQueryBuilder, SubscriptionDraftUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionDraftUserError, SubscriptionDraftUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}