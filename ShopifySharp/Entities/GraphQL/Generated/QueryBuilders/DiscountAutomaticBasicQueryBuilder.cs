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

public class DiscountAutomaticBasicQueryBuilder() : GraphQueryBuilder<DiscountAutomaticBasic>("query discountAutomaticBasic")
{
    public DiscountAutomaticBasicQueryBuilder AddFieldAsyncUsageCount()
    {
        AddField("asyncUsageCount");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldCombinesWith()
    {
        AddField("combinesWith");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldCustomerGets()
    {
        AddField("customerGets");
        return this;
    }

    [Obsolete("Use `discountClasses` instead.")]
    public DiscountAutomaticBasicQueryBuilder AddFieldDiscountClass()
    {
        AddField("discountClass");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldDiscountClasses()
    {
        AddField("discountClasses");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldEndsAt()
    {
        AddField("endsAt");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldMinimumRequirement()
    {
        AddField("minimumRequirement");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldRecurringCycleLimit()
    {
        AddField("recurringCycleLimit");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldShortSummary()
    {
        AddField("shortSummary");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldStartsAt()
    {
        AddField("startsAt");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public DiscountAutomaticBasicQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    [Obsolete("Use `asyncUsageCount` instead.")]
    public DiscountAutomaticBasicQueryBuilder AddFieldUsageCount()
    {
        AddField("usageCount");
        return this;
    }
}