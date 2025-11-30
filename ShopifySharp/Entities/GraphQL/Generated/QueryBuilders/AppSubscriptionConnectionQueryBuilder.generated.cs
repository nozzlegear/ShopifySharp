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

public class AppSubscriptionConnectionQueryBuilder() : GraphQueryBuilder<AppSubscriptionConnection>("appSubscriptionConnection")
{
    public AppSubscriptionConnectionQueryBuilder AddFieldEdges(Func<AppSubscriptionEdgeQueryBuilder, AppSubscriptionEdgeQueryBuilder> build)
    {
        AddField<AppSubscriptionEdge, AppSubscriptionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public AppSubscriptionConnectionQueryBuilder AddFieldNodes(Func<AppSubscriptionQueryBuilder, AppSubscriptionQueryBuilder> build)
    {
        AddField<AppSubscription, AppSubscriptionQueryBuilder>("nodes", build);
        return this;
    }

    public AppSubscriptionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}