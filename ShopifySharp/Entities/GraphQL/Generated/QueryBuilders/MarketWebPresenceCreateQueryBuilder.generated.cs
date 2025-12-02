#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

[Obsolete("Use `webPresenceCreate` instead.")]
public class MarketWebPresenceCreateQueryBuilder() : GraphQueryBuilder<MarketWebPresenceCreatePayload>("marketWebPresenceCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

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