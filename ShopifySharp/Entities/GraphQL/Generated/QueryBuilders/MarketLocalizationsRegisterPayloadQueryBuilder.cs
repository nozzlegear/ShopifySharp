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

public class MarketLocalizationsRegisterPayloadQueryBuilder() : GraphQueryBuilder<MarketLocalizationsRegisterPayload>("query marketLocalizationsRegisterPayload")
{
    public MarketLocalizationsRegisterPayloadQueryBuilder AddFieldMarketLocalizations()
    {
        AddField("marketLocalizations");
        return this;
    }

    public MarketLocalizationsRegisterPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}