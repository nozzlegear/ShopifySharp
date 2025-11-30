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

public class CustomerCreditCardQueryBuilder() : GraphQueryBuilder<CustomerCreditCard>("customerCreditCard")
{
    public CustomerCreditCardQueryBuilder AddFieldBillingAddress(Func<CustomerCreditCardBillingAddressQueryBuilder, CustomerCreditCardBillingAddressQueryBuilder> build)
    {
        AddField<CustomerCreditCardBillingAddress, CustomerCreditCardBillingAddressQueryBuilder>("billingAddress", build);
        return this;
    }

    public CustomerCreditCardQueryBuilder AddFieldBrand()
    {
        AddField("brand");
        return this;
    }

    public CustomerCreditCardQueryBuilder AddFieldExpiresSoon()
    {
        AddField("expiresSoon");
        return this;
    }

    public CustomerCreditCardQueryBuilder AddFieldExpiryMonth()
    {
        AddField("expiryMonth");
        return this;
    }

    public CustomerCreditCardQueryBuilder AddFieldExpiryYear()
    {
        AddField("expiryYear");
        return this;
    }

    public CustomerCreditCardQueryBuilder AddFieldFirstDigits()
    {
        AddField("firstDigits");
        return this;
    }

    public CustomerCreditCardQueryBuilder AddFieldIsRevocable()
    {
        AddField("isRevocable");
        return this;
    }

    public CustomerCreditCardQueryBuilder AddFieldLastDigits()
    {
        AddField("lastDigits");
        return this;
    }

    public CustomerCreditCardQueryBuilder AddFieldMaskedNumber()
    {
        AddField("maskedNumber");
        return this;
    }

    public CustomerCreditCardQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public CustomerCreditCardQueryBuilder AddFieldSource()
    {
        AddField("source");
        return this;
    }

    public CustomerCreditCardQueryBuilder AddFieldVirtualLastDigits()
    {
        AddField("virtualLastDigits");
        return this;
    }
}