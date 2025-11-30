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

public class VaultCreditCardQueryBuilder() : GraphQueryBuilder<VaultCreditCard>("query vaultCreditCard")
{
    public VaultCreditCardQueryBuilder AddFieldBillingAddress()
    {
        AddField("billingAddress");
        return this;
    }

    public VaultCreditCardQueryBuilder AddFieldBrand()
    {
        AddField("brand");
        return this;
    }

    public VaultCreditCardQueryBuilder AddFieldExpired()
    {
        AddField("expired");
        return this;
    }

    public VaultCreditCardQueryBuilder AddFieldExpiryMonth()
    {
        AddField("expiryMonth");
        return this;
    }

    public VaultCreditCardQueryBuilder AddFieldExpiryYear()
    {
        AddField("expiryYear");
        return this;
    }

    public VaultCreditCardQueryBuilder AddFieldLastDigits()
    {
        AddField("lastDigits");
        return this;
    }

    public VaultCreditCardQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }
}