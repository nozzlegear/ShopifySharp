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

public class MarketWebPresenceUpdatePayloadQueryBuilder() : GraphQueryBuilder<MarketWebPresenceUpdatePayload>("marketWebPresenceUpdatePayload")
{
    public MarketWebPresenceUpdatePayloadQueryBuilder AddFieldMarket(Func<MarketQueryBuilder, MarketQueryBuilder> build)
    {
        AddField<Market, MarketQueryBuilder>("market", build);
        return this;
    }

    public MarketWebPresenceUpdatePayloadQueryBuilder AddFieldUserErrors(Func<MarketUserErrorQueryBuilder, MarketUserErrorQueryBuilder> build)
    {
        AddField<MarketUserError, MarketUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}