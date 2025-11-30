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

public class AppSubscriptionLineItemQueryBuilder() : GraphQueryBuilder<AppSubscriptionLineItem>("appSubscriptionLineItem")
{
    public AppSubscriptionLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AppSubscriptionLineItemQueryBuilder AddFieldPlan(Func<AppPlanV2QueryBuilder, AppPlanV2QueryBuilder> build)
    {
        AddField<AppPlanV2, AppPlanV2QueryBuilder>("plan", build);
        return this;
    }

    public AppSubscriptionLineItemQueryBuilder AddFieldUsageRecords(Func<AppUsageRecordConnectionQueryBuilder, AppUsageRecordConnectionQueryBuilder> build)
    {
        AddField<AppUsageRecordConnection, AppUsageRecordConnectionQueryBuilder>("usageRecords", build);
        return this;
    }
}