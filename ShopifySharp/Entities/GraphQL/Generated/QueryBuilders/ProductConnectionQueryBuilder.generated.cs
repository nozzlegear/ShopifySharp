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

public class ProductConnectionQueryBuilder() : GraphQueryBuilder<ProductConnection>("productConnection")
{
    public ProductConnectionQueryBuilder AddFieldEdges(Func<ProductEdgeQueryBuilder, ProductEdgeQueryBuilder> build)
    {
        AddField<ProductEdge, ProductEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ProductConnectionQueryBuilder AddFieldNodes(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("nodes", build);
        return this;
    }

    public ProductConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}