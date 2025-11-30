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

public class DiscountCodeBasicQueryBuilder() : GraphQueryBuilder<DiscountCodeBasic>("discountCodeBasic")
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

    public DiscountCodeBasicQueryBuilder AddFieldCodes(Func<DiscountRedeemCodeConnectionQueryBuilder, DiscountRedeemCodeConnectionQueryBuilder> build)
    {
        AddField<DiscountRedeemCodeConnection, DiscountRedeemCodeConnectionQueryBuilder>("codes", build);
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldCodesCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("codesCount", build);
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldCombinesWith(Func<DiscountCombinesWithQueryBuilder, DiscountCombinesWithQueryBuilder> build)
    {
        AddField<DiscountCombinesWith, DiscountCombinesWithQueryBuilder>("combinesWith", build);
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldCustomerGets(Func<DiscountCustomerGetsQueryBuilder, DiscountCustomerGetsQueryBuilder> build)
    {
        AddField<DiscountCustomerGets, DiscountCustomerGetsQueryBuilder>("customerGets", build);
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddUnionCaseCustomerSelection(Func<DiscountCustomerAllQueryBuilder, DiscountCustomerAllQueryBuilder> build)
    {
        AddUnion<DiscountCustomerAll, DiscountCustomerAllQueryBuilder>("customerSelection", build);
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddUnionCaseCustomerSelection(Func<DiscountCustomerSegmentsQueryBuilder, DiscountCustomerSegmentsQueryBuilder> build)
    {
        AddUnion<DiscountCustomerSegments, DiscountCustomerSegmentsQueryBuilder>("customerSelection", build);
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddUnionCaseCustomerSelection(Func<DiscountCustomersQueryBuilder, DiscountCustomersQueryBuilder> build)
    {
        AddUnion<DiscountCustomers, DiscountCustomersQueryBuilder>("customerSelection", build);
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

    public DiscountCodeBasicQueryBuilder AddUnionCaseMinimumRequirement(Func<DiscountMinimumQuantityQueryBuilder, DiscountMinimumQuantityQueryBuilder> build)
    {
        AddUnion<DiscountMinimumQuantity, DiscountMinimumQuantityQueryBuilder>("minimumRequirement", build);
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddUnionCaseMinimumRequirement(Func<DiscountMinimumSubtotalQueryBuilder, DiscountMinimumSubtotalQueryBuilder> build)
    {
        AddUnion<DiscountMinimumSubtotal, DiscountMinimumSubtotalQueryBuilder>("minimumRequirement", build);
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldRecurringCycleLimit()
    {
        AddField("recurringCycleLimit");
        return this;
    }

    public DiscountCodeBasicQueryBuilder AddFieldShareableUrls(Func<DiscountShareableUrlQueryBuilder, DiscountShareableUrlQueryBuilder> build)
    {
        AddField<DiscountShareableUrl, DiscountShareableUrlQueryBuilder>("shareableUrls", build);
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

    public DiscountCodeBasicQueryBuilder AddFieldTotalSales(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("totalSales", build);
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