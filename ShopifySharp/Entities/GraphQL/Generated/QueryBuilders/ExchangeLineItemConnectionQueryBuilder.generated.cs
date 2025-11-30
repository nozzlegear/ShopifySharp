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

public class ExchangeLineItemConnectionQueryBuilder() : GraphQueryBuilder<ExchangeLineItemConnection>("exchangeLineItemConnection")
{
    public ExchangeLineItemConnectionQueryBuilder AddFieldEdges(Func<ExchangeLineItemEdgeQueryBuilder, ExchangeLineItemEdgeQueryBuilder> build)
    {
        AddField<ExchangeLineItemEdge, ExchangeLineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ExchangeLineItemConnectionQueryBuilder AddFieldNodes(Func<ExchangeLineItemQueryBuilder, ExchangeLineItemQueryBuilder> build)
    {
        AddField<ExchangeLineItem, ExchangeLineItemQueryBuilder>("nodes", build);
        return this;
    }

    public ExchangeLineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}