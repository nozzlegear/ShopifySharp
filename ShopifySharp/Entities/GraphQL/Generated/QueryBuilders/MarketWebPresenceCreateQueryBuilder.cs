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

[Obsolete("Use `webPresenceCreate` instead.")]
public class MarketWebPresenceCreateQueryBuilder() : GraphQueryBuilder<MarketWebPresenceCreatePayload>("query marketWebPresenceCreate")
{
    public MarketWebPresenceCreateQueryBuilder AddArgumentMarketId(string? marketId)
    {
        AddArgument("marketId", marketId);
        return this;
    }

    public MarketWebPresenceCreateQueryBuilder AddArgumentWebPresence(MarketWebPresenceCreateInput? webPresence)
    {
        AddArgument("webPresence", webPresence);
        return this;
    }
}