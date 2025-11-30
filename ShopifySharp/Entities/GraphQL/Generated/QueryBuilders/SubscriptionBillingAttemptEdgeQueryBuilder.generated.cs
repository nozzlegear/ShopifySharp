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

public class SubscriptionBillingAttemptEdgeQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttemptEdge>("subscriptionBillingAttemptEdge")
{
    public SubscriptionBillingAttemptEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SubscriptionBillingAttemptEdgeQueryBuilder AddFieldNode(Func<SubscriptionBillingAttemptQueryBuilder, SubscriptionBillingAttemptQueryBuilder> build)
    {
        AddField<SubscriptionBillingAttempt, SubscriptionBillingAttemptQueryBuilder>("node", build);
        return this;
    }
}