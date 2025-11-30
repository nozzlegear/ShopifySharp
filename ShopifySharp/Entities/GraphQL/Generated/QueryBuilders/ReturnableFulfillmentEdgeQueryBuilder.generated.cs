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

public class ReturnableFulfillmentEdgeQueryBuilder() : GraphQueryBuilder<ReturnableFulfillmentEdge>("returnableFulfillmentEdge")
{
    public ReturnableFulfillmentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ReturnableFulfillmentEdgeQueryBuilder AddFieldNode(Func<ReturnableFulfillmentQueryBuilder, ReturnableFulfillmentQueryBuilder> build)
    {
        AddField<ReturnableFulfillment, ReturnableFulfillmentQueryBuilder>("node", build);
        return this;
    }
}