#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class AbandonedCheckoutLineItemEdgeQueryBuilder() : GraphQueryBuilder<AbandonedCheckoutLineItemEdge>("query abandonedCheckoutLineItemEdge")
{
    public AbandonedCheckoutLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public AbandonedCheckoutLineItemEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}