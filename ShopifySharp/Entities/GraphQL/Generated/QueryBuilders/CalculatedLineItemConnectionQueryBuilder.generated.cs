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

public class CalculatedLineItemConnectionQueryBuilder() : GraphQueryBuilder<CalculatedLineItemConnection>("calculatedLineItemConnection")
{
    public CalculatedLineItemConnectionQueryBuilder AddFieldEdges(Func<CalculatedLineItemEdgeQueryBuilder, CalculatedLineItemEdgeQueryBuilder> build)
    {
        AddField<CalculatedLineItemEdge, CalculatedLineItemEdgeQueryBuilder>("edges", build);
        return this;
    }

    public CalculatedLineItemConnectionQueryBuilder AddFieldNodes(Func<CalculatedLineItemQueryBuilder, CalculatedLineItemQueryBuilder> build)
    {
        AddField<CalculatedLineItem, CalculatedLineItemQueryBuilder>("nodes", build);
        return this;
    }

    public CalculatedLineItemConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}