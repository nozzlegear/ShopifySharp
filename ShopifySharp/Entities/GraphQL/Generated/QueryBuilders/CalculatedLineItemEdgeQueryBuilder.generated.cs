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

public class CalculatedLineItemEdgeQueryBuilder() : GraphQueryBuilder<CalculatedLineItemEdge>("calculatedLineItemEdge")
{
    public CalculatedLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CalculatedLineItemEdgeQueryBuilder AddFieldNode(Func<CalculatedLineItemQueryBuilder, CalculatedLineItemQueryBuilder> build)
    {
        AddField<CalculatedLineItem, CalculatedLineItemQueryBuilder>("node", build);
        return this;
    }
}