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

public class SellingPlanEdgeQueryBuilder() : GraphQueryBuilder<SellingPlanEdge>("query sellingPlanEdge")
{
    public SellingPlanEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public SellingPlanEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}