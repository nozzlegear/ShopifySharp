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

public class AppRevenueAttributionRecordConnectionQueryBuilder() : GraphQueryBuilder<AppRevenueAttributionRecordConnection>("appRevenueAttributionRecordConnection")
{
    public AppRevenueAttributionRecordConnectionQueryBuilder AddFieldEdges(Func<AppRevenueAttributionRecordEdgeQueryBuilder, AppRevenueAttributionRecordEdgeQueryBuilder> build)
    {
        AddField<AppRevenueAttributionRecordEdge, AppRevenueAttributionRecordEdgeQueryBuilder>("edges", build);
        return this;
    }

    public AppRevenueAttributionRecordConnectionQueryBuilder AddFieldNodes(Func<AppRevenueAttributionRecordQueryBuilder, AppRevenueAttributionRecordQueryBuilder> build)
    {
        AddField<AppRevenueAttributionRecord, AppRevenueAttributionRecordQueryBuilder>("nodes", build);
        return this;
    }

    public AppRevenueAttributionRecordConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}