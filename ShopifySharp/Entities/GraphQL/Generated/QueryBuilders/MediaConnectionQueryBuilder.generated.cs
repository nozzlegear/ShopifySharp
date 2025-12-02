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

public class MediaConnectionQueryBuilder() : GraphQueryBuilder<MediaConnection>("mediaConnection")
{
    public MediaConnectionQueryBuilder AddFieldEdges(Func<MediaEdgeQueryBuilder, MediaEdgeQueryBuilder> build)
    {
        AddField<MediaEdge, MediaEdgeQueryBuilder>("edges", build);
        return this;
    }

    public MediaConnectionQueryBuilder AddFieldNodes(Func<MediaQueryBuilder, MediaQueryBuilder> build)
    {
        AddField<IMedia, MediaQueryBuilder>("nodes", build);
        return this;
    }

    public MediaConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}