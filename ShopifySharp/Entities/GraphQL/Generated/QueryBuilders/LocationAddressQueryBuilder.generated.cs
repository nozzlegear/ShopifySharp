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

public class LocationAddressQueryBuilder() : GraphQueryBuilder<LocationAddress>("locationAddress")
{
    public LocationAddressQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public LocationAddressQueryBuilder AddFieldAddress2()
    {
        AddField("address2");
        return this;
    }

    public LocationAddressQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public LocationAddressQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    public LocationAddressQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public LocationAddressQueryBuilder AddFieldFormatted()
    {
        AddField("formatted");
        return this;
    }

    public LocationAddressQueryBuilder AddFieldLatitude()
    {
        AddField("latitude");
        return this;
    }

    public LocationAddressQueryBuilder AddFieldLongitude()
    {
        AddField("longitude");
        return this;
    }

    public LocationAddressQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }

    public LocationAddressQueryBuilder AddFieldProvince()
    {
        AddField("province");
        return this;
    }

    public LocationAddressQueryBuilder AddFieldProvinceCode()
    {
        AddField("provinceCode");
        return this;
    }

    public LocationAddressQueryBuilder AddFieldZip()
    {
        AddField("zip");
        return this;
    }
}