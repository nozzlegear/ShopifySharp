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

public class SuggestedRefundQueryBuilder() : GraphQueryBuilder<SuggestedRefund>("suggestedRefund")
{
    [Obsolete("Use `amountSet` instead.")]
    public SuggestedRefundQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amountSet", build);
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldDiscountedSubtotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedSubtotalSet", build);
        return this;
    }

    [Obsolete("Use `maximumRefundableSet` instead.")]
    public SuggestedRefundQueryBuilder AddFieldMaximumRefundable()
    {
        AddField("maximumRefundable");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldMaximumRefundableSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("maximumRefundableSet", build);
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldRefundDuties(Func<RefundDutyQueryBuilder, RefundDutyQueryBuilder> build)
    {
        AddField<RefundDuty, RefundDutyQueryBuilder>("refundDuties", build);
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldRefundLineItems(Func<RefundLineItemQueryBuilder, RefundLineItemQueryBuilder> build)
    {
        AddField<RefundLineItem, RefundLineItemQueryBuilder>("refundLineItems", build);
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldShipping(Func<ShippingRefundQueryBuilder, ShippingRefundQueryBuilder> build)
    {
        AddField<ShippingRefund, ShippingRefundQueryBuilder>("shipping", build);
        return this;
    }

    [Obsolete("Use `subtotalSet` instead.")]
    public SuggestedRefundQueryBuilder AddFieldSubtotal()
    {
        AddField("subtotal");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldSubtotalSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("subtotalSet", build);
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldSuggestedRefundMethods(Func<SuggestedRefundMethodQueryBuilder, SuggestedRefundMethodQueryBuilder> build)
    {
        AddField<ISuggestedRefundMethod, SuggestedRefundMethodQueryBuilder>("suggestedRefundMethods", build);
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldSuggestedTransactions(Func<SuggestedOrderTransactionQueryBuilder, SuggestedOrderTransactionQueryBuilder> build)
    {
        AddField<SuggestedOrderTransaction, SuggestedOrderTransactionQueryBuilder>("suggestedTransactions", build);
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldTotalCartDiscountAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalCartDiscountAmountSet", build);
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldTotalDutiesSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDutiesSet", build);
        return this;
    }

    [Obsolete("Use `totalTaxSet` instead.")]
    public SuggestedRefundQueryBuilder AddFieldTotalTaxes()
    {
        AddField("totalTaxes");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldTotalTaxSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTaxSet", build);
        return this;
    }
}