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

public class SuggestedReturnFinancialOutcomeQueryBuilder() : GraphQueryBuilder<SuggestedReturnFinancialOutcome>("suggestedReturnFinancialOutcome")
{
    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldDiscountedSubtotal(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("discountedSubtotal", build);
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddUnionCaseFinancialTransfer(Func<InvoiceReturnOutcomeQueryBuilder, InvoiceReturnOutcomeQueryBuilder> build)
    {
        AddUnion<InvoiceReturnOutcome, InvoiceReturnOutcomeQueryBuilder>("financialTransfer", build);
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddUnionCaseFinancialTransfer(Func<RefundReturnOutcomeQueryBuilder, RefundReturnOutcomeQueryBuilder> build)
    {
        AddUnion<RefundReturnOutcome, RefundReturnOutcomeQueryBuilder>("financialTransfer", build);
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldMaximumRefundable(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("maximumRefundable", build);
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldRefundDuties(Func<RefundDutyQueryBuilder, RefundDutyQueryBuilder> build)
    {
        AddField<RefundDuty, RefundDutyQueryBuilder>("refundDuties", build);
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldShipping(Func<ShippingRefundQueryBuilder, ShippingRefundQueryBuilder> build)
    {
        AddField<ShippingRefund, ShippingRefundQueryBuilder>("shipping", build);
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldTotalAdditionalFees(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalAdditionalFees", build);
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldTotalCartDiscountAmount(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalCartDiscountAmount", build);
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldTotalDuties(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDuties", build);
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldTotalTax(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTax", build);
        return this;
    }
}