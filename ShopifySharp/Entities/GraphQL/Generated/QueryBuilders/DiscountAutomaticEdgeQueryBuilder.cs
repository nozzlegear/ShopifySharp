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

public class DiscountAutomaticEdgeQueryBuilder() : GraphQueryBuilder<DiscountAutomaticEdge>("query discountAutomaticEdge")
{
    public DiscountAutomaticEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public DiscountAutomaticEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}