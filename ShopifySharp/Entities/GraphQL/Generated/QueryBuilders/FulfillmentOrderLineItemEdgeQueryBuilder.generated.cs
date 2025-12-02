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

public class FulfillmentOrderLineItemEdgeQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLineItemEdge>("fulfillmentOrderLineItemEdge")
{
    public FulfillmentOrderLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public FulfillmentOrderLineItemEdgeQueryBuilder AddFieldNode(Func<FulfillmentOrderLineItemQueryBuilder, FulfillmentOrderLineItemQueryBuilder> build)
    {
        AddField<FulfillmentOrderLineItem, FulfillmentOrderLineItemQueryBuilder>("node", build);
        return this;
    }
}