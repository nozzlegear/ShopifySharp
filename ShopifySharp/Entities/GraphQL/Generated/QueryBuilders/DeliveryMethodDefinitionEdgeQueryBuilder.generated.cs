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

public class DeliveryMethodDefinitionEdgeQueryBuilder() : GraphQueryBuilder<DeliveryMethodDefinitionEdge>("deliveryMethodDefinitionEdge")
{
    public DeliveryMethodDefinitionEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DeliveryMethodDefinitionEdgeQueryBuilder AddFieldNode(Func<DeliveryMethodDefinitionQueryBuilder, DeliveryMethodDefinitionQueryBuilder> build)
    {
        AddField<DeliveryMethodDefinition, DeliveryMethodDefinitionQueryBuilder>("node", build);
        return this;
    }
}