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

public class CustomerPaymentInstrumentBillingAddressQueryBuilder() : GraphQueryBuilder<CustomerPaymentInstrumentBillingAddress>("customerPaymentInstrumentBillingAddress")
{
    public CustomerPaymentInstrumentBillingAddressQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public CustomerPaymentInstrumentBillingAddressQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public CustomerPaymentInstrumentBillingAddressQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    public CustomerPaymentInstrumentBillingAddressQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public CustomerPaymentInstrumentBillingAddressQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public CustomerPaymentInstrumentBillingAddressQueryBuilder AddFieldProvince()
    {
        AddField("province");
        return this;
    }

    public CustomerPaymentInstrumentBillingAddressQueryBuilder AddFieldProvinceCode()
    {
        AddField("provinceCode");
        return this;
    }

    public CustomerPaymentInstrumentBillingAddressQueryBuilder AddFieldZip()
    {
        AddField("zip");
        return this;
    }
}