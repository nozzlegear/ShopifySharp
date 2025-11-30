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

public class ProductFeedConnectionQueryBuilder() : GraphQueryBuilder<ProductFeedConnection>("productFeedConnection")
{
    public ProductFeedConnectionQueryBuilder AddFieldEdges(Func<ProductFeedEdgeQueryBuilder, ProductFeedEdgeQueryBuilder> build)
    {
        AddField<ProductFeedEdge, ProductFeedEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ProductFeedConnectionQueryBuilder AddFieldNodes(Func<ProductFeedQueryBuilder, ProductFeedQueryBuilder> build)
    {
        AddField<ProductFeed, ProductFeedQueryBuilder>("nodes", build);
        return this;
    }

    public ProductFeedConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}