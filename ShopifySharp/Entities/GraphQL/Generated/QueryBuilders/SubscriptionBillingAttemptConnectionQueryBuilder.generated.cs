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

public class SubscriptionBillingAttemptConnectionQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttemptConnection>("subscriptionBillingAttemptConnection")
{
    public SubscriptionBillingAttemptConnectionQueryBuilder AddFieldEdges(Func<SubscriptionBillingAttemptEdgeQueryBuilder, SubscriptionBillingAttemptEdgeQueryBuilder> build)
    {
        AddField<SubscriptionBillingAttemptEdge, SubscriptionBillingAttemptEdgeQueryBuilder>("edges", build);
        return this;
    }

    public SubscriptionBillingAttemptConnectionQueryBuilder AddFieldNodes(Func<SubscriptionBillingAttemptQueryBuilder, SubscriptionBillingAttemptQueryBuilder> build)
    {
        AddField<SubscriptionBillingAttempt, SubscriptionBillingAttemptQueryBuilder>("nodes", build);
        return this;
    }

    public SubscriptionBillingAttemptConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}