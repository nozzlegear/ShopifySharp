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

public class SuggestedReturnFinancialOutcomeQueryBuilder() : GraphQueryBuilder<SuggestedReturnFinancialOutcome>("query suggestedReturnFinancialOutcome")
{
    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldDiscountedSubtotal()
    {
        AddField("discountedSubtotal");
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldFinancialTransfer()
    {
        AddField("financialTransfer");
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldMaximumRefundable()
    {
        AddField("maximumRefundable");
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldRefundDuties()
    {
        AddField("refundDuties");
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldShipping()
    {
        AddField("shipping");
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldTotalAdditionalFees()
    {
        AddField("totalAdditionalFees");
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldTotalCartDiscountAmount()
    {
        AddField("totalCartDiscountAmount");
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldTotalDuties()
    {
        AddField("totalDuties");
        return this;
    }

    public SuggestedReturnFinancialOutcomeQueryBuilder AddFieldTotalTax()
    {
        AddField("totalTax");
        return this;
    }
}