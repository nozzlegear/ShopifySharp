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

public class ReverseDeliveryLineItemEdgeQueryBuilder() : GraphQueryBuilder<ReverseDeliveryLineItemEdge>("reverseDeliveryLineItemEdge")
{
    public ReverseDeliveryLineItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ReverseDeliveryLineItemEdgeQueryBuilder AddFieldNode(Func<ReverseDeliveryLineItemQueryBuilder, ReverseDeliveryLineItemQueryBuilder> build)
    {
        AddField<ReverseDeliveryLineItem, ReverseDeliveryLineItemQueryBuilder>("node", build);
        return this;
    }
}