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

public class MediaEdgeQueryBuilder() : GraphQueryBuilder<MediaEdge>("mediaEdge")
{
    public MediaEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MediaEdgeQueryBuilder AddFieldNode(Func<MediaQueryBuilder, MediaQueryBuilder> build)
    {
        AddField<IMedia, MediaQueryBuilder>("node", build);
        return this;
    }
}