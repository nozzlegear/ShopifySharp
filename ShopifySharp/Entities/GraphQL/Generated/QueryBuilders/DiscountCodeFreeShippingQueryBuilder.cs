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

public class DiscountCodeFreeShippingQueryBuilder() : GraphQueryBuilder<DiscountCodeFreeShipping>("query discountCodeFreeShipping")
{
    public DiscountCodeFreeShippingQueryBuilder AddFieldAppliesOncePerCustomer()
    {
        AddField("appliesOncePerCustomer");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldAppliesOnOneTimePurchase()
    {
        AddField("appliesOnOneTimePurchase");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldAppliesOnSubscription()
    {
        AddField("appliesOnSubscription");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldAsyncUsageCount()
    {
        AddField("asyncUsageCount");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldCodes()
    {
        AddField("codes");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldCodesCount()
    {
        AddField("codesCount");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldCombinesWith()
    {
        AddField("combinesWith");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    [Obsolete("Use `context` instead.")]
    public DiscountCodeFreeShippingQueryBuilder AddFieldCustomerSelection()
    {
        AddField("customerSelection");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldDestinationSelection()
    {
        AddField("destinationSelection");
        return this;
    }

    [Obsolete("Use `discountClasses` instead.")]
    public DiscountCodeFreeShippingQueryBuilder AddFieldDiscountClass()
    {
        AddField("discountClass");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldDiscountClasses()
    {
        AddField("discountClasses");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldEndsAt()
    {
        AddField("endsAt");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldHasTimelineComment()
    {
        AddField("hasTimelineComment");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldMaximumShippingPrice()
    {
        AddField("maximumShippingPrice");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldMinimumRequirement()
    {
        AddField("minimumRequirement");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldRecurringCycleLimit()
    {
        AddField("recurringCycleLimit");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldShareableUrls()
    {
        AddField("shareableUrls");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldShortSummary()
    {
        AddField("shortSummary");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldStartsAt()
    {
        AddField("startsAt");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldTotalSales()
    {
        AddField("totalSales");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldUsageLimit()
    {
        AddField("usageLimit");
        return this;
    }
}