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

public class ProductVariantPricePairConnectionQueryBuilder() : GraphQueryBuilder<ProductVariantPricePairConnection>("productVariantPricePairConnection")
{
    public ProductVariantPricePairConnectionQueryBuilder AddFieldEdges(Func<ProductVariantPricePairEdgeQueryBuilder, ProductVariantPricePairEdgeQueryBuilder> build)
    {
        AddField<ProductVariantPricePairEdge, ProductVariantPricePairEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ProductVariantPricePairConnectionQueryBuilder AddFieldNodes(Func<ProductVariantPricePairQueryBuilder, ProductVariantPricePairQueryBuilder> build)
    {
        AddField<ProductVariantPricePair, ProductVariantPricePairQueryBuilder>("nodes", build);
        return this;
    }

    public ProductVariantPricePairConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}