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

public class CardPaymentDetailsQueryBuilder() : GraphQueryBuilder<CardPaymentDetails>("query cardPaymentDetails")
{
    public CardPaymentDetailsQueryBuilder AddFieldAvsResultCode()
    {
        AddField("avsResultCode");
        return this;
    }

    public CardPaymentDetailsQueryBuilder AddFieldBin()
    {
        AddField("bin");
        return this;
    }

    public CardPaymentDetailsQueryBuilder AddFieldCompany()
    {
        AddField("company");
        return this;
    }

    public CardPaymentDetailsQueryBuilder AddFieldCvvResultCode()
    {
        AddField("cvvResultCode");
        return this;
    }

    public CardPaymentDetailsQueryBuilder AddFieldExpirationMonth()
    {
        AddField("expirationMonth");
        return this;
    }

    public CardPaymentDetailsQueryBuilder AddFieldExpirationYear()
    {
        AddField("expirationYear");
        return this;
    }

    public CardPaymentDetailsQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public CardPaymentDetailsQueryBuilder AddFieldNumber()
    {
        AddField("number");
        return this;
    }

    public CardPaymentDetailsQueryBuilder AddFieldPaymentMethodName()
    {
        AddField("paymentMethodName");
        return this;
    }

    public CardPaymentDetailsQueryBuilder AddFieldWallet()
    {
        AddField("wallet");
        return this;
    }
}