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

public class ReverseFulfillmentOrderLineItemEdgeQueryBuilder() : GraphQueryBuilder<ReverseFulfillmentOrderLineItemEdge>("reverseFulfillmentOrderLineItemEdge")
{
    public ReverseFulfillmentOrderLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ReverseFulfillmentOrderLineItemEdgeQueryBuilder AddFieldNode(Func<ReverseFulfillmentOrderLineItemQueryBuilder, ReverseFulfillmentOrderLineItemQueryBuilder> build)
    {
        AddField<ReverseFulfillmentOrderLineItem, ReverseFulfillmentOrderLineItemQueryBuilder>("node", build);
        return this;
    }
}