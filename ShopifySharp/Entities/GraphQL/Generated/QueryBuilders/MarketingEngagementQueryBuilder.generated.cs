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

public class MarketingEngagementQueryBuilder() : GraphQueryBuilder<MarketingEngagement>("marketingEngagement")
{
    public MarketingEngagementQueryBuilder AddFieldAdSpend(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("adSpend", build);
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldChannelHandle()
    {
        AddField("channelHandle");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldClicksCount()
    {
        AddField("clicksCount");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldCommentsCount()
    {
        AddField("commentsCount");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldComplaintsCount()
    {
        AddField("complaintsCount");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldFailsCount()
    {
        AddField("failsCount");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldFavoritesCount()
    {
        AddField("favoritesCount");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldFirstTimeCustomers()
    {
        AddField("firstTimeCustomers");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldImpressionsCount()
    {
        AddField("impressionsCount");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldIsCumulative()
    {
        AddField("isCumulative");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldMarketingActivity(Func<MarketingActivityQueryBuilder, MarketingActivityQueryBuilder> build)
    {
        AddField<MarketingActivity, MarketingActivityQueryBuilder>("marketingActivity", build);
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldOccurredOn()
    {
        AddField("occurredOn");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldOrders()
    {
        AddField("orders");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldReturningCustomers()
    {
        AddField("returningCustomers");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldSales(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("sales", build);
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldSendsCount()
    {
        AddField("sendsCount");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldSessionsCount()
    {
        AddField("sessionsCount");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldSharesCount()
    {
        AddField("sharesCount");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldUniqueClicksCount()
    {
        AddField("uniqueClicksCount");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldUniqueViewsCount()
    {
        AddField("uniqueViewsCount");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldUnsubscribesCount()
    {
        AddField("unsubscribesCount");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldUtcOffset()
    {
        AddField("utcOffset");
        return this;
    }

    public MarketingEngagementQueryBuilder AddFieldViewsCount()
    {
        AddField("viewsCount");
        return this;
    }
}