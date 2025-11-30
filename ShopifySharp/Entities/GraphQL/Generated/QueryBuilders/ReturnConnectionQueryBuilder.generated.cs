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

public class ReturnConnectionQueryBuilder() : GraphQueryBuilder<ReturnConnection>("returnConnection")
{
    public ReturnConnectionQueryBuilder AddFieldEdges(Func<ReturnEdgeQueryBuilder, ReturnEdgeQueryBuilder> build)
    {
        AddField<ReturnEdge, ReturnEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ReturnConnectionQueryBuilder AddFieldNodes(Func<ReturnQueryBuilder, ReturnQueryBuilder> build)
    {
        AddField<Return, ReturnQueryBuilder>("nodes", build);
        return this;
    }

    public ReturnConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}