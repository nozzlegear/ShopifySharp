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

public class CartTransformConnectionQueryBuilder() : GraphQueryBuilder<CartTransformConnection>("cartTransformConnection")
{
    public CartTransformConnectionQueryBuilder AddFieldEdges(Func<CartTransformEdgeQueryBuilder, CartTransformEdgeQueryBuilder> build)
    {
        AddField<CartTransformEdge, CartTransformEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CartTransformConnectionQueryBuilder AddFieldNodes(Func<CartTransformQueryBuilder, CartTransformQueryBuilder> build)
    {
        AddField<CartTransform, CartTransformQueryBuilder>("nodes", build);
        return this;
    }

    public CartTransformConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}