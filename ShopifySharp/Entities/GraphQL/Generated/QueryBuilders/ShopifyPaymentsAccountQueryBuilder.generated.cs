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

public class ShopifyPaymentsAccountQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsAccount>("shopifyPaymentsAccount")
{
    public ShopifyPaymentsAccountQueryBuilder AddFieldAccountOpenerName()
    {
        AddField("accountOpenerName");
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldActivated()
    {
        AddField("activated");
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldBalance(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("balance", build);
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldBalanceTransactions(Func<ShopifyPaymentsBalanceTransactionConnectionQueryBuilder, ShopifyPaymentsBalanceTransactionConnectionQueryBuilder> build)
    {
        AddField<ShopifyPaymentsBalanceTransactionConnection, ShopifyPaymentsBalanceTransactionConnectionQueryBuilder>("balanceTransactions", build);
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldBankAccounts(Func<ShopifyPaymentsBankAccountConnectionQueryBuilder, ShopifyPaymentsBankAccountConnectionQueryBuilder> build)
    {
        AddField<ShopifyPaymentsBankAccountConnection, ShopifyPaymentsBankAccountConnectionQueryBuilder>("bankAccounts", build);
        return this;
    }

    [Obsolete("Use `chargeStatementDescriptors` instead.")]
    public ShopifyPaymentsAccountQueryBuilder AddFieldChargeStatementDescriptor()
    {
        AddField("chargeStatementDescriptor");
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldChargeStatementDescriptors(Func<ShopifyPaymentsChargeStatementDescriptorQueryBuilder, ShopifyPaymentsChargeStatementDescriptorQueryBuilder> build)
    {
        AddField<IShopifyPaymentsChargeStatementDescriptor, ShopifyPaymentsChargeStatementDescriptorQueryBuilder>("chargeStatementDescriptors", build);
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldDefaultCurrency()
    {
        AddField("defaultCurrency");
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldDisputes(Func<ShopifyPaymentsDisputeConnectionQueryBuilder, ShopifyPaymentsDisputeConnectionQueryBuilder> build)
    {
        AddField<ShopifyPaymentsDisputeConnection, ShopifyPaymentsDisputeConnectionQueryBuilder>("disputes", build);
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldOnboardable()
    {
        AddField("onboardable");
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldPayouts(Func<ShopifyPaymentsPayoutConnectionQueryBuilder, ShopifyPaymentsPayoutConnectionQueryBuilder> build)
    {
        AddField<ShopifyPaymentsPayoutConnection, ShopifyPaymentsPayoutConnectionQueryBuilder>("payouts", build);
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldPayoutSchedule(Func<ShopifyPaymentsPayoutScheduleQueryBuilder, ShopifyPaymentsPayoutScheduleQueryBuilder> build)
    {
        AddField<ShopifyPaymentsPayoutSchedule, ShopifyPaymentsPayoutScheduleQueryBuilder>("payoutSchedule", build);
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldPayoutStatementDescriptor()
    {
        AddField("payoutStatementDescriptor");
        return this;
    }
}