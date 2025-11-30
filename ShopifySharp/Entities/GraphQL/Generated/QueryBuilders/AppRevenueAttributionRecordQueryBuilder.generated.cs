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

public class AppRevenueAttributionRecordQueryBuilder() : GraphQueryBuilder<AppRevenueAttributionRecord>("appRevenueAttributionRecord")
{
    public AppRevenueAttributionRecordQueryBuilder AddFieldAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amount", build);
        return this;
    }

    public AppRevenueAttributionRecordQueryBuilder AddFieldCapturedAt()
    {
        AddField("capturedAt");
        return this;
    }

    public AppRevenueAttributionRecordQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public AppRevenueAttributionRecordQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AppRevenueAttributionRecordQueryBuilder AddFieldIdempotencyKey()
    {
        AddField("idempotencyKey");
        return this;
    }

    public AppRevenueAttributionRecordQueryBuilder AddFieldTest()
    {
        AddField("test");
        return this;
    }

    public AppRevenueAttributionRecordQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }
}