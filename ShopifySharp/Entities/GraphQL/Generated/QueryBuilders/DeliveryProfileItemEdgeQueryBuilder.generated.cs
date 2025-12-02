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

public class DeliveryProfileItemEdgeQueryBuilder() : GraphQueryBuilder<DeliveryProfileItemEdge>("deliveryProfileItemEdge")
{
    public DeliveryProfileItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DeliveryProfileItemEdgeQueryBuilder AddFieldNode(Func<DeliveryProfileItemQueryBuilder, DeliveryProfileItemQueryBuilder> build)
    {
        AddField<DeliveryProfileItem, DeliveryProfileItemQueryBuilder>("node", build);
        return this;
    }
}