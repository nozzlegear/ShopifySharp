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

public class PriceListPriceQueryBuilder() : GraphQueryBuilder<PriceListPrice>("query priceListPrice")
{
    public PriceListPriceQueryBuilder AddFieldCompareAtPrice()
    {
        AddField("compareAtPrice");
        return this;
    }

    public PriceListPriceQueryBuilder AddFieldOriginType()
    {
        AddField("originType");
        return this;
    }

    public PriceListPriceQueryBuilder AddFieldPrice()
    {
        AddField("price");
        return this;
    }

    public PriceListPriceQueryBuilder AddFieldQuantityPriceBreaks()
    {
        AddField("quantityPriceBreaks");
        return this;
    }

    public PriceListPriceQueryBuilder AddFieldVariant()
    {
        AddField("variant");
        return this;
    }
}