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

public class ReverseDeliveryEdgeQueryBuilder() : GraphQueryBuilder<ReverseDeliveryEdge>("reverseDeliveryEdge")
{
    public ReverseDeliveryEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ReverseDeliveryEdgeQueryBuilder AddFieldNode(Func<ReverseDeliveryQueryBuilder, ReverseDeliveryQueryBuilder> build)
    {
        AddField<ReverseDelivery, ReverseDeliveryQueryBuilder>("node", build);
        return this;
    }
}