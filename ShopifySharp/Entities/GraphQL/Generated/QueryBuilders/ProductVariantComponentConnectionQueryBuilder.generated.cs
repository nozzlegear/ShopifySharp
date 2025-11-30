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

public class ProductVariantComponentConnectionQueryBuilder() : GraphQueryBuilder<ProductVariantComponentConnection>("productVariantComponentConnection")
{
    public ProductVariantComponentConnectionQueryBuilder AddFieldEdges(Func<ProductVariantComponentEdgeQueryBuilder, ProductVariantComponentEdgeQueryBuilder> build)
    {
        AddField<ProductVariantComponentEdge, ProductVariantComponentEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ProductVariantComponentConnectionQueryBuilder AddFieldNodes(Func<ProductVariantComponentQueryBuilder, ProductVariantComponentQueryBuilder> build)
    {
        AddField<ProductVariantComponent, ProductVariantComponentQueryBuilder>("nodes", build);
        return this;
    }

    public ProductVariantComponentConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}