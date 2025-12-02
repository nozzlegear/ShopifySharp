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

public class ProductFeedEdgeQueryBuilder() : GraphQueryBuilder<ProductFeedEdge>("productFeedEdge")
{
    public ProductFeedEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ProductFeedEdgeQueryBuilder AddFieldNode(Func<ProductFeedQueryBuilder, ProductFeedQueryBuilder> build)
    {
        AddField<ProductFeed, ProductFeedQueryBuilder>("node", build);
        return this;
    }
}