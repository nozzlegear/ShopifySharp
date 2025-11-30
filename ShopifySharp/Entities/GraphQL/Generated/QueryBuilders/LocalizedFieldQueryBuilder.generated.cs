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

public class LocalizedFieldQueryBuilder() : GraphQueryBuilder<LocalizedField>("localizedField")
{
    public LocalizedFieldQueryBuilder AddFieldCountryCode()
    {
        AddField("countryCode");
        return this;
    }

    public LocalizedFieldQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public LocalizedFieldQueryBuilder AddFieldPurpose()
    {
        AddField("purpose");
        return this;
    }

    public LocalizedFieldQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public LocalizedFieldQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}