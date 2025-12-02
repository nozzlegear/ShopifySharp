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

public class AppPurchaseOneTimeConnectionQueryBuilder() : GraphQueryBuilder<AppPurchaseOneTimeConnection>("appPurchaseOneTimeConnection")
{
    public AppPurchaseOneTimeConnectionQueryBuilder AddFieldEdges(Func<AppPurchaseOneTimeEdgeQueryBuilder, AppPurchaseOneTimeEdgeQueryBuilder> build)
    {
        AddField<AppPurchaseOneTimeEdge, AppPurchaseOneTimeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public AppPurchaseOneTimeConnectionQueryBuilder AddFieldNodes(Func<AppPurchaseOneTimeQueryBuilder, AppPurchaseOneTimeQueryBuilder> build)
    {
        AddField<AppPurchaseOneTime, AppPurchaseOneTimeQueryBuilder>("nodes", build);
        return this;
    }

    public AppPurchaseOneTimeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}