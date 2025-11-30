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

public class OnlineStoreThemeFileConnectionQueryBuilder() : GraphQueryBuilder<OnlineStoreThemeFileConnection>("onlineStoreThemeFileConnection")
{
    public OnlineStoreThemeFileConnectionQueryBuilder AddFieldEdges(Func<OnlineStoreThemeFileEdgeQueryBuilder, OnlineStoreThemeFileEdgeQueryBuilder> build)
    {
        AddField<OnlineStoreThemeFileEdge, OnlineStoreThemeFileEdgeQueryBuilder>("edges", build);
        return this;
    }

    public OnlineStoreThemeFileConnectionQueryBuilder AddFieldNodes(Func<OnlineStoreThemeFileQueryBuilder, OnlineStoreThemeFileQueryBuilder> build)
    {
        AddField<OnlineStoreThemeFile, OnlineStoreThemeFileQueryBuilder>("nodes", build);
        return this;
    }

    public OnlineStoreThemeFileConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }

    public OnlineStoreThemeFileConnectionQueryBuilder AddFieldUserErrors(Func<OnlineStoreThemeFileReadResultQueryBuilder, OnlineStoreThemeFileReadResultQueryBuilder> build)
    {
        AddField<OnlineStoreThemeFileReadResult, OnlineStoreThemeFileReadResultQueryBuilder>("userErrors", build);
        return this;
    }
}