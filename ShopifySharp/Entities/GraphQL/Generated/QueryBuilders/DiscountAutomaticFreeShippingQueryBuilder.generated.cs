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

public class DiscountAutomaticFreeShippingQueryBuilder() : GraphQueryBuilder<DiscountAutomaticFreeShipping>("discountAutomaticFreeShipping")
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

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldCombinesWith(Func<DiscountCombinesWithQueryBuilder, DiscountCombinesWithQueryBuilder> build)
    {
        AddField<DiscountCombinesWith, DiscountCombinesWithQueryBuilder>("combinesWith", build);
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddUnionCaseDestinationSelection(Func<DiscountCountriesQueryBuilder, DiscountCountriesQueryBuilder> build)
    {
        AddUnion<DiscountCountries, DiscountCountriesQueryBuilder>("destinationSelection", build);
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddUnionCaseDestinationSelection(Func<DiscountCountryAllQueryBuilder, DiscountCountryAllQueryBuilder> build)
    {
        AddUnion<DiscountCountryAll, DiscountCountryAllQueryBuilder>("destinationSelection", build);
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

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldMaximumShippingPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("maximumShippingPrice", build);
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddUnionCaseMinimumRequirement(Func<DiscountMinimumQuantityQueryBuilder, DiscountMinimumQuantityQueryBuilder> build)
    {
        AddUnion<DiscountMinimumQuantity, DiscountMinimumQuantityQueryBuilder>("minimumRequirement", build);
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddUnionCaseMinimumRequirement(Func<DiscountMinimumSubtotalQueryBuilder, DiscountMinimumSubtotalQueryBuilder> build)
    {
        AddUnion<DiscountMinimumSubtotal, DiscountMinimumSubtotalQueryBuilder>("minimumRequirement", build);
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

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldTotalSales(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("totalSales", build);
        return this;
    }

    public DiscountAutomaticFreeShippingQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}