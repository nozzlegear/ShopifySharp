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

public class DeliveryLocationGroupZoneEdgeQueryBuilder() : GraphQueryBuilder<DeliveryLocationGroupZoneEdge>("deliveryLocationGroupZoneEdge")
{
    public DeliveryLocationGroupZoneEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DeliveryLocationGroupZoneEdgeQueryBuilder AddFieldNode(Func<DeliveryLocationGroupZoneQueryBuilder, DeliveryLocationGroupZoneQueryBuilder> build)
    {
        AddField<DeliveryLocationGroupZone, DeliveryLocationGroupZoneQueryBuilder>("node", build);
        return this;
    }
}