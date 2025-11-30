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

public class SubscriptionManualDiscountConnectionQueryBuilder() : GraphQueryBuilder<SubscriptionManualDiscountConnection>("subscriptionManualDiscountConnection")
{
    public SubscriptionManualDiscountConnectionQueryBuilder AddFieldEdges(Func<SubscriptionManualDiscountEdgeQueryBuilder, SubscriptionManualDiscountEdgeQueryBuilder> build)
    {
        AddField<SubscriptionManualDiscountEdge, SubscriptionManualDiscountEdgeQueryBuilder>("edges", build);
        return this;
    }

    public SubscriptionManualDiscountConnectionQueryBuilder AddFieldNodes(Func<SubscriptionManualDiscountQueryBuilder, SubscriptionManualDiscountQueryBuilder> build)
    {
        AddField<SubscriptionManualDiscount, SubscriptionManualDiscountQueryBuilder>("nodes", build);
        return this;
    }

    public SubscriptionManualDiscountConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}