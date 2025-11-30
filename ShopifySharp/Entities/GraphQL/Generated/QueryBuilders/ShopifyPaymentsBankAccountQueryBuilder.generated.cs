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

public class ShopifyPaymentsBankAccountQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsBankAccount>("shopifyPaymentsBankAccount")
{
    public ShopifyPaymentsBankAccountQueryBuilder AddFieldAccountNumberLastDigits()
    {
        AddField("accountNumberLastDigits");
        return this;
    }

    public ShopifyPaymentsBankAccountQueryBuilder AddFieldBankName()
    {
        AddField("bankName");
        return this;
    }

    public ShopifyPaymentsBankAccountQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    public ShopifyPaymentsBankAccountQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public ShopifyPaymentsBankAccountQueryBuilder AddFieldCurrency()
    {
        AddField("currency");
        return this;
    }

    public ShopifyPaymentsBankAccountQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ShopifyPaymentsBankAccountQueryBuilder AddFieldPayouts(Func<ShopifyPaymentsPayoutConnectionQueryBuilder, ShopifyPaymentsPayoutConnectionQueryBuilder> build)
    {
        AddField<ShopifyPaymentsPayoutConnection, ShopifyPaymentsPayoutConnectionQueryBuilder>("payouts", build);
        return this;
    }

    public ShopifyPaymentsBankAccountQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}