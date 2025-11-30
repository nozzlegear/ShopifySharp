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

public class DeliveryPromiseParticipantConnectionQueryBuilder() : GraphQueryBuilder<DeliveryPromiseParticipantConnection>("deliveryPromiseParticipantConnection")
{
    public DeliveryPromiseParticipantConnectionQueryBuilder AddFieldEdges(Func<DeliveryPromiseParticipantEdgeQueryBuilder, DeliveryPromiseParticipantEdgeQueryBuilder> build)
    {
        AddField<DeliveryPromiseParticipantEdge, DeliveryPromiseParticipantEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DeliveryPromiseParticipantConnectionQueryBuilder AddFieldNodes(Func<DeliveryPromiseParticipantQueryBuilder, DeliveryPromiseParticipantQueryBuilder> build)
    {
        AddField<DeliveryPromiseParticipant, DeliveryPromiseParticipantQueryBuilder>("nodes", build);
        return this;
    }

    public DeliveryPromiseParticipantConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}