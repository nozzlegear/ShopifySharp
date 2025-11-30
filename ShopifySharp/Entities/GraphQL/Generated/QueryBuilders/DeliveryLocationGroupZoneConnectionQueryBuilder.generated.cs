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

public class DeliveryLocationGroupZoneConnectionQueryBuilder() : GraphQueryBuilder<DeliveryLocationGroupZoneConnection>("deliveryLocationGroupZoneConnection")
{
    public DeliveryLocationGroupZoneConnectionQueryBuilder AddFieldEdges(Func<DeliveryLocationGroupZoneEdgeQueryBuilder, DeliveryLocationGroupZoneEdgeQueryBuilder> build)
    {
        AddField<DeliveryLocationGroupZoneEdge, DeliveryLocationGroupZoneEdgeQueryBuilder>("edges", build);
        return this;
    }

    public DeliveryLocationGroupZoneConnectionQueryBuilder AddFieldNodes(Func<DeliveryLocationGroupZoneQueryBuilder, DeliveryLocationGroupZoneQueryBuilder> build)
    {
        AddField<DeliveryLocationGroupZone, DeliveryLocationGroupZoneQueryBuilder>("nodes", build);
        return this;
    }

    public DeliveryLocationGroupZoneConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}