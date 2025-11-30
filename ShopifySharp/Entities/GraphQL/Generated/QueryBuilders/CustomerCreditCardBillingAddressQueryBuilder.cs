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

public class CustomerCreditCardBillingAddressQueryBuilder() : GraphQueryBuilder<CustomerCreditCardBillingAddress>("query customerCreditCardBillingAddress")
{
    public CustomerCreditCardBillingAddressQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public CustomerCreditCardBillingAddressQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public CustomerCreditCardBillingAddressQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    public CustomerCreditCardBillingAddressQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public CustomerCreditCardBillingAddressQueryBuilder AddFieldFirstName()
    {
        AddField("firstName");
        return this;
    }

    public CustomerCreditCardBillingAddressQueryBuilder AddFieldLastName()
    {
        AddField("lastName");
        return this;
    }

    public CustomerCreditCardBillingAddressQueryBuilder AddFieldProvince()
    {
        AddField("province");
        return this;
    }

    public CustomerCreditCardBillingAddressQueryBuilder AddFieldProvinceCode()
    {
        AddField("provinceCode");
        return this;
    }

    public CustomerCreditCardBillingAddressQueryBuilder AddFieldZip()
    {
        AddField("zip");
        return this;
    }
}