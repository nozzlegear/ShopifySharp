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

public class DiscountCodeFreeShippingQueryBuilder() : GraphQueryBuilder<DiscountCodeFreeShipping>("discountCodeFreeShipping")
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

    public DiscountCodeFreeShippingQueryBuilder AddFieldCodes(Func<DiscountRedeemCodeConnectionQueryBuilder, DiscountRedeemCodeConnectionQueryBuilder> build)
    {
        AddField<DiscountRedeemCodeConnection, DiscountRedeemCodeConnectionQueryBuilder>("codes", build);
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldCodesCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("codesCount", build);
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldCombinesWith(Func<DiscountCombinesWithQueryBuilder, DiscountCombinesWithQueryBuilder> build)
    {
        AddField<DiscountCombinesWith, DiscountCombinesWithQueryBuilder>("combinesWith", build);
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddUnionCaseCustomerSelection(Func<DiscountCustomerAllQueryBuilder, DiscountCustomerAllQueryBuilder> build)
    {
        AddUnion<DiscountCustomerAll, DiscountCustomerAllQueryBuilder>("customerSelection", build);
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddUnionCaseCustomerSelection(Func<DiscountCustomerSegmentsQueryBuilder, DiscountCustomerSegmentsQueryBuilder> build)
    {
        AddUnion<DiscountCustomerSegments, DiscountCustomerSegmentsQueryBuilder>("customerSelection", build);
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddUnionCaseCustomerSelection(Func<DiscountCustomersQueryBuilder, DiscountCustomersQueryBuilder> build)
    {
        AddUnion<DiscountCustomers, DiscountCustomersQueryBuilder>("customerSelection", build);
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddUnionCaseDestinationSelection(Func<DiscountCountriesQueryBuilder, DiscountCountriesQueryBuilder> build)
    {
        AddUnion<DiscountCountries, DiscountCountriesQueryBuilder>("destinationSelection", build);
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddUnionCaseDestinationSelection(Func<DiscountCountryAllQueryBuilder, DiscountCountryAllQueryBuilder> build)
    {
        AddUnion<DiscountCountryAll, DiscountCountryAllQueryBuilder>("destinationSelection", build);
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

    public DiscountCodeFreeShippingQueryBuilder AddFieldMaximumShippingPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("maximumShippingPrice", build);
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddUnionCaseMinimumRequirement(Func<DiscountMinimumQuantityQueryBuilder, DiscountMinimumQuantityQueryBuilder> build)
    {
        AddUnion<DiscountMinimumQuantity, DiscountMinimumQuantityQueryBuilder>("minimumRequirement", build);
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddUnionCaseMinimumRequirement(Func<DiscountMinimumSubtotalQueryBuilder, DiscountMinimumSubtotalQueryBuilder> build)
    {
        AddUnion<DiscountMinimumSubtotal, DiscountMinimumSubtotalQueryBuilder>("minimumRequirement", build);
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldRecurringCycleLimit()
    {
        AddField("recurringCycleLimit");
        return this;
    }

    public DiscountCodeFreeShippingQueryBuilder AddFieldShareableUrls(Func<DiscountShareableUrlQueryBuilder, DiscountShareableUrlQueryBuilder> build)
    {
        AddField<DiscountShareableUrl, DiscountShareableUrlQueryBuilder>("shareableUrls", build);
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

    public DiscountCodeFreeShippingQueryBuilder AddFieldTotalSales(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("totalSales", build);
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