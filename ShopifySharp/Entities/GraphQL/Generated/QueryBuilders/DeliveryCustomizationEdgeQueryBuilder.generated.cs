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

public class DeliveryCustomizationEdgeQueryBuilder() : GraphQueryBuilder<DeliveryCustomizationEdge>("deliveryCustomizationEdge")
{
    public DeliveryCustomizationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DeliveryCustomizationEdgeQueryBuilder AddFieldNode(Func<DeliveryCustomizationQueryBuilder, DeliveryCustomizationQueryBuilder> build)
    {
        AddField<DeliveryCustomization, DeliveryCustomizationQueryBuilder>("node", build);
        return this;
    }
}