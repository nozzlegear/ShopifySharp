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

public class SegmentValueConnectionQueryBuilder() : GraphQueryBuilder<SegmentValueConnection>("segmentValueConnection")
{
    public SegmentValueConnectionQueryBuilder AddFieldEdges(Func<SegmentValueEdgeQueryBuilder, SegmentValueEdgeQueryBuilder> build)
    {
        AddField<SegmentValueEdge, SegmentValueEdgeQueryBuilder>("edges", build);
        return this;
    }

    public SegmentValueConnectionQueryBuilder AddFieldNodes(Func<SegmentValueQueryBuilder, SegmentValueQueryBuilder> build)
    {
        AddField<SegmentValue, SegmentValueQueryBuilder>("nodes", build);
        return this;
    }

    public SegmentValueConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}