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

public class PriceListUpdateQueryBuilder() : GraphQueryBuilder<PriceListUpdatePayload>("query priceListUpdate")
{
    public PriceListUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public PriceListUpdateQueryBuilder AddArgumentInput(PriceListUpdateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}