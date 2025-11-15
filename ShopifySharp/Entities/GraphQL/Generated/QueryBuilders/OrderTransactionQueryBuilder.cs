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

public class OrderTransactionQueryBuilder() : GraphQueryBuilder<OrderTransaction>("query orderTransaction")
{
    public OrderTransactionQueryBuilder AddFieldAccountNumber()
    {
        AddField("accountNumber");
        return this;
    }

    [Obsolete("Use `amountSet` instead.")]
    public OrderTransactionQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldAmountRoundingSet()
    {
        AddField("amountRoundingSet");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldAmountSet()
    {
        AddField("amountSet");
        return this;
    }

    [Obsolete("Use `amountSet` instead.")]
    public OrderTransactionQueryBuilder AddFieldAmountV2()
    {
        AddField("amountV2");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldAuthorizationCode()
    {
        AddField("authorizationCode");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldAuthorizationExpiresAt()
    {
        AddField("authorizationExpiresAt");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldCurrencyExchangeAdjustment()
    {
        AddField("currencyExchangeAdjustment");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldDevice()
    {
        AddField("device");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldErrorCode()
    {
        AddField("errorCode");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldFees()
    {
        AddField("fees");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldFormattedGateway()
    {
        AddField("formattedGateway");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldGateway()
    {
        AddField("gateway");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldKind()
    {
        AddField("kind");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldManuallyCapturable()
    {
        AddField("manuallyCapturable");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldManualPaymentGateway()
    {
        AddField("manualPaymentGateway");
        return this;
    }

    [Obsolete("Use `maximumRefundableV2` instead.")]
    public OrderTransactionQueryBuilder AddFieldMaximumRefundable()
    {
        AddField("maximumRefundable");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldMaximumRefundableV2()
    {
        AddField("maximumRefundableV2");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldMultiCapturable()
    {
        AddField("multiCapturable");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldParentTransaction()
    {
        AddField("parentTransaction");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldPaymentDetails()
    {
        AddField("paymentDetails");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldPaymentIcon()
    {
        AddField("paymentIcon");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldPaymentId()
    {
        AddField("paymentId");
        return this;
    }

    [Obsolete("Use `paymentIcon` instead.")]
    public OrderTransactionQueryBuilder AddFieldPaymentMethod()
    {
        AddField("paymentMethod");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldProcessedAt()
    {
        AddField("processedAt");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldReceiptJson()
    {
        AddField("receiptJson");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldSettlementCurrency()
    {
        AddField("settlementCurrency");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldSettlementCurrencyRate()
    {
        AddField("settlementCurrencyRate");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldShopifyPaymentsSet()
    {
        AddField("shopifyPaymentsSet");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldTest()
    {
        AddField("test");
        return this;
    }

    [Obsolete("Use `totalUnsettledSet` instead.")]
    public OrderTransactionQueryBuilder AddFieldTotalUnsettled()
    {
        AddField("totalUnsettled");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldTotalUnsettledSet()
    {
        AddField("totalUnsettledSet");
        return this;
    }

    [Obsolete("Use `totalUnsettledSet` instead.")]
    public OrderTransactionQueryBuilder AddFieldTotalUnsettledV2()
    {
        AddField("totalUnsettledV2");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldUser()
    {
        AddField("user");
        return this;
    }
}