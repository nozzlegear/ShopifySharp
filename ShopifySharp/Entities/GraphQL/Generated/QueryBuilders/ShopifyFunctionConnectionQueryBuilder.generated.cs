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

public class ShopifyFunctionConnectionQueryBuilder() : GraphQueryBuilder<ShopifyFunctionConnection>("shopifyFunctionConnection")
{
    public ShopifyFunctionConnectionQueryBuilder AddFieldEdges(Func<ShopifyFunctionEdgeQueryBuilder, ShopifyFunctionEdgeQueryBuilder> build)
    {
        AddField<ShopifyFunctionEdge, ShopifyFunctionEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ShopifyFunctionConnectionQueryBuilder AddFieldNodes(Func<ShopifyFunctionQueryBuilder, ShopifyFunctionQueryBuilder> build)
    {
        AddField<ShopifyFunction, ShopifyFunctionQueryBuilder>("nodes", build);
        return this;
    }

    public ShopifyFunctionConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}