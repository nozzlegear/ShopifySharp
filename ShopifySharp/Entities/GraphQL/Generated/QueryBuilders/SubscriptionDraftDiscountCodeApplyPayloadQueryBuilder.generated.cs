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

public class SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionDraftDiscountCodeApplyPayload>("subscriptionDraftDiscountCodeApplyPayload")
{
    public SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder AddFieldAppliedDiscount(Func<SubscriptionAppliedCodeDiscountQueryBuilder, SubscriptionAppliedCodeDiscountQueryBuilder> build)
    {
        AddField<SubscriptionAppliedCodeDiscount, SubscriptionAppliedCodeDiscountQueryBuilder>("appliedDiscount", build);
        return this;
    }

    public SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder AddFieldDraft(Func<SubscriptionDraftQueryBuilder, SubscriptionDraftQueryBuilder> build)
    {
        AddField<SubscriptionDraft, SubscriptionDraftQueryBuilder>("draft", build);
        return this;
    }

    public SubscriptionDraftDiscountCodeApplyPayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionDraftUserErrorQueryBuilder, SubscriptionDraftUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionDraftUserError, SubscriptionDraftUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}