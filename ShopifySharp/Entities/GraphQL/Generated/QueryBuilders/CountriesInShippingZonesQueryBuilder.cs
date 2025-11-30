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

public class CountriesInShippingZonesQueryBuilder() : GraphQueryBuilder<CountriesInShippingZones>("query countriesInShippingZones")
{
    public CountriesInShippingZonesQueryBuilder AddFieldCountryCodes()
    {
        AddField("countryCodes");
        return this;
    }

    public CountriesInShippingZonesQueryBuilder AddFieldIncludeRestOfWorld()
    {
        AddField("includeRestOfWorld");
        return this;
    }
}