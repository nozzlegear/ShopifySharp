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

public class DraftOrderPlatformDiscountQueryBuilder() : GraphQueryBuilder<DraftOrderPlatformDiscount>("draftOrderPlatformDiscount")
{
    public DraftOrderPlatformDiscountQueryBuilder AddFieldAllocations(Func<DraftOrderPlatformDiscountAllocationQueryBuilder, DraftOrderPlatformDiscountAllocationQueryBuilder> build)
    {
        AddField<DraftOrderPlatformDiscountAllocation, DraftOrderPlatformDiscountAllocationQueryBuilder>("allocations", build);
        return this;
    }

    public DraftOrderPlatformDiscountQueryBuilder AddFieldAutomaticDiscount()
    {
        AddField("automaticDiscount");
        return this;
    }

    public DraftOrderPlatformDiscountQueryBuilder AddFieldBxgyDiscount()
    {
        AddField("bxgyDiscount");
        return this;
    }

    public DraftOrderPlatformDiscountQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    [Obsolete("Use `discountClasses` instead.")]
    public DraftOrderPlatformDiscountQueryBuilder AddFieldDiscountClass()
    {
        AddField("discountClass");
        return this;
    }

    public DraftOrderPlatformDiscountQueryBuilder AddFieldDiscountClasses()
    {
        AddField("discountClasses");
        return this;
    }

    public DraftOrderPlatformDiscountQueryBuilder AddFieldDiscountNode(Func<DiscountNodeQueryBuilder, DiscountNodeQueryBuilder> build)
    {
        AddField<DiscountNode, DiscountNodeQueryBuilder>("discountNode", build);
        return this;
    }

    public DraftOrderPlatformDiscountQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DraftOrderPlatformDiscountQueryBuilder AddFieldPresentationLevel()
    {
        AddField("presentationLevel");
        return this;
    }

    public DraftOrderPlatformDiscountQueryBuilder AddFieldShortSummary()
    {
        AddField("shortSummary");
        return this;
    }

    public DraftOrderPlatformDiscountQueryBuilder AddFieldSummary()
    {
        AddField("summary");
        return this;
    }

    public DraftOrderPlatformDiscountQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public DraftOrderPlatformDiscountQueryBuilder AddFieldTotalAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("totalAmount", build);
        return this;
    }

    public DraftOrderPlatformDiscountQueryBuilder AddFieldTotalAmountPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalAmountPriceSet", build);
        return this;
    }
}