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

public class AppConnectionQueryBuilder() : GraphQueryBuilder<AppConnection>("appConnection")
{
    public AppConnectionQueryBuilder AddFieldEdges(Func<AppEdgeQueryBuilder, AppEdgeQueryBuilder> build)
    {
        AddField<AppEdge, AppEdgeQueryBuilder>("edges", build);
        return this;
    }

    public AppConnectionQueryBuilder AddFieldNodes(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("nodes", build);
        return this;
    }

    public AppConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}