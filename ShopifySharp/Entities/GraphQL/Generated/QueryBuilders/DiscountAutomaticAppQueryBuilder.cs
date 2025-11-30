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

public class DiscountAutomaticAppQueryBuilder() : GraphQueryBuilder<DiscountAutomaticApp>("query discountAutomaticApp")
{
    public DiscountAutomaticAppQueryBuilder AddFieldAppDiscountType()
    {
        AddField("appDiscountType");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldAppliesOnOneTimePurchase()
    {
        AddField("appliesOnOneTimePurchase");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldAppliesOnSubscription()
    {
        AddField("appliesOnSubscription");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldAsyncUsageCount()
    {
        AddField("asyncUsageCount");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldCombinesWith()
    {
        AddField("combinesWith");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    [Obsolete("Use `discountClasses` instead.")]
    public DiscountAutomaticAppQueryBuilder AddFieldDiscountClass()
    {
        AddField("discountClass");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldDiscountClasses()
    {
        AddField("discountClasses");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldDiscountId()
    {
        AddField("discountId");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldEndsAt()
    {
        AddField("endsAt");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldErrorHistory()
    {
        AddField("errorHistory");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldRecurringCycleLimit()
    {
        AddField("recurringCycleLimit");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldStartsAt()
    {
        AddField("startsAt");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public DiscountAutomaticAppQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}