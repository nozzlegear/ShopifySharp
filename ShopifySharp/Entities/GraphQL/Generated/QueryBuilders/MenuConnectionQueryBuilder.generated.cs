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

public class MenuConnectionQueryBuilder() : GraphQueryBuilder<MenuConnection>("menuConnection")
{
    public MenuConnectionQueryBuilder AddFieldEdges(Func<MenuEdgeQueryBuilder, MenuEdgeQueryBuilder> build)
    {
        AddField<MenuEdge, MenuEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MenuConnectionQueryBuilder AddFieldNodes(Func<MenuQueryBuilder, MenuQueryBuilder> build)
    {
        AddField<Menu, MenuQueryBuilder>("nodes", build);
        return this;
    }

    public MenuConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}