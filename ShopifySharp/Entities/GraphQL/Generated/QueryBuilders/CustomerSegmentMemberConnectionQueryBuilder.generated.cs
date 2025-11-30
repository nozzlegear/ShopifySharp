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

public class CustomerSegmentMemberConnectionQueryBuilder() : GraphQueryBuilder<CustomerSegmentMemberConnection>("customerSegmentMemberConnection")
{
    public CustomerSegmentMemberConnectionQueryBuilder AddFieldEdges(Func<CustomerSegmentMemberEdgeQueryBuilder, CustomerSegmentMemberEdgeQueryBuilder> build)
    {
        AddField<CustomerSegmentMemberEdge, CustomerSegmentMemberEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CustomerSegmentMemberConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }

    public CustomerSegmentMemberConnectionQueryBuilder AddFieldStatistics(Func<SegmentStatisticsQueryBuilder, SegmentStatisticsQueryBuilder> build)
    {
        AddField<SegmentStatistics, SegmentStatisticsQueryBuilder>("statistics", build);
        return this;
    }

    public CustomerSegmentMemberConnectionQueryBuilder AddFieldTotalCount()
    {
        AddField("totalCount");
        return this;
    }
}