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

public class SubscriptionBillingAttemptCreatePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttemptCreatePayload>("subscriptionBillingAttemptCreatePayload")
{
    public SubscriptionBillingAttemptCreatePayloadQueryBuilder AddFieldSubscriptionBillingAttempt(Func<SubscriptionBillingAttemptQueryBuilder, SubscriptionBillingAttemptQueryBuilder> build)
    {
        AddField<SubscriptionBillingAttempt, SubscriptionBillingAttemptQueryBuilder>("subscriptionBillingAttempt", build);
        return this;
    }

    public SubscriptionBillingAttemptCreatePayloadQueryBuilder AddFieldUserErrors(Func<BillingAttemptUserErrorQueryBuilder, BillingAttemptUserErrorQueryBuilder> build)
    {
        AddField<BillingAttemptUserError, BillingAttemptUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}