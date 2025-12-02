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

public class DeliveryPromiseParticipantEdgeQueryBuilder() : GraphQueryBuilder<DeliveryPromiseParticipantEdge>("deliveryPromiseParticipantEdge")
{
    public DeliveryPromiseParticipantEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DeliveryPromiseParticipantEdgeQueryBuilder AddFieldNode(Func<DeliveryPromiseParticipantQueryBuilder, DeliveryPromiseParticipantQueryBuilder> build)
    {
        AddField<DeliveryPromiseParticipant, DeliveryPromiseParticipantQueryBuilder>("node", build);
        return this;
    }
}