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

public class SuggestedReturnRefundQueryBuilder() : GraphQueryBuilder<SuggestedReturnRefund>("query suggestedReturnRefund")
{
    public SuggestedReturnRefundQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldDiscountedSubtotal()
    {
        AddField("discountedSubtotal");
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldMaximumRefundable()
    {
        AddField("maximumRefundable");
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldRefundDuties()
    {
        AddField("refundDuties");
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldShipping()
    {
        AddField("shipping");
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldSubtotal()
    {
        AddField("subtotal");
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldSuggestedTransactions()
    {
        AddField("suggestedTransactions");
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldTotalCartDiscountAmount()
    {
        AddField("totalCartDiscountAmount");
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldTotalDuties()
    {
        AddField("totalDuties");
        return this;
    }

    public SuggestedReturnRefundQueryBuilder AddFieldTotalTax()
    {
        AddField("totalTax");
        return this;
    }
}