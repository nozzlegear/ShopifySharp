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

public class AppSubscriptionLineItemQueryBuilder() : GraphQueryBuilder<AppSubscriptionLineItem>("query appSubscriptionLineItem")
{
    public AppSubscriptionLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AppSubscriptionLineItemQueryBuilder AddFieldPlan()
    {
        AddField("plan");
        return this;
    }

    public AppSubscriptionLineItemQueryBuilder AddFieldUsageRecords()
    {
        AddField("usageRecords");
        return this;
    }
}