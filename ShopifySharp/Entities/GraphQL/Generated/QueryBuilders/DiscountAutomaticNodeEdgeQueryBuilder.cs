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

public class DiscountAutomaticNodeEdgeQueryBuilder() : GraphQueryBuilder<DiscountAutomaticNodeEdge>("query discountAutomaticNodeEdge")
{
    public DiscountAutomaticNodeEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DiscountAutomaticNodeEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}