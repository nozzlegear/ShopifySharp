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

public class OrderTransactionQueryBuilder() : GraphQueryBuilder<OrderTransaction>("orderTransaction")
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

    public OrderTransactionQueryBuilder AddFieldAmountRoundingSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amountRoundingSet", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("amountSet", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldAmountV2(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("amountV2", build);
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

    public OrderTransactionQueryBuilder AddFieldCurrencyExchangeAdjustment(Func<CurrencyExchangeAdjustmentQueryBuilder, CurrencyExchangeAdjustmentQueryBuilder> build)
    {
        AddField<CurrencyExchangeAdjustment, CurrencyExchangeAdjustmentQueryBuilder>("currencyExchangeAdjustment", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldDevice(Func<PointOfSaleDeviceQueryBuilder, PointOfSaleDeviceQueryBuilder> build)
    {
        AddField<PointOfSaleDevice, PointOfSaleDeviceQueryBuilder>("device", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldErrorCode()
    {
        AddField("errorCode");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldFees(Func<TransactionFeeQueryBuilder, TransactionFeeQueryBuilder> build)
    {
        AddField<TransactionFee, TransactionFeeQueryBuilder>("fees", build);
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

    public OrderTransactionQueryBuilder AddFieldLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("location", build);
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

    public OrderTransactionQueryBuilder AddFieldMaximumRefundableV2(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("maximumRefundableV2", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldMultiCapturable()
    {
        AddField("multiCapturable");
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldParentTransaction(Func<OrderTransactionQueryBuilder, OrderTransactionQueryBuilder> build)
    {
        AddField<OrderTransaction, OrderTransactionQueryBuilder>("parentTransaction", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddUnionCasePaymentDetails(Func<CardPaymentDetailsQueryBuilder, CardPaymentDetailsQueryBuilder> build)
    {
        AddUnion<CardPaymentDetails, CardPaymentDetailsQueryBuilder>("paymentDetails", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddUnionCasePaymentDetails(Func<LocalPaymentMethodsPaymentDetailsQueryBuilder, LocalPaymentMethodsPaymentDetailsQueryBuilder> build)
    {
        AddUnion<LocalPaymentMethodsPaymentDetails, LocalPaymentMethodsPaymentDetailsQueryBuilder>("paymentDetails", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddUnionCasePaymentDetails(Func<PaypalWalletPaymentDetailsQueryBuilder, PaypalWalletPaymentDetailsQueryBuilder> build)
    {
        AddUnion<PaypalWalletPaymentDetails, PaypalWalletPaymentDetailsQueryBuilder>("paymentDetails", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddUnionCasePaymentDetails(Func<ShopPayInstallmentsPaymentDetailsQueryBuilder, ShopPayInstallmentsPaymentDetailsQueryBuilder> build)
    {
        AddUnion<ShopPayInstallmentsPaymentDetails, ShopPayInstallmentsPaymentDetailsQueryBuilder>("paymentDetails", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldPaymentIcon(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("paymentIcon", build);
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

    public OrderTransactionQueryBuilder AddFieldShopifyPaymentsSet(Func<ShopifyPaymentsTransactionSetQueryBuilder, ShopifyPaymentsTransactionSetQueryBuilder> build)
    {
        AddField<ShopifyPaymentsTransactionSet, ShopifyPaymentsTransactionSetQueryBuilder>("shopifyPaymentsSet", build);
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

    public OrderTransactionQueryBuilder AddFieldTotalUnsettledSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalUnsettledSet", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldTotalUnsettledV2(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("totalUnsettledV2", build);
        return this;
    }

    public OrderTransactionQueryBuilder AddFieldUser(Func<StaffMemberQueryBuilder, StaffMemberQueryBuilder> build)
    {
        AddField<StaffMember, StaffMemberQueryBuilder>("user", build);
        return this;
    }
}