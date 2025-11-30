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

public class DiscountCodeAppQueryBuilder() : GraphQueryBuilder<DiscountCodeApp>("query discountCodeApp")
{
    public DiscountCodeAppQueryBuilder AddFieldAppDiscountType()
    {
        AddField("appDiscountType");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldAppliesOncePerCustomer()
    {
        AddField("appliesOncePerCustomer");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldAppliesOnOneTimePurchase()
    {
        AddField("appliesOnOneTimePurchase");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldAppliesOnSubscription()
    {
        AddField("appliesOnSubscription");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldAsyncUsageCount()
    {
        AddField("asyncUsageCount");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldCodes()
    {
        AddField("codes");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldCodesCount()
    {
        AddField("codesCount");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldCombinesWith()
    {
        AddField("combinesWith");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    [Obsolete("Use `context` instead.")]
    public DiscountCodeAppQueryBuilder AddFieldCustomerSelection()
    {
        AddField("customerSelection");
        return this;
    }

    [Obsolete("Use `discountClasses` instead.")]
    public DiscountCodeAppQueryBuilder AddFieldDiscountClass()
    {
        AddField("discountClass");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldDiscountClasses()
    {
        AddField("discountClasses");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldDiscountId()
    {
        AddField("discountId");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldEndsAt()
    {
        AddField("endsAt");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldErrorHistory()
    {
        AddField("errorHistory");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldHasTimelineComment()
    {
        AddField("hasTimelineComment");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldRecurringCycleLimit()
    {
        AddField("recurringCycleLimit");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldShareableUrls()
    {
        AddField("shareableUrls");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldStartsAt()
    {
        AddField("startsAt");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldTotalSales()
    {
        AddField("totalSales");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldUsageLimit()
    {
        AddField("usageLimit");
        return this;
    }
}