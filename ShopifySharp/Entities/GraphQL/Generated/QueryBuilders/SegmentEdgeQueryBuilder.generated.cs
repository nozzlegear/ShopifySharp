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

public class SegmentEdgeQueryBuilder() : GraphQueryBuilder<SegmentEdge>("segmentEdge")
{
    public SegmentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SegmentEdgeQueryBuilder AddFieldNode(Func<SegmentQueryBuilder, SegmentQueryBuilder> build)
    {
        AddField<Segment, SegmentQueryBuilder>("node", build);
        return this;
    }
}