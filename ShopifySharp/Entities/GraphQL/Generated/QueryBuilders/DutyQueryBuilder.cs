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

public class DutyQueryBuilder() : GraphQueryBuilder<Duty>("query duty")
{
    public DutyQueryBuilder AddFieldCountryCodeOfOrigin()
    {
        AddField("countryCodeOfOrigin");
        return this;
    }

    public DutyQueryBuilder AddFieldHarmonizedSystemCode()
    {
        AddField("harmonizedSystemCode");
        return this;
    }

    public DutyQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DutyQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public DutyQueryBuilder AddFieldTaxLines()
    {
        AddField("taxLines");
        return this;
    }
}