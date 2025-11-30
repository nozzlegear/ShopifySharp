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

public class SuggestedOrderTransactionQueryBuilder() : GraphQueryBuilder<SuggestedOrderTransaction>("query suggestedOrderTransaction")
{
    public SuggestedOrderTransactionQueryBuilder AddFieldAccountNumber()
    {
        AddField("accountNumber");
        return this;
    }

    [Obsolete("Use `amountSet` instead.")]
    public SuggestedOrderTransactionQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public SuggestedOrderTransactionQueryBuilder AddFieldAmountSet()
    {
        AddField("amountSet");
        return this;
    }

    public SuggestedOrderTransactionQueryBuilder AddFieldFormattedGateway()
    {
        AddField("formattedGateway");
        return this;
    }

    public SuggestedOrderTransactionQueryBuilder AddFieldGateway()
    {
        AddField("gateway");
        return this;
    }

    public SuggestedOrderTransactionQueryBuilder AddFieldKind()
    {
        AddField("kind");
        return this;
    }

    [Obsolete("Use `maximumRefundableSet` instead.")]
    public SuggestedOrderTransactionQueryBuilder AddFieldMaximumRefundable()
    {
        AddField("maximumRefundable");
        return this;
    }

    public SuggestedOrderTransactionQueryBuilder AddFieldMaximumRefundableSet()
    {
        AddField("maximumRefundableSet");
        return this;
    }

    public SuggestedOrderTransactionQueryBuilder AddFieldParentTransaction()
    {
        AddField("parentTransaction");
        return this;
    }

    public SuggestedOrderTransactionQueryBuilder AddFieldPaymentDetails()
    {
        AddField("paymentDetails");
        return this;
    }
}