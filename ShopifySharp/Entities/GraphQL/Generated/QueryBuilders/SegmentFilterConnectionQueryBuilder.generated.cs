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

public class SegmentFilterConnectionQueryBuilder() : GraphQueryBuilder<SegmentFilterConnection>("segmentFilterConnection")
{
    public SegmentFilterConnectionQueryBuilder AddFieldEdges(Func<SegmentFilterEdgeQueryBuilder, SegmentFilterEdgeQueryBuilder> build)
    {
        AddField<SegmentFilterEdge, SegmentFilterEdgeQueryBuilder>("edges", build);
        return this;
    }

    public SegmentFilterConnectionQueryBuilder AddFieldNodes(Func<SegmentFilterQueryBuilder, SegmentFilterQueryBuilder> build)
    {
        AddField<ISegmentFilter, SegmentFilterQueryBuilder>("nodes", build);
        return this;
    }

    public SegmentFilterConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}