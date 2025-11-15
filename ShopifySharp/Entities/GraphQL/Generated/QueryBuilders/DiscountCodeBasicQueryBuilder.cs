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

public class DiscountCodeBasicQueryBuilder() : GraphQueryBuilder<DiscountCodeBasic>("query discountCodeBasic")
{
    public DiscountCodeBasicQueryBuilder AddFieldAppliesOncePerCustomer()
    {
        AddField("appliesOncePerCustomer");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldAsyncUsageCount()
    {
        AddField("asyncUsageCount");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldCodes()
    {
        AddField("codes");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldCodesCount()
    {
        AddField("codesCount");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldCombinesWith()
    {
        AddField("combinesWith");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldCustomerGets()
    {
        AddField("customerGets");
        return this;
    }

    [Obsolete("Use `context` instead.")]
    public DiscountCodeBasicQueryBuilder AddFieldCustomerSelection()
    {
        AddField("customerSelection");
        return this;
    }

    [Obsolete("Use `discountClasses` instead.")]
    public DiscountCodeBasicQueryBuilder AddFieldDiscountClass()
    {
        AddField("discountClass");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldDiscountClasses()
    {
        AddField("discountClasses");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldEndsAt()
    {
        AddField("endsAt");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldHasTimelineComment()
    {
        AddField("hasTimelineComment");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldMinimumRequirement()
    {
        AddField("minimumRequirement");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldRecurringCycleLimit()
    {
        AddField("recurringCycleLimit");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldShareableUrls()
    {
        AddField("shareableUrls");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldShortSummary()
    {
        AddField("shortSummary");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldStartsAt()
    {
        AddField("startsAt");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldTotalSales()
    {
        AddField("totalSales");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldUsageLimit()
    {
        AddField("usageLimit");
        return this;
    }
}