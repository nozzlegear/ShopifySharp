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

public class PriceListUpdatePayloadQueryBuilder() : GraphQueryBuilder<PriceListUpdatePayload>("query priceListUpdatePayload")
{
    public PriceListUpdatePayloadQueryBuilder AddFieldPriceList()
    {
        AddField("priceList");
        return this;
    }

    public PriceListUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}