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

public class DiscountCodeBxgyQueryBuilder() : GraphQueryBuilder<DiscountCodeBxgy>("discountCodeBxgy")
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

    public DiscountCodeBxgyQueryBuilder AddFieldCodes(Func<DiscountRedeemCodeConnectionQueryBuilder, DiscountRedeemCodeConnectionQueryBuilder> build)
    {
        AddField<DiscountRedeemCodeConnection, DiscountRedeemCodeConnectionQueryBuilder>("codes", build);
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldCodesCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("codesCount", build);
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldCombinesWith(Func<DiscountCombinesWithQueryBuilder, DiscountCombinesWithQueryBuilder> build)
    {
        AddField<DiscountCombinesWith, DiscountCombinesWithQueryBuilder>("combinesWith", build);
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldCustomerBuys(Func<DiscountCustomerBuysQueryBuilder, DiscountCustomerBuysQueryBuilder> build)
    {
        AddField<DiscountCustomerBuys, DiscountCustomerBuysQueryBuilder>("customerBuys", build);
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddFieldCustomerGets(Func<DiscountCustomerGetsQueryBuilder, DiscountCustomerGetsQueryBuilder> build)
    {
        AddField<DiscountCustomerGets, DiscountCustomerGetsQueryBuilder>("customerGets", build);
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddUnionCaseCustomerSelection(Func<DiscountCustomerAllQueryBuilder, DiscountCustomerAllQueryBuilder> build)
    {
        AddUnion<DiscountCustomerAll, DiscountCustomerAllQueryBuilder>("customerSelection", build);
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddUnionCaseCustomerSelection(Func<DiscountCustomerSegmentsQueryBuilder, DiscountCustomerSegmentsQueryBuilder> build)
    {
        AddUnion<DiscountCustomerSegments, DiscountCustomerSegmentsQueryBuilder>("customerSelection", build);
        return this;
    }

    public DiscountCodeBxgyQueryBuilder AddUnionCaseCustomerSelection(Func<DiscountCustomersQueryBuilder, DiscountCustomersQueryBuilder> build)
    {
        AddUnion<DiscountCustomers, DiscountCustomersQueryBuilder>("customerSelection", build);
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

    public DiscountCodeBxgyQueryBuilder AddFieldShareableUrls(Func<DiscountShareableUrlQueryBuilder, DiscountShareableUrlQueryBuilder> build)
    {
        AddField<DiscountShareableUrl, DiscountShareableUrlQueryBuilder>("shareableUrls", build);
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

    public DiscountCodeBxgyQueryBuilder AddFieldTotalSales(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("totalSales", build);
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