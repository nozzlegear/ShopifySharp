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

public class MailingAddressQueryBuilder() : GraphQueryBuilder<MailingAddress>("query mailingAddress")
{
    public MailingAddressQueryBuilder AddFieldAddress1()
    {
        AddField("address1");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldAddress2()
    {
        AddField("address2");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldCity()
    {
        AddField("city");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldCompany()
    {
        AddField("company");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldCoordinatesValidated()
    {
        AddField("coordinatesValidated");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldCountry()
    {
        AddField("country");
        return this;
    }

    [Obsolete("Use `countryCodeV2` instead.")]
    public MailingAddressQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldCountryCodeV2()
    {
        AddField("countryCodeV2");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldFirstName()
    {
        AddField("firstName");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldFormatted()
    {
        AddField("formatted");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldFormattedArea()
    {
        AddField("formattedArea");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldLastName()
    {
        AddField("lastName");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldLatitude()
    {
        AddField("latitude");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldLongitude()
    {
        AddField("longitude");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldProvince()
    {
        AddField("province");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldProvinceCode()
    {
        AddField("provinceCode");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldTimeZone()
    {
        AddField("timeZone");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldValidationResultSummary()
    {
        AddField("validationResultSummary");
        return this;
    }

    public MailingAddressQueryBuilder AddFieldZip()
    {
        AddField("zip");
        return this;
    }
}