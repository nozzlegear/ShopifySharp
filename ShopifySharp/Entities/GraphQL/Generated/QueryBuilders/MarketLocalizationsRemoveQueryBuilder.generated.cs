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

public class MarketLocalizationsRemoveQueryBuilder() : GraphQueryBuilder<MarketLocalizationsRemovePayload>("marketLocalizationsRemove"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public MarketLocalizationsRemoveQueryBuilder AddArgumentMarketIds(ICollection<string>? marketIds)
    {
        AddArgument("marketIds", marketIds);
        return this;
    }

    public MarketLocalizationsRemoveQueryBuilder AddArgumentMarketLocalizationKeys(ICollection<string>? marketLocalizationKeys)
    {
        AddArgument("marketLocalizationKeys", marketLocalizationKeys);
        return this;
    }

    public MarketLocalizationsRemoveQueryBuilder AddArgumentResourceId(string? resourceId)
    {
        AddArgument("resourceId", resourceId);
        return this;
    }
}