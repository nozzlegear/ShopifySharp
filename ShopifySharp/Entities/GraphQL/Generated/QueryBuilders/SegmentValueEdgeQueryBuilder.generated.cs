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

public class SegmentValueEdgeQueryBuilder() : GraphQueryBuilder<SegmentValueEdge>("segmentValueEdge")
{
    public SegmentValueEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SegmentValueEdgeQueryBuilder AddFieldNode(Func<SegmentValueQueryBuilder, SegmentValueQueryBuilder> build)
    {
        AddField<SegmentValue, SegmentValueQueryBuilder>("node", build);
        return this;
    }
}