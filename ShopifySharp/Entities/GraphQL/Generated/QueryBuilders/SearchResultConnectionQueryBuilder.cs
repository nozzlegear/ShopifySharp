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

public class SearchResultConnectionQueryBuilder() : GraphQueryBuilder<SearchResultConnection>("query searchResultConnection")
{
    public SearchResultConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public SearchResultConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }

    [Obsolete("The provided information is not accurate.")]
    public SearchResultConnectionQueryBuilder AddFieldResultsAfterCount()
    {
        AddField("resultsAfterCount");
        return this;
    }
}