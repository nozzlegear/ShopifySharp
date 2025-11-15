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

public class LocationSuggestedAddressQueryBuilder() : GraphQueryBuilder<LocationSuggestedAddress>("query locationSuggestedAddress")
{
    public LocationSuggestedAddressQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public LocationSuggestedAddressQueryBuilder AddFieldAddress2()
    {
        AddField("address2");
        return this;
    }

    public LocationSuggestedAddressQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public LocationSuggestedAddressQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    public LocationSuggestedAddressQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public LocationSuggestedAddressQueryBuilder AddFieldFormatted()
    {
        AddField("formatted");
        return this;
    }

    public LocationSuggestedAddressQueryBuilder AddFieldProvince()
    {
        AddField("province");
        return this;
    }

    public LocationSuggestedAddressQueryBuilder AddFieldProvinceCode()
    {
        AddField("provinceCode");
        return this;
    }

    public LocationSuggestedAddressQueryBuilder AddFieldZip()
    {
        AddField("zip");
        return this;
    }
}