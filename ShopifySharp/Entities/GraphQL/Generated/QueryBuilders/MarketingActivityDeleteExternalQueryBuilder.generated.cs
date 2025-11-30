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

public class MarketingActivityDeleteExternalQueryBuilder() : GraphQueryBuilder<MarketingActivityDeleteExternalPayload>("marketingActivityDeleteExternal"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public MarketingActivityDeleteExternalQueryBuilder AddArgumentMarketingActivityId(string? marketingActivityId)
    {
        AddArgument("marketingActivityId", marketingActivityId);
        return this;
    }

    public MarketingActivityDeleteExternalQueryBuilder AddArgumentRemoteId(string? remoteId)
    {
        AddArgument("remoteId", remoteId);
        return this;
    }
}