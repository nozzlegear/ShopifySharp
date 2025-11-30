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

public class DraftOrderAppliedDiscountQueryBuilder() : GraphQueryBuilder<DraftOrderAppliedDiscount>("query draftOrderAppliedDiscount")
{
    [Obsolete("Use `amountSet` instead.")]
    public DraftOrderAppliedDiscountQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public DraftOrderAppliedDiscountQueryBuilder AddFieldAmountSet()
    {
        AddField("amountSet");
        return this;
    }

    [Obsolete("Use `amountSet` instead.")]
    public DraftOrderAppliedDiscountQueryBuilder AddFieldAmountV2()
    {
        AddField("amountV2");
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