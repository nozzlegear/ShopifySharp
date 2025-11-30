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

public class SuggestedRefundQueryBuilder() : GraphQueryBuilder<SuggestedRefund>("query suggestedRefund")
{
    [Obsolete("Use `amountSet` instead.")]
    public SuggestedRefundQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldAmountSet()
    {
        AddField("amountSet");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldDiscountedSubtotalSet()
    {
        AddField("discountedSubtotalSet");
        return this;
    }

    [Obsolete("Use `maximumRefundableSet` instead.")]
    public SuggestedRefundQueryBuilder AddFieldMaximumRefundable()
    {
        AddField("maximumRefundable");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldMaximumRefundableSet()
    {
        AddField("maximumRefundableSet");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldRefundDuties()
    {
        AddField("refundDuties");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldRefundLineItems()
    {
        AddField("refundLineItems");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldShipping()
    {
        AddField("shipping");
        return this;
    }

    [Obsolete("Use `subtotalSet` instead.")]
    public SuggestedRefundQueryBuilder AddFieldSubtotal()
    {
        AddField("subtotal");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldSubtotalSet()
    {
        AddField("subtotalSet");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldSuggestedRefundMethods()
    {
        AddField("suggestedRefundMethods");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldSuggestedTransactions()
    {
        AddField("suggestedTransactions");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldTotalCartDiscountAmountSet()
    {
        AddField("totalCartDiscountAmountSet");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldTotalDutiesSet()
    {
        AddField("totalDutiesSet");
        return this;
    }

    [Obsolete("Use `totalTaxSet` instead.")]
    public SuggestedRefundQueryBuilder AddFieldTotalTaxes()
    {
        AddField("totalTaxes");
        return this;
    }

    public SuggestedRefundQueryBuilder AddFieldTotalTaxSet()
    {
        AddField("totalTaxSet");
        return this;
    }
}