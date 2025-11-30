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

public class SubscriptionLineConnectionQueryBuilder() : GraphQueryBuilder<SubscriptionLineConnection>("subscriptionLineConnection")
{
    public SubscriptionLineConnectionQueryBuilder AddFieldEdges(Func<SubscriptionLineEdgeQueryBuilder, SubscriptionLineEdgeQueryBuilder> build)
    {
        AddField<SubscriptionLineEdge, SubscriptionLineEdgeQueryBuilder>("edges", build);
        return this;
    }

    public SubscriptionLineConnectionQueryBuilder AddFieldNodes(Func<SubscriptionLineQueryBuilder, SubscriptionLineQueryBuilder> build)
    {
        AddField<SubscriptionLine, SubscriptionLineQueryBuilder>("nodes", build);
        return this;
    }

    public SubscriptionLineConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}