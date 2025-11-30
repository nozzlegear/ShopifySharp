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

public class ReturnableFulfillmentLineItemEdgeQueryBuilder() : GraphQueryBuilder<ReturnableFulfillmentLineItemEdge>("returnableFulfillmentLineItemEdge")
{
    public ReturnableFulfillmentLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ReturnableFulfillmentLineItemEdgeQueryBuilder AddFieldNode(Func<ReturnableFulfillmentLineItemQueryBuilder, ReturnableFulfillmentLineItemQueryBuilder> build)
    {
        AddField<ReturnableFulfillmentLineItem, ReturnableFulfillmentLineItemQueryBuilder>("node", build);
        return this;
    }
}