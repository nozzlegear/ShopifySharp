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

public class DiscountCodeBxgyQueryBuilder() : GraphQueryBuilder<DiscountCodeBxgy>("query discountCodeBxgy")
{
    public DiscountCodeBxgyQueryBuilder AddFieldAppliesOncePerCustomer()
    {
        AddField("appliesOncePerCustomer");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldAsyncUsageCount()
    {
        AddField("asyncUsageCount");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldCodes()
    {
        AddField("codes");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldCodesCount()
    {
        AddField("codesCount");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldCombinesWith()
    {
        AddField("combinesWith");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldCustomerBuys()
    {
        AddField("customerBuys");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldCustomerGets()
    {
        AddField("customerGets");
        return this;
    }

    [Obsolete("Use `context` instead.")]
    public DiscountCodeBxgyQueryBuilder AddFieldCustomerSelection()
    {
        AddField("customerSelection");
        return this;
    }

    [Obsolete("Use `discountClasses` instead.")]
    public DiscountCodeBxgyQueryBuilder AddFieldDiscountClass()
    {
        AddField("discountClass");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldDiscountClasses()
    {
        AddField("discountClasses");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldEndsAt()
    {
        AddField("endsAt");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldHasTimelineComment()
    {
        AddField("hasTimelineComment");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldShareableUrls()
    {
        AddField("shareableUrls");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldStartsAt()
    {
        AddField("startsAt");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldTotalSales()
    {
        AddField("totalSales");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldUsageLimit()
    {
        AddField("usageLimit");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldUsesPerOrderLimit()
    {
        AddField("usesPerOrderLimit");
        return this;
    }
}