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

public class MarketingEngagementsDeletePayloadQueryBuilder() : GraphQueryBuilder<MarketingEngagementsDeletePayload>("query marketingEngagementsDeletePayload")
{
    public MarketingEngagementsDeletePayloadQueryBuilder AddFieldResult()
    {
        AddField("result");
        return this;
    }

    public MarketingEngagementsDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}