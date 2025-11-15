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

public class DeliveryPromiseParticipantEdgeQueryBuilder() : GraphQueryBuilder<DeliveryPromiseParticipantEdge>("query deliveryPromiseParticipantEdge")
{
    public DeliveryPromiseParticipantEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DeliveryPromiseParticipantEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}