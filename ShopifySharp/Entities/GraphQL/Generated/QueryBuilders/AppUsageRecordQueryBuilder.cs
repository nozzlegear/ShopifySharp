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

public class AppUsageRecordQueryBuilder() : GraphQueryBuilder<AppUsageRecord>("query appUsageRecord")
{
    public AppUsageRecordQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public AppUsageRecordQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public AppUsageRecordQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AppUsageRecordQueryBuilder AddFieldIdempotencyKey()
    {
        AddField("idempotencyKey");
        return this;
    }

    public AppUsageRecordQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public AppUsageRecordQueryBuilder AddFieldSubscriptionLineItem()
    {
        AddField("subscriptionLineItem");
        return this;
    }
}