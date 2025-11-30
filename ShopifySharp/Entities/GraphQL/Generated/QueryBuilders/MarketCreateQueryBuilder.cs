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

public class MarketCreateQueryBuilder() : GraphQueryBuilder<MarketCreatePayload>("query marketCreate")
{
    public MarketCreateQueryBuilder AddArgumentInput(MarketCreateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}