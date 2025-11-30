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

public class CountryHarmonizedSystemCodeConnectionQueryBuilder() : GraphQueryBuilder<CountryHarmonizedSystemCodeConnection>("query countryHarmonizedSystemCodeConnection")
{
    public CountryHarmonizedSystemCodeConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CountryHarmonizedSystemCodeConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CountryHarmonizedSystemCodeConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}