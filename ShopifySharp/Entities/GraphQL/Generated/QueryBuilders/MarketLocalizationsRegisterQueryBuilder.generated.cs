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

public class MarketLocalizationsRegisterQueryBuilder() : GraphQueryBuilder<MarketLocalizationsRegisterPayload>("marketLocalizationsRegister"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public MarketLocalizationsRegisterQueryBuilder AddArgumentMarketLocalizations(ICollection<MarketLocalizationRegisterInput>? marketLocalizations)
    {
        AddArgument("marketLocalizations", marketLocalizations);
        return this;
    }

    public MarketLocalizationsRegisterQueryBuilder AddArgumentResourceId(string? resourceId)
    {
        AddArgument("resourceId", resourceId);
        return this;
    }
}