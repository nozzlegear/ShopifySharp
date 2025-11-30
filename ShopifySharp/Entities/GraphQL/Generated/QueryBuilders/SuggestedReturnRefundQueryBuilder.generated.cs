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

public class SuggestedReturnRefundQueryBuilder() : GraphQueryBuilder<SuggestedReturnRefund>("suggestedReturnRefund")
{
    public SuggestedReturnRefundQueryBuilder AddFieldAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amount", build);
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldDiscountedSubtotal(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedSubtotal", build);
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldMaximumRefundable(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("maximumRefundable", build);
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldRefundDuties(Func<RefundDutyQueryBuilder, RefundDutyQueryBuilder> build)
    {
        AddField<RefundDuty, RefundDutyQueryBuilder>("refundDuties", build);
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldShipping(Func<ShippingRefundQueryBuilder, ShippingRefundQueryBuilder> build)
    {
        AddField<ShippingRefund, ShippingRefundQueryBuilder>("shipping", build);
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldSubtotal(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("subtotal", build);
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldSuggestedTransactions(Func<SuggestedOrderTransactionQueryBuilder, SuggestedOrderTransactionQueryBuilder> build)
    {
        AddField<SuggestedOrderTransaction, SuggestedOrderTransactionQueryBuilder>("suggestedTransactions", build);
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldTotalCartDiscountAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalCartDiscountAmount", build);
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldTotalDuties(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDuties", build);
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldTotalTax(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTax", build);
        return this;
    }
}