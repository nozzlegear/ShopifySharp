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

public class ExchangeLineItemEdgeQueryBuilder() : GraphQueryBuilder<ExchangeLineItemEdge>("exchangeLineItemEdge")
{
    public ExchangeLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ExchangeLineItemEdgeQueryBuilder AddFieldNode(Func<ExchangeLineItemQueryBuilder, ExchangeLineItemQueryBuilder> build)
    {
        AddField<ExchangeLineItem, ExchangeLineItemQueryBuilder>("node", build);
        return this;
    }
}