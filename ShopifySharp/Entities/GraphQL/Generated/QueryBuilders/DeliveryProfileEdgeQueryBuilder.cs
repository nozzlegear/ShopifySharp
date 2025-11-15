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

public class DeliveryProfileEdgeQueryBuilder() : GraphQueryBuilder<DeliveryProfileEdge>("query deliveryProfileEdge")
{
    public DeliveryProfileEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DeliveryProfileEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}