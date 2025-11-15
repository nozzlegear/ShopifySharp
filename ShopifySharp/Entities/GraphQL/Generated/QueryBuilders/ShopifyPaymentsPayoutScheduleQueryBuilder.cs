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

public class ShopifyPaymentsPayoutScheduleQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsPayoutSchedule>("query shopifyPaymentsPayoutSchedule")
{
    public ShopifyPaymentsPayoutScheduleQueryBuilder AddFieldInterval()
    {
        AddField("interval");
        return this;
    }

    public ShopifyPaymentsPayoutScheduleQueryBuilder AddFieldMonthlyAnchor()
    {
        AddField("monthlyAnchor");
        return this;
    }

    public ShopifyPaymentsPayoutScheduleQueryBuilder AddFieldWeeklyAnchor()
    {
        AddField("weeklyAnchor");
        return this;
    }
}