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

public class OnlineStoreThemeConnectionQueryBuilder() : GraphQueryBuilder<OnlineStoreThemeConnection>("onlineStoreThemeConnection")
{
    public OnlineStoreThemeConnectionQueryBuilder AddFieldEdges(Func<OnlineStoreThemeEdgeQueryBuilder, OnlineStoreThemeEdgeQueryBuilder> build)
    {
        AddField<OnlineStoreThemeEdge, OnlineStoreThemeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public OnlineStoreThemeConnectionQueryBuilder AddFieldNodes(Func<OnlineStoreThemeQueryBuilder, OnlineStoreThemeQueryBuilder> build)
    {
        AddField<OnlineStoreTheme, OnlineStoreThemeQueryBuilder>("nodes", build);
        return this;
    }

    public OnlineStoreThemeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}