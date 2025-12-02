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

public class SegmentConnectionQueryBuilder() : GraphQueryBuilder<SegmentConnection>("segmentConnection")
{
    public SegmentConnectionQueryBuilder AddFieldEdges(Func<SegmentEdgeQueryBuilder, SegmentEdgeQueryBuilder> build)
    {
        AddField<SegmentEdge, SegmentEdgeQueryBuilder>("edges", build);
        return this;
    }

    public SegmentConnectionQueryBuilder AddFieldNodes(Func<SegmentQueryBuilder, SegmentQueryBuilder> build)
    {
        AddField<Segment, SegmentQueryBuilder>("nodes", build);
        return this;
    }

    public SegmentConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}