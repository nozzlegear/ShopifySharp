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

public class ShopifyPaymentsAccountQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsAccount>("query shopifyPaymentsAccount")
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

    public ShopifyPaymentsAccountQueryBuilder AddFieldBalance()
    {
        AddField("balance");
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldBalanceTransactions()
    {
        AddField("balanceTransactions");
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldBankAccounts()
    {
        AddField("bankAccounts");
        return this;
    }

    [Obsolete("Use `chargeStatementDescriptors` instead.")]
    public ShopifyPaymentsAccountQueryBuilder AddFieldChargeStatementDescriptor()
    {
        AddField("chargeStatementDescriptor");
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldChargeStatementDescriptors()
    {
        AddField("chargeStatementDescriptors");
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

    public ShopifyPaymentsAccountQueryBuilder AddFieldDisputes()
    {
        AddField("disputes");
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

    public ShopifyPaymentsAccountQueryBuilder AddFieldPayouts()
    {
        AddField("payouts");
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldPayoutSchedule()
    {
        AddField("payoutSchedule");
        return this;
    }

    public ShopifyPaymentsAccountQueryBuilder AddFieldPayoutStatementDescriptor()
    {
        AddField("payoutStatementDescriptor");
        return this;
    }
}