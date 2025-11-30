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

public class PriceListPriceConnectionQueryBuilder() : GraphQueryBuilder<PriceListPriceConnection>("query priceListPriceConnection")
{
    public PriceListPriceConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public PriceListPriceConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public PriceListPriceConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}