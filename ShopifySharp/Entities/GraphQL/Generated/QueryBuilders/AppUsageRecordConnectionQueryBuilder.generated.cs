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

public class AppUsageRecordConnectionQueryBuilder() : GraphQueryBuilder<AppUsageRecordConnection>("appUsageRecordConnection")
{
    public AppUsageRecordConnectionQueryBuilder AddFieldEdges(Func<AppUsageRecordEdgeQueryBuilder, AppUsageRecordEdgeQueryBuilder> build)
    {
        AddField<AppUsageRecordEdge, AppUsageRecordEdgeQueryBuilder>("edges", build);
        return this;
    }

    public AppUsageRecordConnectionQueryBuilder AddFieldNodes(Func<AppUsageRecordQueryBuilder, AppUsageRecordQueryBuilder> build)
    {
        AddField<AppUsageRecord, AppUsageRecordQueryBuilder>("nodes", build);
        return this;
    }

    public AppUsageRecordConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}