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

public class AppSubscriptionQueryBuilder() : GraphQueryBuilder<AppSubscription>("appSubscription")
{
    public AppSubscriptionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public AppSubscriptionQueryBuilder AddFieldCurrentPeriodEnd()
    {
        AddField("currentPeriodEnd");
        return this;
    }

    public AppSubscriptionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AppSubscriptionQueryBuilder AddFieldLineItems(Func<AppSubscriptionLineItemQueryBuilder, AppSubscriptionLineItemQueryBuilder> build)
    {
        AddField<AppSubscriptionLineItem, AppSubscriptionLineItemQueryBuilder>("lineItems", build);
        return this;
    }

    public AppSubscriptionQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public AppSubscriptionQueryBuilder AddFieldReturnUrl()
    {
        AddField("returnUrl");
        return this;
    }

    public AppSubscriptionQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public AppSubscriptionQueryBuilder AddFieldTest()
    {
        AddField("test");
        return this;
    }

    public AppSubscriptionQueryBuilder AddFieldTrialDays()
    {
        AddField("trialDays");
        return this;
    }
}