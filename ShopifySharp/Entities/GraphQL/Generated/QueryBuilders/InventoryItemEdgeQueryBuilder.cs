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

public class InventoryItemEdgeQueryBuilder() : GraphQueryBuilder<InventoryItemEdge>("query inventoryItemEdge")
{
    public InventoryItemEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public InventoryItemEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}