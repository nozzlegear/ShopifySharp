#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class AppRevenueAttributionRecordQueryBuilder() : GraphQueryBuilder<AppRevenueAttributionRecord>("query appRevenueAttributionRecord")
{
    public AppRevenueAttributionRecordQueryBuilder AddFieldAmount()
    {
        AddField("amount");
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