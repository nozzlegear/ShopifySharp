#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class AppSubscriptionEdgeQueryBuilder() : GraphQueryBuilder<AppSubscriptionEdge>("query appSubscriptionEdge")
{
    public AppSubscriptionEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public AppSubscriptionEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}