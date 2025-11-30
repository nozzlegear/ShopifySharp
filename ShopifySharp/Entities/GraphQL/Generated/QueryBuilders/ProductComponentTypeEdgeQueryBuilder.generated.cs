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

public class ProductComponentTypeEdgeQueryBuilder() : GraphQueryBuilder<ProductComponentTypeEdge>("productComponentTypeEdge")
{
    public ProductComponentTypeEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ProductComponentTypeEdgeQueryBuilder AddFieldNode(Func<ProductComponentTypeQueryBuilder, ProductComponentTypeQueryBuilder> build)
    {
        AddField<ProductComponentType, ProductComponentTypeQueryBuilder>("node", build);
        return this;
    }
}