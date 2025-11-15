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

public class MarketingActivityUpdateExternalQueryBuilder() : GraphQueryBuilder<MarketingActivityUpdateExternalPayload>("query marketingActivityUpdateExternal")
{
    public MarketingActivityUpdateExternalQueryBuilder AddArgumentInput(MarketingActivityUpdateExternalInput? input)
    {
        AddArgument("input", input);
        return this;
    }

    public MarketingActivityUpdateExternalQueryBuilder AddArgumentMarketingActivityId(string? marketingActivityId)
    {
        AddArgument("marketingActivityId", marketingActivityId);
        return this;
    }

    public MarketingActivityUpdateExternalQueryBuilder AddArgumentRemoteId(string? remoteId)
    {
        AddArgument("remoteId", remoteId);
        return this;
    }

    public MarketingActivityUpdateExternalQueryBuilder AddArgumentUtm(UTMInput? utm)
    {
        AddArgument("utm", utm);
        return this;
    }
}