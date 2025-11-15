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

[Obsolete("Use `webPresenceUpdate` instead.")]
public class MarketWebPresenceUpdateQueryBuilder() : GraphQueryBuilder<MarketWebPresenceUpdatePayload>("query marketWebPresenceUpdate")
{
    public MarketWebPresenceUpdateQueryBuilder AddArgumentWebPresence(MarketWebPresenceUpdateInput? webPresence)
    {
        AddArgument("webPresence", webPresence);
        return this;
    }

    public MarketWebPresenceUpdateQueryBuilder AddArgumentWebPresenceId(string? webPresenceId)
    {
        AddArgument("webPresenceId", webPresenceId);
        return this;
    }
}