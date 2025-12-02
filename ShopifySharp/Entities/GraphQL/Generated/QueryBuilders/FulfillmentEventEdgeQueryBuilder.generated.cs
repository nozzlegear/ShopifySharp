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

public class FulfillmentEventEdgeQueryBuilder() : GraphQueryBuilder<FulfillmentEventEdge>("fulfillmentEventEdge")
{
    public FulfillmentEventEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public FulfillmentEventEdgeQueryBuilder AddFieldNode(Func<FulfillmentEventQueryBuilder, FulfillmentEventQueryBuilder> build)
    {
        AddField<FulfillmentEvent, FulfillmentEventQueryBuilder>("node", build);
        return this;
    }
}