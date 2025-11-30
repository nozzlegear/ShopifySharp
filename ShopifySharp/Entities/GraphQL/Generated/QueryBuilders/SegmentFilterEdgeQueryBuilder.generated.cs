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

public class SegmentFilterEdgeQueryBuilder() : GraphQueryBuilder<SegmentFilterEdge>("segmentFilterEdge")
{
    public SegmentFilterEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SegmentFilterEdgeQueryBuilder AddFieldNode(Func<SegmentFilterQueryBuilder, SegmentFilterQueryBuilder> build)
    {
        AddField<ISegmentFilter, SegmentFilterQueryBuilder>("node", build);
        return this;
    }
}