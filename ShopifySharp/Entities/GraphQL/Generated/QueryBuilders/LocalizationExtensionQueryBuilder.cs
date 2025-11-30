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

public class LocalizationExtensionQueryBuilder() : GraphQueryBuilder<LocalizationExtension>("query localizationExtension")
{
    public LocalizationExtensionQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public LocalizationExtensionQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public LocalizationExtensionQueryBuilder AddFieldPurpose()
    {
        AddField("purpose");
        return this;
    }

    public LocalizationExtensionQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public LocalizationExtensionQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}