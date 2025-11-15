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

public class OnlineStoreThemeEdgeQueryBuilder() : GraphQueryBuilder<OnlineStoreThemeEdge>("query onlineStoreThemeEdge")
{
    public OnlineStoreThemeEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public OnlineStoreThemeEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}