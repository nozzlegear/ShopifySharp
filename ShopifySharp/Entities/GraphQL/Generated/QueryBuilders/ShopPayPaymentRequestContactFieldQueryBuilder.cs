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

public class ShopPayPaymentRequestContactFieldQueryBuilder() : GraphQueryBuilder<ShopPayPaymentRequestContactField>("query shopPayPaymentRequestContactField")
{
    public ShopPayPaymentRequestContactFieldQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public ShopPayPaymentRequestContactFieldQueryBuilder AddFieldAddress2()
    {
        AddField("address2");
        return this;
    }

    public ShopPayPaymentRequestContactFieldQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public ShopPayPaymentRequestContactFieldQueryBuilder AddFieldCompanyName()
    {
        AddField("companyName");
        return this;
    }

    public ShopPayPaymentRequestContactFieldQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public ShopPayPaymentRequestContactFieldQueryBuilder AddFieldEmail()
    {
        AddField("email");
        return this;
    }

    public ShopPayPaymentRequestContactFieldQueryBuilder AddFieldFirstName()
    {
        AddField("firstName");
        return this;
    }

    public ShopPayPaymentRequestContactFieldQueryBuilder AddFieldLastName()
    {
        AddField("lastName");
        return this;
    }

    public ShopPayPaymentRequestContactFieldQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }

    public ShopPayPaymentRequestContactFieldQueryBuilder AddFieldPostalCode()
    {
        AddField("postalCode");
        return this;
    }

    public ShopPayPaymentRequestContactFieldQueryBuilder AddFieldProvinceCode()
    {
        AddField("provinceCode");
        return this;
    }
}