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

public class PriceListFixedPricesUpdatePayloadQueryBuilder() : GraphQueryBuilder<PriceListFixedPricesUpdatePayload>("query priceListFixedPricesUpdatePayload")
{
    public PriceListFixedPricesUpdatePayloadQueryBuilder AddFieldDeletedFixedPriceVariantIds()
    {
        AddField("deletedFixedPriceVariantIds");
        return this;
    }

    public PriceListFixedPricesUpdatePayloadQueryBuilder AddFieldPriceList()
    {
        AddField("priceList");
        return this;
    }

    public PriceListFixedPricesUpdatePayloadQueryBuilder AddFieldPricesAdded()
    {
        AddField("pricesAdded");
        return this;
    }

    public PriceListFixedPricesUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}