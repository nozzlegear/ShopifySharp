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

public class SubscriptionManualDiscountQueryBuilder() : GraphQueryBuilder<SubscriptionManualDiscount>("query subscriptionManualDiscount")
{
    public SubscriptionManualDiscountQueryBuilder AddFieldEntitledLines()
    {
        AddField("entitledLines");
        return this;
    }

    public SubscriptionManualDiscountQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SubscriptionManualDiscountQueryBuilder AddFieldRecurringCycleLimit()
    {
        AddField("recurringCycleLimit");
        return this;
    }

    public SubscriptionManualDiscountQueryBuilder AddFieldRejectionReason()
    {
        AddField("rejectionReason");
        return this;
    }

    public SubscriptionManualDiscountQueryBuilder AddFieldTargetType()
    {
        AddField("targetType");
        return this;
    }

    public SubscriptionManualDiscountQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public SubscriptionManualDiscountQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public SubscriptionManualDiscountQueryBuilder AddFieldUsageCount()
    {
        AddField("usageCount");
        return this;
    }

    public SubscriptionManualDiscountQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}