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

public class VaultCreditCardQueryBuilder() : GraphQueryBuilder<VaultCreditCard>("vaultCreditCard")
{
    public VaultCreditCardQueryBuilder AddFieldBillingAddress(Func<CustomerCreditCardBillingAddressQueryBuilder, CustomerCreditCardBillingAddressQueryBuilder> build)
    {
        AddField<CustomerCreditCardBillingAddress, CustomerCreditCardBillingAddressQueryBuilder>("billingAddress", build);
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