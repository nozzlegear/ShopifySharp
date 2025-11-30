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

public class SuggestedOrderTransactionQueryBuilder() : GraphQueryBuilder<SuggestedOrderTransaction>("suggestedOrderTransaction")
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

    public SuggestedOrderTransactionQueryBuilder AddFieldAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amountSet", build);
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

    public SuggestedOrderTransactionQueryBuilder AddFieldMaximumRefundableSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("maximumRefundableSet", build);
        return this;
    }

    public SuggestedOrderTransactionQueryBuilder AddFieldParentTransaction(Func<OrderTransactionQueryBuilder, OrderTransactionQueryBuilder> build)
    {
        AddField<OrderTransaction, OrderTransactionQueryBuilder>("parentTransaction", build);
        return this;
    }

    public SuggestedOrderTransactionQueryBuilder AddUnionCasePaymentDetails(Func<CardPaymentDetailsQueryBuilder, CardPaymentDetailsQueryBuilder> build)
    {
        AddUnion<CardPaymentDetails, CardPaymentDetailsQueryBuilder>("paymentDetails", build);
        return this;
    }

    public SuggestedOrderTransactionQueryBuilder AddUnionCasePaymentDetails(Func<LocalPaymentMethodsPaymentDetailsQueryBuilder, LocalPaymentMethodsPaymentDetailsQueryBuilder> build)
    {
        AddUnion<LocalPaymentMethodsPaymentDetails, LocalPaymentMethodsPaymentDetailsQueryBuilder>("paymentDetails", build);
        return this;
    }

    public SuggestedOrderTransactionQueryBuilder AddUnionCasePaymentDetails(Func<PaypalWalletPaymentDetailsQueryBuilder, PaypalWalletPaymentDetailsQueryBuilder> build)
    {
        AddUnion<PaypalWalletPaymentDetails, PaypalWalletPaymentDetailsQueryBuilder>("paymentDetails", build);
        return this;
    }

    public SuggestedOrderTransactionQueryBuilder AddUnionCasePaymentDetails(Func<ShopPayInstallmentsPaymentDetailsQueryBuilder, ShopPayInstallmentsPaymentDetailsQueryBuilder> build)
    {
        AddUnion<ShopPayInstallmentsPaymentDetails, ShopPayInstallmentsPaymentDetailsQueryBuilder>("paymentDetails", build);
        return this;
    }
}