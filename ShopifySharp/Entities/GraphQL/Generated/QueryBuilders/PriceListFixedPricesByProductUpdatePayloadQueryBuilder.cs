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

public class PriceListFixedPricesByProductUpdatePayloadQueryBuilder() : GraphQueryBuilder<PriceListFixedPricesByProductUpdatePayload>("query priceListFixedPricesByProductUpdatePayload")
{
    public PriceListFixedPricesByProductUpdatePayloadQueryBuilder AddFieldPriceList()
    {
        AddField("priceList");
        return this;
    }

    public PriceListFixedPricesByProductUpdatePayloadQueryBuilder AddFieldPricesToAddProducts()
    {
        AddField("pricesToAddProducts");
        return this;
    }

    public PriceListFixedPricesByProductUpdatePayloadQueryBuilder AddFieldPricesToDeleteProducts()
    {
        AddField("pricesToDeleteProducts");
        return this;
    }

    public PriceListFixedPricesByProductUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}