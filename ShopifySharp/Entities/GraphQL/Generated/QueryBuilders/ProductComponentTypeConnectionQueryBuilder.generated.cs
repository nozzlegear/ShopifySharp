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

public class ProductComponentTypeConnectionQueryBuilder() : GraphQueryBuilder<ProductComponentTypeConnection>("productComponentTypeConnection")
{
    public ProductComponentTypeConnectionQueryBuilder AddFieldEdges(Func<ProductComponentTypeEdgeQueryBuilder, ProductComponentTypeEdgeQueryBuilder> build)
    {
        AddField<ProductComponentTypeEdge, ProductComponentTypeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ProductComponentTypeConnectionQueryBuilder AddFieldNodes(Func<ProductComponentTypeQueryBuilder, ProductComponentTypeQueryBuilder> build)
    {
        AddField<ProductComponentType, ProductComponentTypeQueryBuilder>("nodes", build);
        return this;
    }

    public ProductComponentTypeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}