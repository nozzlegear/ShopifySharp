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

public class DiscountAutomaticFreeShippingQueryBuilder() : GraphQueryBuilder<DiscountAutomaticFreeShipping>("query discountAutomaticFreeShipping")
{
    public DiscountAutomaticFreeShippingQueryBuilder AddFieldAppliesOnOneTimePurchase()
    {
        AddField("appliesOnOneTimePurchase");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldAppliesOnSubscription()
    {
        AddField("appliesOnSubscription");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldAsyncUsageCount()
    {
        AddField("asyncUsageCount");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldCombinesWith()
    {
        AddField("combinesWith");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldDestinationSelection()
    {
        AddField("destinationSelection");
        return this;
    }

    [Obsolete("Use `discountClasses` instead.")]
    public DiscountAutomaticFreeShippingQueryBuilder AddFieldDiscountClass()
    {
        AddField("discountClass");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldDiscountClasses()
    {
        AddField("discountClasses");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldEndsAt()
    {
        AddField("endsAt");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldHasTimelineComment()
    {
        AddField("hasTimelineComment");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldMaximumShippingPrice()
    {
        AddField("maximumShippingPrice");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldMinimumRequirement()
    {
        AddField("minimumRequirement");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldRecurringCycleLimit()
    {
        AddField("recurringCycleLimit");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldShortSummary()
    {
        AddField("shortSummary");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldStartsAt()
    {
        AddField("startsAt");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldTotalSales()
    {
        AddField("totalSales");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}