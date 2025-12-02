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

public class SubscriptionLineEdgeQueryBuilder() : GraphQueryBuilder<SubscriptionLineEdge>("subscriptionLineEdge")
{
    public SubscriptionLineEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SubscriptionLineEdgeQueryBuilder AddFieldNode(Func<SubscriptionLineQueryBuilder, SubscriptionLineQueryBuilder> build)
    {
        AddField<SubscriptionLine, SubscriptionLineQueryBuilder>("node", build);
        return this;
    }
}