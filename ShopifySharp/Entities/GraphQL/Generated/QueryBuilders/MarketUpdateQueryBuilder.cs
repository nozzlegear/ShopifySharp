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

public class MarketUpdateQueryBuilder() : GraphQueryBuilder<MarketUpdatePayload>("query marketUpdate")
{
    public MarketUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public MarketUpdateQueryBuilder AddArgumentInput(MarketUpdateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}