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

public class SearchResultQueryBuilder() : GraphQueryBuilder<SearchResult>("query searchResult")
{
    public SearchResultQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public SearchResultQueryBuilder AddFieldImage()
    {
        AddField("image");
        return this;
    }

    public SearchResultQueryBuilder AddFieldReference()
    {
        AddField("reference");
        return this;
    }

    public SearchResultQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }

    public SearchResultQueryBuilder AddFieldUrl()
    {
        AddField("url");
        return this;
    }
}