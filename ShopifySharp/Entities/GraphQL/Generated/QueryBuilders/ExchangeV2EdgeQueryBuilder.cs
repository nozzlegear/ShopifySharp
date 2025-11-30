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

public class ExchangeV2EdgeQueryBuilder() : GraphQueryBuilder<ExchangeV2Edge>("query exchangeV2Edge")
{
    public ExchangeV2EdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ExchangeV2EdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}