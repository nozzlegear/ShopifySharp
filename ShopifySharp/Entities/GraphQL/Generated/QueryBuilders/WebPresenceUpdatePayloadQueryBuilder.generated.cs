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

public class WebPresenceUpdatePayloadQueryBuilder() : GraphQueryBuilder<WebPresenceUpdatePayload>("webPresenceUpdatePayload")
{
    public WebPresenceUpdatePayloadQueryBuilder AddFieldUserErrors(Func<MarketUserErrorQueryBuilder, MarketUserErrorQueryBuilder> build)
    {
        AddField<MarketUserError, MarketUserErrorQueryBuilder>("userErrors", build);
        return this;
    }

    public WebPresenceUpdatePayloadQueryBuilder AddFieldWebPresence(Func<MarketWebPresenceQueryBuilder, MarketWebPresenceQueryBuilder> build)
    {
        AddField<MarketWebPresence, MarketWebPresenceQueryBuilder>("webPresence", build);
        return this;
    }
}