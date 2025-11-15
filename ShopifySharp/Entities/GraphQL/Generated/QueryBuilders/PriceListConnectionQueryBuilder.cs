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

public class PriceListConnectionQueryBuilder() : GraphQueryBuilder<PriceListConnection>("query priceListConnection")
{
    public PriceListConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public PriceListConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public PriceListConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}