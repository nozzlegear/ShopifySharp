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

public class LineItemConnectionQueryBuilder() : GraphQueryBuilder<LineItemConnection>("lineItemConnection")
{
    public LineItemConnectionQueryBuilder AddFieldEdges(Func<LineItemEdgeQueryBuilder, LineItemEdgeQueryBuilder> build)
    {
        AddField<LineItemEdge, LineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public LineItemConnectionQueryBuilder AddFieldNodes(Func<LineItemQueryBuilder, LineItemQueryBuilder> build)
    {
        AddField<LineItem, LineItemQueryBuilder>("nodes", build);
        return this;
    }

    public LineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}