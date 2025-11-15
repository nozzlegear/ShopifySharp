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

public class PriceListFixedPricesAddQueryBuilder() : GraphQueryBuilder<PriceListFixedPricesAddPayload>("query priceListFixedPricesAdd")
{
    public PriceListFixedPricesAddQueryBuilder AddArgumentPriceListId(string? priceListId)
    {
        AddArgument("priceListId", priceListId);
        return this;
    }

    public PriceListFixedPricesAddQueryBuilder AddArgumentPrices(ICollection<PriceListPriceInput>? prices)
    {
        AddArgument("prices", prices);
        return this;
    }
}