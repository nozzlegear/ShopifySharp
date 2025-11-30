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

public class PriceListFixedPricesAddPayloadQueryBuilder() : GraphQueryBuilder<PriceListFixedPricesAddPayload>("query priceListFixedPricesAddPayload")
{
    public PriceListFixedPricesAddPayloadQueryBuilder AddFieldPrices()
    {
        AddField("prices");
        return this;
    }

    public PriceListFixedPricesAddPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}