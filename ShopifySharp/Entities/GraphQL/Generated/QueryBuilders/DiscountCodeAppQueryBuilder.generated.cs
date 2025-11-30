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

public class DiscountCodeAppQueryBuilder() : GraphQueryBuilder<DiscountCodeApp>("discountCodeApp")
{
    public DiscountCodeAppQueryBuilder AddFieldAppDiscountType(Func<AppDiscountTypeQueryBuilder, AppDiscountTypeQueryBuilder> build)
    {
        AddField<AppDiscountType, AppDiscountTypeQueryBuilder>("appDiscountType", build);
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

    public DiscountCodeAppQueryBuilder AddFieldCodes(Func<DiscountRedeemCodeConnectionQueryBuilder, DiscountRedeemCodeConnectionQueryBuilder> build)
    {
        AddField<DiscountRedeemCodeConnection, DiscountRedeemCodeConnectionQueryBuilder>("codes", build);
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldCodesCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("codesCount", build);
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldCombinesWith(Func<DiscountCombinesWithQueryBuilder, DiscountCombinesWithQueryBuilder> build)
    {
        AddField<DiscountCombinesWith, DiscountCombinesWithQueryBuilder>("combinesWith", build);
        return this;
    }

    public DiscountCodeAppQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public DiscountCodeAppQueryBuilder AddUnionCaseCustomerSelection(Func<DiscountCustomerAllQueryBuilder, DiscountCustomerAllQueryBuilder> build)
    {
        AddUnion<DiscountCustomerAll, DiscountCustomerAllQueryBuilder>("customerSelection", build);
        return this;
    }

    public DiscountCodeAppQueryBuilder AddUnionCaseCustomerSelection(Func<DiscountCustomerSegmentsQueryBuilder, DiscountCustomerSegmentsQueryBuilder> build)
    {
        AddUnion<DiscountCustomerSegments, DiscountCustomerSegmentsQueryBuilder>("customerSelection", build);
        return this;
    }

    public DiscountCodeAppQueryBuilder AddUnionCaseCustomerSelection(Func<DiscountCustomersQueryBuilder, DiscountCustomersQueryBuilder> build)
    {
        AddUnion<DiscountCustomers, DiscountCustomersQueryBuilder>("customerSelection", build);
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

    public DiscountCodeAppQueryBuilder AddFieldErrorHistory(Func<FunctionsErrorHistoryQueryBuilder, FunctionsErrorHistoryQueryBuilder> build)
    {
        AddField<FunctionsErrorHistory, FunctionsErrorHistoryQueryBuilder>("errorHistory", build);
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

    public DiscountCodeAppQueryBuilder AddFieldShareableUrls(Func<DiscountShareableUrlQueryBuilder, DiscountShareableUrlQueryBuilder> build)
    {
        AddField<DiscountShareableUrl, DiscountShareableUrlQueryBuilder>("shareableUrls", build);
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

    public DiscountCodeAppQueryBuilder AddFieldTotalSales(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("totalSales", build);
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