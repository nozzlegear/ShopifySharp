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

public class ExchangeLineItemEdgeQueryBuilder() : GraphQueryBuilder<ExchangeLineItemEdge>("query exchangeLineItemEdge")
{
    public ExchangeLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ExchangeLineItemEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}