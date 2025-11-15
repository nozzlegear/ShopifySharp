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

public class CompanyAddressQueryBuilder() : GraphQueryBuilder<CompanyAddress>("query companyAddress")
{
    public CompanyAddressQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldAddress2()
    {
        AddField("address2");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldCompanyName()
    {
        AddField("companyName");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldFirstName()
    {
        AddField("firstName");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldFormattedAddress()
    {
        AddField("formattedAddress");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldFormattedArea()
    {
        AddField("formattedArea");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldLastName()
    {
        AddField("lastName");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldProvince()
    {
        AddField("province");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldRecipient()
    {
        AddField("recipient");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldZip()
    {
        AddField("zip");
        return this;
    }

    public CompanyAddressQueryBuilder AddFieldZoneCode()
    {
        AddField("zoneCode");
        return this;
    }
}