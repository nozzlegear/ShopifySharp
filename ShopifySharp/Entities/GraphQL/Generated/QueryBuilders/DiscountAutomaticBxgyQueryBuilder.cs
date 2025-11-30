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

public class DiscountAutomaticBxgyQueryBuilder() : GraphQueryBuilder<DiscountAutomaticBxgy>("query discountAutomaticBxgy")
{
    public DiscountAutomaticBxgyQueryBuilder AddFieldAsyncUsageCount()
    {
        AddField("asyncUsageCount");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldCombinesWith()
    {
        AddField("combinesWith");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldCustomerBuys()
    {
        AddField("customerBuys");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldCustomerGets()
    {
        AddField("customerGets");
        return this;
    }

    [Obsolete("Use `discountClasses` instead.")]
    public DiscountAutomaticBxgyQueryBuilder AddFieldDiscountClass()
    {
        AddField("discountClass");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldDiscountClasses()
    {
        AddField("discountClasses");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldEndsAt()
    {
        AddField("endsAt");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldEvents()
    {
        AddField("events");
        return this;
    }

    [Obsolete("Use DiscountAutomaticNode.id instead.")]
    public DiscountAutomaticBxgyQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldStartsAt()
    {
        AddField("startsAt");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    [Obsolete("Use `asyncUsageCount` instead.")]
    public DiscountAutomaticBxgyQueryBuilder AddFieldUsageCount()
    {
        AddField("usageCount");
        return this;
    }

    public DiscountAutomaticBxgyQueryBuilder AddFieldUsesPerOrderLimit()
    {
        AddField("usesPerOrderLimit");
        return this;
    }
}