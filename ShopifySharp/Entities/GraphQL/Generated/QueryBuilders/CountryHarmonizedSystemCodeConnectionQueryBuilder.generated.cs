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

public class CountryHarmonizedSystemCodeConnectionQueryBuilder() : GraphQueryBuilder<CountryHarmonizedSystemCodeConnection>("countryHarmonizedSystemCodeConnection")
{
    public CountryHarmonizedSystemCodeConnectionQueryBuilder AddFieldEdges(Func<CountryHarmonizedSystemCodeEdgeQueryBuilder, CountryHarmonizedSystemCodeEdgeQueryBuilder> build)
    {
        AddField<CountryHarmonizedSystemCodeEdge, CountryHarmonizedSystemCodeEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CountryHarmonizedSystemCodeConnectionQueryBuilder AddFieldNodes(Func<CountryHarmonizedSystemCodeQueryBuilder, CountryHarmonizedSystemCodeQueryBuilder> build)
    {
        AddField<CountryHarmonizedSystemCode, CountryHarmonizedSystemCodeQueryBuilder>("nodes", build);
        return this;
    }

    public CountryHarmonizedSystemCodeConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}