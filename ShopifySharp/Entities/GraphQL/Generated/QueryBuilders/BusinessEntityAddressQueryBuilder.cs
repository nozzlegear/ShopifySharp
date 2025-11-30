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

public class BusinessEntityAddressQueryBuilder() : GraphQueryBuilder<BusinessEntityAddress>("query businessEntityAddress")
{
    public BusinessEntityAddressQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public BusinessEntityAddressQueryBuilder AddFieldAddress2()
    {
        AddField("address2");
        return this;
    }

    public BusinessEntityAddressQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public BusinessEntityAddressQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public BusinessEntityAddressQueryBuilder AddFieldProvince()
    {
        AddField("province");
        return this;
    }

    public BusinessEntityAddressQueryBuilder AddFieldZip()
    {
        AddField("zip");
        return this;
    }
}