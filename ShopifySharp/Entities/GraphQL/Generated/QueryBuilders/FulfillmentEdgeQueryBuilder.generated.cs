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

public class FulfillmentEdgeQueryBuilder() : GraphQueryBuilder<FulfillmentEdge>("fulfillmentEdge")
{
    public FulfillmentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public FulfillmentEdgeQueryBuilder AddFieldNode(Func<FulfillmentQueryBuilder, FulfillmentQueryBuilder> build)
    {
        AddField<Fulfillment, FulfillmentQueryBuilder>("node", build);
        return this;
    }
}