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

public class AppUsageRecordQueryBuilder() : GraphQueryBuilder<AppUsageRecord>("appUsageRecord")
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

    public AppUsageRecordQueryBuilder AddFieldPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("price", build);
        return this;
    }

    public AppUsageRecordQueryBuilder AddFieldSubscriptionLineItem(Func<AppSubscriptionLineItemQueryBuilder, AppSubscriptionLineItemQueryBuilder> build)
    {
        AddField<AppSubscriptionLineItem, AppSubscriptionLineItemQueryBuilder>("subscriptionLineItem", build);
        return this;
    }
}