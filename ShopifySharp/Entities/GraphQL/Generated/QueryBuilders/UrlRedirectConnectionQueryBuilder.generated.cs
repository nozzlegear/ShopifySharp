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

public class UrlRedirectConnectionQueryBuilder() : GraphQueryBuilder<UrlRedirectConnection>("urlRedirectConnection")
{
    public UrlRedirectConnectionQueryBuilder AddFieldEdges(Func<UrlRedirectEdgeQueryBuilder, UrlRedirectEdgeQueryBuilder> build)
    {
        AddField<UrlRedirectEdge, UrlRedirectEdgeQueryBuilder>("edges", build);
        return this;
    }

    public UrlRedirectConnectionQueryBuilder AddFieldNodes(Func<UrlRedirectQueryBuilder, UrlRedirectQueryBuilder> build)
    {
        AddField<UrlRedirect, UrlRedirectQueryBuilder>("nodes", build);
        return this;
    }

    public UrlRedirectConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}