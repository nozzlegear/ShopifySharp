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

public class MarketingActivityDeleteExternalQueryBuilder() : GraphQueryBuilder<MarketingActivityDeleteExternalPayload>("query marketingActivityDeleteExternal")
{
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