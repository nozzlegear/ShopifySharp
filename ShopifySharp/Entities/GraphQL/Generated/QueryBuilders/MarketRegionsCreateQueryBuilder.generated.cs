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

[Obsolete("This mutation is deprecated and will be removed in the future. Use `marketCreate` or `marketUpdate` instead.")]
public class MarketRegionsCreateQueryBuilder() : GraphQueryBuilder<MarketRegionsCreatePayload>("marketRegionsCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public MarketRegionsCreateQueryBuilder AddArgumentMarketId(string? marketId)
    {
        AddArgument("marketId", marketId);
        return this;
    }

    public MarketRegionsCreateQueryBuilder AddArgumentRegions(ICollection<MarketRegionCreateInput>? regions)
    {
        AddArgument("regions", regions);
        return this;
    }
}