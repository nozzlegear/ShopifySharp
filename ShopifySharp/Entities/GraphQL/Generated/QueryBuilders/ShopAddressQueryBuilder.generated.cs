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

public class ShopAddressQueryBuilder() : GraphQueryBuilder<ShopAddress>("shopAddress")
{
    public ShopAddressQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldAddress2()
    {
        AddField("address2");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldCompany()
    {
        AddField("company");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldCoordinatesValidated()
    {
        AddField("coordinatesValidated");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    [Obsolete("Use `countryCodeV2` instead.")]
    public ShopAddressQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldCountryCodeV2()
    {
        AddField("countryCodeV2");
        return this;
    }

    [Obsolete("Always null in this context.")]
    public ShopAddressQueryBuilder AddFieldFirstName()
    {
        AddField("firstName");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldFormatted()
    {
        AddField("formatted");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldFormattedArea()
    {
        AddField("formattedArea");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    [Obsolete("Always null in this context.")]
    public ShopAddressQueryBuilder AddFieldLastName()
    {
        AddField("lastName");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldLatitude()
    {
        AddField("latitude");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldLongitude()
    {
        AddField("longitude");
        return this;
    }

    [Obsolete("Always null in this context.")]
    public ShopAddressQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldProvince()
    {
        AddField("province");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldProvinceCode()
    {
        AddField("provinceCode");
        return this;
    }

    public ShopAddressQueryBuilder AddFieldZip()
    {
        AddField("zip");
        return this;
    }
}