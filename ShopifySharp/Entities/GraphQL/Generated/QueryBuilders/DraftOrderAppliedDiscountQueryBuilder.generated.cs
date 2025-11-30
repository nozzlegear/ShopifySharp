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

public class DraftOrderAppliedDiscountQueryBuilder() : GraphQueryBuilder<DraftOrderAppliedDiscount>("draftOrderAppliedDiscount")
{
    [Obsolete("Use `amountSet` instead.")]
    public DraftOrderAppliedDiscountQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public DraftOrderAppliedDiscountQueryBuilder AddFieldAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amountSet", build);
        return this;
    }

    public DraftOrderAppliedDiscountQueryBuilder AddFieldAmountV2(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amountV2", build);
        return this;
    }

    public DraftOrderAppliedDiscountQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public DraftOrderAppliedDiscountQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public DraftOrderAppliedDiscountQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }

    public DraftOrderAppliedDiscountQueryBuilder AddFieldValueType()
    {
        AddField("valueType");
        return this;
    }
}