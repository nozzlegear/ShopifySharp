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

public class ImageConnectionQueryBuilder() : GraphQueryBuilder<ImageConnection>("imageConnection")
{
    public ImageConnectionQueryBuilder AddFieldEdges(Func<ImageEdgeQueryBuilder, ImageEdgeQueryBuilder> build)
    {
        AddField<ImageEdge, ImageEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ImageConnectionQueryBuilder AddFieldNodes(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("nodes", build);
        return this;
    }

    public ImageConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}