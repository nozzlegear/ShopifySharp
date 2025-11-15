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

public class MarketLocalizableResourceEdgeQueryBuilder() : GraphQueryBuilder<MarketLocalizableResourceEdge>("query marketLocalizableResourceEdge")
{
    public MarketLocalizableResourceEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public MarketLocalizableResourceEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}