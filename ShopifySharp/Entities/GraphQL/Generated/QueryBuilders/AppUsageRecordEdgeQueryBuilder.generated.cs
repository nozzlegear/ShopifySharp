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

public class AppUsageRecordEdgeQueryBuilder() : GraphQueryBuilder<AppUsageRecordEdge>("appUsageRecordEdge")
{
    public AppUsageRecordEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public AppUsageRecordEdgeQueryBuilder AddFieldNode(Func<AppUsageRecordQueryBuilder, AppUsageRecordQueryBuilder> build)
    {
        AddField<AppUsageRecord, AppUsageRecordQueryBuilder>("node", build);
        return this;
    }
}