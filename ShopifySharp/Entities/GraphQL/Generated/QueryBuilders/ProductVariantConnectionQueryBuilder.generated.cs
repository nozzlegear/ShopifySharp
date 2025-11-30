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

public class ProductVariantConnectionQueryBuilder() : GraphQueryBuilder<ProductVariantConnection>("productVariantConnection")
{
    public ProductVariantConnectionQueryBuilder AddFieldEdges(Func<ProductVariantEdgeQueryBuilder, ProductVariantEdgeQueryBuilder> build)
    {
        AddField<ProductVariantEdge, ProductVariantEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ProductVariantConnectionQueryBuilder AddFieldNodes(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("nodes", build);
        return this;
    }

    public ProductVariantConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}