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

public class OnlineStoreThemeFileEdgeQueryBuilder() : GraphQueryBuilder<OnlineStoreThemeFileEdge>("onlineStoreThemeFileEdge")
{
    public OnlineStoreThemeFileEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public OnlineStoreThemeFileEdgeQueryBuilder AddFieldNode(Func<OnlineStoreThemeFileQueryBuilder, OnlineStoreThemeFileQueryBuilder> build)
    {
        AddField<OnlineStoreThemeFile, OnlineStoreThemeFileQueryBuilder>("node", build);
        return this;
    }
}