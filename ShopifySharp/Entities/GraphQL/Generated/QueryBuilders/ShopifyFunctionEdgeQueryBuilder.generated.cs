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

public class ShopifyFunctionEdgeQueryBuilder() : GraphQueryBuilder<ShopifyFunctionEdge>("shopifyFunctionEdge")
{
    public ShopifyFunctionEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ShopifyFunctionEdgeQueryBuilder AddFieldNode(Func<ShopifyFunctionQueryBuilder, ShopifyFunctionQueryBuilder> build)
    {
        AddField<ShopifyFunction, ShopifyFunctionQueryBuilder>("node", build);
        return this;
    }
}