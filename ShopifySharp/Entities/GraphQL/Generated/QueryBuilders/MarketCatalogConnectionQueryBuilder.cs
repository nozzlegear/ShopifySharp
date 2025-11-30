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

public class MarketCatalogConnectionQueryBuilder() : GraphQueryBuilder<MarketCatalogConnection>("query marketCatalogConnection")
{
    public MarketCatalogConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public MarketCatalogConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public MarketCatalogConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}