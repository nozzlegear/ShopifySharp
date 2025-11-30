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

public class CountryHarmonizedSystemCodeEdgeQueryBuilder() : GraphQueryBuilder<CountryHarmonizedSystemCodeEdge>("query countryHarmonizedSystemCodeEdge")
{
    public CountryHarmonizedSystemCodeEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CountryHarmonizedSystemCodeEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}