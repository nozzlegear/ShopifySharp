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

public class SubscriptionDiscountConnectionQueryBuilder() : GraphQueryBuilder<SubscriptionDiscountConnection>("subscriptionDiscountConnection")
{
    public SubscriptionDiscountConnectionQueryBuilder AddFieldEdges(Func<SubscriptionDiscountEdgeQueryBuilder, SubscriptionDiscountEdgeQueryBuilder> build)
    {
        AddField<SubscriptionDiscountEdge, SubscriptionDiscountEdgeQueryBuilder>("edges", build);
        return this;
    }

    public SubscriptionDiscountConnectionQueryBuilder AddUnionCaseNodes(Func<SubscriptionAppliedCodeDiscountQueryBuilder, SubscriptionAppliedCodeDiscountQueryBuilder> build)
    {
        AddUnion<SubscriptionAppliedCodeDiscount, SubscriptionAppliedCodeDiscountQueryBuilder>("nodes", build);
        return this;
    }

    public SubscriptionDiscountConnectionQueryBuilder AddUnionCaseNodes(Func<SubscriptionManualDiscountQueryBuilder, SubscriptionManualDiscountQueryBuilder> build)
    {
        AddUnion<SubscriptionManualDiscount, SubscriptionManualDiscountQueryBuilder>("nodes", build);
        return this;
    }

    public SubscriptionDiscountConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}