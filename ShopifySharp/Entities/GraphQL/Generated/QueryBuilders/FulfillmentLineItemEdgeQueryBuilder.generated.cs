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

public class FulfillmentLineItemEdgeQueryBuilder() : GraphQueryBuilder<FulfillmentLineItemEdge>("fulfillmentLineItemEdge")
{
    public FulfillmentLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public FulfillmentLineItemEdgeQueryBuilder AddFieldNode(Func<FulfillmentLineItemQueryBuilder, FulfillmentLineItemQueryBuilder> build)
    {
        AddField<FulfillmentLineItem, FulfillmentLineItemQueryBuilder>("node", build);
        return this;
    }
}