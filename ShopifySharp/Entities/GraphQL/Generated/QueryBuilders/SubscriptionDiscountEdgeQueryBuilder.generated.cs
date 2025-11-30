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

public class SubscriptionDiscountEdgeQueryBuilder() : GraphQueryBuilder<SubscriptionDiscountEdge>("subscriptionDiscountEdge")
{
    public SubscriptionDiscountEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SubscriptionDiscountEdgeQueryBuilder AddUnionCaseNode(Func<SubscriptionAppliedCodeDiscountQueryBuilder, SubscriptionAppliedCodeDiscountQueryBuilder> build)
    {
        AddUnion<SubscriptionAppliedCodeDiscount, SubscriptionAppliedCodeDiscountQueryBuilder>("node", build);
        return this;
    }

    public SubscriptionDiscountEdgeQueryBuilder AddUnionCaseNode(Func<SubscriptionManualDiscountQueryBuilder, SubscriptionManualDiscountQueryBuilder> build)
    {
        AddUnion<SubscriptionManualDiscount, SubscriptionManualDiscountQueryBuilder>("node", build);
        return this;
    }
}